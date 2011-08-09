using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeepAnalysis.Core;

namespace DeepAnalysis.Net.Mcdi
{
    public class McdiCardParser
    {
        private Database database;

        public McdiCardParser(Database Database)
        {
            database = Database;
        }

        public void ParseUrl(string url)
        {

            UrlScraper scraper = new UrlScraper();
            string html = scraper.Scrape(McdiSiteParser.PREFIX + url);

            int curpos = html.IndexOf(url);

            // Parse the Card
            Card card = ParseCard(html, ref curpos);

            // Parse the Printing
            Printing printing = ParsePrinting(html, ref curpos, card);
            // Image Url
            printing.ImageUrl = McdiSiteParser.PREFIX + "scans/en/" + printing.Edition.Abbreviation + "/" + printing.CollectorNumber + ".jpg";
            // Source Url
            printing.SourceUrl = McdiSiteParser.PREFIX +url;

            // Add the card to the Database
            int index = database.Cards.IndexOf(card);
            if (index != -1)
            {
                // Find the card if it already exists
                card = database.Cards[index];
            }
            else
            {
                // Add the card if it's new
                database.Cards.Add(card);
            }
            // Update Edition information
            card.Printings.Add(printing);


            //Console.WriteLine(card);
        }

        private Printing ParsePrinting(string html, ref int curpos, Card card) // Card has to be passed because of their page for Abuna's Chant is broken
        {
            Printing printing = new Printing();
            {
                // Flavor Text
                {
                    string leftToken = "<p><i>";
                    string rightToken = "</i></p>";
                    int leftIndex = html.IndexOf(leftToken, curpos);
                    int rightIndex = html.IndexOf(rightToken, leftIndex);
                    printing.FlavorText = html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                    curpos = rightIndex;
                }

                // Artist
                {
                    string leftToken = "<p>Illus. ";
                    string rightToken = "</p>";
                    int leftIndex = html.IndexOf(leftToken, curpos);
                    int rightIndex = html.IndexOf(rightToken, leftIndex);
                    printing.Artist = html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                    curpos = rightIndex;
                }

                curpos = html.IndexOf("Printings:", curpos);

                // Collector Number
                {
                    if (card.Name == "Abuna's Chant")
                    {
                        printing.CollectorNumber = 1;
                    }
                    else //hack b/c the page is broken
                    {
                        string leftToken = "<b>#";
                        string rightToken = " (";
                        int leftIndex = html.IndexOf(leftToken, curpos);
                        int rightIndex = html.IndexOf(rightToken, leftIndex);
                        printing.CollectorNumber = int.Parse(html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length));
                        curpos = rightIndex;
                    }
                }

                curpos = html.IndexOf("Editions:", curpos);

                // Edition
                {
                    string setName;
                    if (card.Name == "Abuna's Chant")
                    {
                        setName = "Fifth Dawn";
                    }
                    else //hack b/c the page is broken
                    {
                        string leftToken = "<b>";
                        string rightToken = " (";
                        int leftIndex = html.IndexOf(leftToken, curpos);
                        int rightIndex = html.IndexOf(rightToken, leftIndex);
                        setName = html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                        curpos = rightIndex;
                    }
                    printing.Edition = (from ed in database.Editions where ed.Name == setName select ed).First();
                }

                // Rarity
                {
                    if (card.Name == "Abuna's Chant")
                    {
                        printing.Rarity = new Rarity("Common");
                    }
                    else //hack b/c the page is broken
                    {
                        string leftToken = "(";
                        string rightToken = ")";
                        int leftIndex = html.IndexOf(leftToken, curpos);
                        int rightIndex = html.IndexOf(rightToken, leftIndex);
                        string fullRarirtyString = html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                        if (fullRarirtyString.Contains(leftToken))
                        {
                            fullRarirtyString += rightToken;
                        }
                        printing.Rarity = new Rarity(fullRarirtyString);
                        curpos = rightIndex;
                    }
                }
            }
            return printing;
        }

        private Card ParseCard(string html, ref int curpos)
        {
            Card card = new Card();
            {
                // Card Name
                {
                    string leftToken = "\">";
                    string rightToken = "</a>";
                    int leftIndex = html.IndexOf(leftToken, curpos);
                    int rightIndex = html.IndexOf(rightToken, leftIndex);
                    card.Name = html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                    curpos = rightIndex;
                }

                // Typeline,  Mana Cost
                {
                    bool hasManaCost;
                    bool parsableManaCost;
                    int updatepos = curpos;
                    {
                        string leftToken = "<p>";
                        string splitToken = ",";
                        string rightToken = "</p>";
                        int leftIndex = html.IndexOf(leftToken, curpos);
                        int rightIndex = html.IndexOf(rightToken, leftIndex);
                        string typelineString = html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                        updatepos = rightIndex;

                        // Special case cards with no mana cost
                        if (typelineString.ToLower().Contains("land"))
                        {
                            hasManaCost = false;
                        }
                        else
                        {
                            hasManaCost = true;
                        }

                        if (typelineString.Contains(splitToken))
                        {
                            parsableManaCost = true;
                            card.Typeline = typelineString.Substring(0, typelineString.IndexOf(splitToken));
                        }
                        else
                        {
                            parsableManaCost = false;
                            card.Typeline = typelineString;
                        }
                    }

                    if (hasManaCost)
                    {
                        if (parsableManaCost)
                        {
                            string leftToken = ", \n";
                            string splitToken = "(";
                            string rightToken = "</p>";
                            int leftIndex = html.IndexOf(leftToken, curpos);
                            int rightIndex = html.IndexOf(rightToken, leftIndex);
                            string manaCostString = html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                            if (manaCostString.Contains(splitToken))
                            {
                                manaCostString = manaCostString.Substring(0, manaCostString.IndexOf(splitToken)).Trim();
                            }
                            card.Cost = new ManaCost(manaCostString);
                            updatepos = rightIndex;
                        }
                        else
                        {
                            card.Cost = new ManaCost(true);
                        }
                    }
                    curpos = updatepos;
                }

                // Textbox
                {
                    string leftToken = "<p class=\"ctext\"><b>";
                    string rightToken = "</b></p>";
                    int leftIndex = html.IndexOf(leftToken, curpos);
                    int rightIndex = html.IndexOf(rightToken, leftIndex);
                    card.Text = html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length).Replace("<br><br>", "\r\n\r\n");
                    curpos = rightIndex;
                }
            }
            return card;
        }
    }
}
