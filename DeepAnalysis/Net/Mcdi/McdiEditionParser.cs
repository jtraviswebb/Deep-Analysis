using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeepAnalysis.Core;

namespace DeepAnalysis.Net.Mcdi
{
    class McdiEditionParser
    {
        private Database database;

        public McdiEditionParser(Database Database)
        {
            database = Database;
        }

        public void ParseUrl(string url)
        {
            McdiCardParser cardParser = new McdiCardParser(database);

            UrlScraper scraper = new UrlScraper();
            string html = scraper.Scrape(McdiSiteParser.PREFIX + url);

            int startpos = html.IndexOf("class=\"even\"");
            string leftToken = "<td><a href=\"";
            string splitToken = "\">";
            string rightToken = "</a>";

            // Process all the cards
            int curpos = startpos;
            while (html.IndexOf(leftToken, curpos) != -1)
            {
                int leftIndex = html.IndexOf(leftToken, curpos);
                int splitIndex = html.IndexOf(splitToken, leftIndex);
                int rightIndex = html.IndexOf(rightToken, splitIndex);

                string cardUrl = html.Substring(leftIndex + leftToken.Length, splitIndex - leftIndex - leftToken.Length);
                string cardName = html.Substring(splitIndex + splitToken.Length, rightIndex - splitIndex - splitToken.Length);

                // Process the card
                //System.Console.WriteLine(cardName + ":" + cardUrl);
                cardParser.ParseUrl(cardUrl);

                curpos = rightIndex;
            }
        }
    }
}
