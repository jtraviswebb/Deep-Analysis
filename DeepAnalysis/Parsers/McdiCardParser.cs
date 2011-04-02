using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeepAnalysis.Core;

namespace DeepAnalysis.Parsers
{
    class McdiCardParser
    {
        private string cardName;

        public McdiCardParser(string CardName)
        {
            cardName = CardName;
        }

        public Card ParseUrl(string url)
        {
            Card result = new Card();

            UrlScraper scraper = new UrlScraper();
            string html = scraper.Scrape(McdiParser.PREFIX + url);

            int curpos = html.IndexOf(url);

            // Card Name
            {
                string leftToken = "\">";
                string rightToken = "</a>";
                int leftIndex = html.IndexOf(leftToken, curpos);
                int rightIndex = html.IndexOf(rightToken, leftIndex);
                result.Name = html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
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
                        result.Typeline = typelineString.Substring(0, typelineString.IndexOf(splitToken));
                    }
                    else
                    {
                        parsableManaCost = false;
                        result.Typeline = typelineString;
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
                        result.Cost = new ManaCost(manaCostString);
                        updatepos = rightIndex;
                    }
                    else
                    {
                        result.Cost = new ManaCost(true);
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
                result.Text = html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length).Replace("<br><br>", "\r\n\r\n");
                curpos = rightIndex;
            }

            // Flavor Text
            string flavorText;
            {
                string leftToken = "<p><i>";
                string rightToken = "</i></p>";
                int leftIndex = html.IndexOf(leftToken, curpos);
                int rightIndex = html.IndexOf(rightToken, leftIndex);
                flavorText = html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                curpos = rightIndex;
            }

            // Artist
            string artist;
            {
                string leftToken = "<p>Illus. ";
                string rightToken = "</p>";
                int leftIndex = html.IndexOf(leftToken, curpos);
                int rightIndex = html.IndexOf(rightToken, leftIndex);
                artist = html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                curpos = rightIndex;
            }

            curpos = html.IndexOf("Printings:", curpos);

            // Collector Number
            int collectorNumber;
            {
                if (result.Name == "Abuna's Chant")
                {
                    collectorNumber = 1;
                }
                else //hack b/c the page is broken
                {
                    string leftToken = "<b>#";
                    string rightToken = " (";
                    int leftIndex = html.IndexOf(leftToken, curpos);
                    int rightIndex = html.IndexOf(rightToken, leftIndex);
                    collectorNumber = int.Parse(html.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length));
                    curpos = rightIndex;
                }
            }

            curpos = html.IndexOf("Editions:", curpos);

            // Set Name
            string setName;
            {
                if (result.Name == "Abuna's Chant")
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
            }

            // Rarity
            Rarity rarity;
            {
                if (result.Name == "Abuna's Chant")
                {
                    rarity = new Rarity("Common");
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
                    rarity = new Rarity(fullRarirtyString);
                    curpos = rightIndex;
                }
            }

            // Image Url
            string imageUrl;
            {
                imageUrl = McdiParser.PREFIX + url.Substring(1, url.Length - 1 - "html".Length) + "jpg";
            }

            // Update Edition information
            result.Editions.Add(new Edition(setName, collectorNumber, artist, flavorText, rarity, imageUrl));

            //Console.WriteLine(result);

            return result;
        }
    }
}
