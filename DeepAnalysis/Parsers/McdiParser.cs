using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeepAnalysis.Core;

namespace DeepAnalysis.Parsers
{
    class McdiParser
    {
        public static string PREFIX = "http://magiccards.info/";

        private Dictionary<string, int> insertionTable;

        public McdiParser()
        {
            insertionTable = new Dictionary<string, int>();
        }

        public List<Card> Parse()
        {
            List<Card> db = new List<Card>();
            List<Tuple<string, string>> sets = new List<Tuple<string, string>>();
            {
                string url = "sitemap.html";
                UrlScraper scraper = new UrlScraper();
                string html = scraper.Scrape(McdiParser.PREFIX + url);

                int startpos = html.IndexOf("<h2>");
                //int endpos = startpos + 400;
                int endpos = html.IndexOf("<h2>", startpos + 1);
                string leftToken = "<li><a href=\"";
                string splitToken = "\">";
                string rightToken = "</a>";

                // While what we are about to process is english...
                int curpos = startpos;
                while (html.IndexOf(leftToken, curpos) < endpos)
                {
                    int leftIndex = html.IndexOf(leftToken, curpos);
                    int splitIndex = html.IndexOf(splitToken, leftIndex);
                    int rightIndex = html.IndexOf(rightToken, splitIndex);

                    string setUrl = html.Substring(leftIndex + leftToken.Length, splitIndex - leftIndex - leftToken.Length);
                    string setName = html.Substring(splitIndex + splitToken.Length, rightIndex - splitIndex + splitToken.Length - rightToken.Length);

                    // Collect
                    sets.Add(new Tuple<string, string>(setUrl, setName));

                    curpos = rightIndex;
                }
            }

            // Process the sets
            foreach (Tuple<string, string> set in sets)
            {
                System.Console.WriteLine("====" + set.Item2 + ":" + set.Item1 + "====");
                McdiSetParser setParser = new McdiSetParser(set.Item2, db, insertionTable);
                setParser.ParseUrl(set.Item1);
            }

            return db;
        }
    }
}
