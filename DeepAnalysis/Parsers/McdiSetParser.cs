using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeepAnalysis.Core;

namespace DeepAnalysis.Parsers
{
    class McdiSetParser
    {
        private string setName;
        private List<Card> db;
        private Dictionary<string, int> insertionTable;

        public McdiSetParser(string SetName, List<Card> Db, Dictionary<string, int> InsertionTable)
        {
            setName = SetName;
            db = Db;
            insertionTable = InsertionTable;
        }

        public void ParseUrl(string url)
        {
            UrlScraper scraper = new UrlScraper();
            string html = scraper.Scrape(McdiParser.PREFIX + url);

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
                string cardName = html.Substring(splitIndex + splitToken.Length, rightIndex - splitIndex + splitToken.Length - rightToken.Length);

                // Process the card
                //System.Console.WriteLine(cardName + ":" + cardUrl);
                McdiCardParser cardParser = new McdiCardParser(setName);
                Card c = cardParser.ParseUrl(cardUrl);

                if (insertionTable.ContainsKey(c.Name))
                {
                    db[insertionTable[c.Name]].Editions.Add(c.Editions[0]);
                }
                else
                {
                    insertionTable[c.Name] = db.Count;
                    db.Add(c);
                }

                curpos = rightIndex;
            }
        }
    }
}
