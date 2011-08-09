using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeepAnalysis.Core;
using System.Net;
using System.IO;

namespace DeepAnalysis.Net.Mcdi
{
    class McdiCardPricer : CardPricer
    {
        private static string BILLBOARD_PREFIX = "http://partner.tcgplayer.com/syn/Synidcate.ashx?pk=MAGCINFO&pi=";

        public void PriceMatrix()
        {
        }

        public override List<PriceEntry> PriceCard(Printing printing)
        {
            return PriceCard(printing.Edition.Abbreviation, printing.CollectorNumber);
        }

        public List<PriceEntry> PriceCard(string SetAbbreviation, int CollectorNumber)
        {
            // Find the tcgplayer link
            string storeUrl;
            {
                UrlScraper scraper = new UrlScraper();
                string billboardUrl = BILLBOARD_PREFIX + SetAbbreviation + '-' + CollectorNumber;
                string billboard = scraper.Scrape(billboardUrl, McdiSiteParser.PREFIX);

                string rightToken = "a href=\\\'";
                string leftToken = "\\'>";
                int rightIndex = billboard.IndexOf(rightToken);
                int leftIndex = billboard.IndexOf(leftToken, rightIndex);
                storeUrl = billboard.Substring(rightIndex + rightToken.Length, leftIndex - rightIndex - rightToken.Length);
            }

            // Parse the tcgplayer page
            List<PriceEntry> results = new List<PriceEntry>();
            {
                UrlScraper scraper = new UrlScraper();
                string store = scraper.Scrape(storeUrl, McdiSiteParser.PREFIX);

                int startpos = store.IndexOf("<table class=\"price_list\" cellspacing=\"0\" border=\"0\" style=\"border-width:0px;border-collapse:collapse;\">");
                int endpos = store.IndexOf("</table>", startpos);

                string leftToken = "<td>";
                string rightToken = "</td>";

                // Process all the cards
                int curpos = startpos;
                while (store.IndexOf(leftToken, curpos) < endpos)
                {
                    // Add favorites
                    {
                        int leftIndex = store.IndexOf(leftToken, curpos);
                        int rightIndex = store.IndexOf(rightToken, leftIndex);
                        string addFavorites = store.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                        curpos = rightIndex;
                    }

                    // Store Name
                    string vendor;
                    {
                        int leftIndex = store.IndexOf(leftToken, curpos);
                        int rightIndex = store.IndexOf(rightToken, leftIndex);
                        vendor = store.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                        curpos = rightIndex;
                    }

                    // Empty
                    {
                        int leftIndex = store.IndexOf(leftToken, curpos);
                        int rightIndex = store.IndexOf(rightToken, leftIndex);
                        string empty = store.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                        curpos = rightIndex;
                    }

                    // Condition
                    string condition;
                    {
                        int leftIndex = store.IndexOf(leftToken, curpos);
                        int rightIndex = store.IndexOf(rightToken, leftIndex);
                        condition = store.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                        curpos = rightIndex;
                    }

                    // Quantity Available
                    string quantityAvailable;
                    {
                        int leftIndex = store.IndexOf(leftToken, curpos);
                        int rightIndex = store.IndexOf(rightToken, leftIndex);
                        quantityAvailable = store.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                        curpos = rightIndex;
                    }

                    // Price
                    string price;
                    {
                        int leftIndex = store.IndexOf(leftToken, curpos);
                        int rightIndex = store.IndexOf(rightToken, leftIndex);
                        price = store.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                        curpos = rightIndex;
                    }

                    // Quantity To Buy
                    {
                        int leftIndex = store.IndexOf(leftToken, curpos);
                        int rightIndex = store.IndexOf(rightToken, leftIndex);
                        string quantityToBuy = store.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                        curpos = rightIndex;
                    }

                    // Add To Cart
                    {
                        int leftIndex = store.IndexOf(leftToken, curpos);
                        int rightIndex = store.IndexOf(rightToken, leftIndex);
                        string addToCart = store.Substring(leftIndex + leftToken.Length, rightIndex - leftIndex - leftToken.Length);
                        curpos = rightIndex;
                    }

                    results.Add(new PriceEntry(vendor, PhysicalCondition.Parse(condition), int.Parse(quantityAvailable), decimal.Parse(price.Substring(1))));
                }
            }

            return results;
        }
    }
}
