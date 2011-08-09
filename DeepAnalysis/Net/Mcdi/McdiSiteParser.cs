using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeepAnalysis.Core;

namespace DeepAnalysis.Net.Mcdi
{
    public class McdiSiteParser
    {
        public static string PREFIX = "http://magiccards.info/";
        
        private Database database;

        public McdiSiteParser(Database Database)
        {
            database = Database;
        }

        public void Parse()
        {
            {
                string url = "sitemap.html";
                UrlScraper scraper = new UrlScraper();
                string html = scraper.Scrape(McdiSiteParser.PREFIX + url);

                int startpos = html.IndexOf("<h2>");
                //int endpos = startpos + 400;
                int endpos = html.IndexOf("<h2>", startpos + 1);
                string leftToken = "<li><a href=\"";
                string split1Token = "\">";
                string split2Token = "</a> <small style=\"color: #aaa;\">";
                string rightToken = "</small></li>";

                // While what we are about to process is english...
                int curpos = startpos;
                while (html.IndexOf(leftToken, curpos) < endpos)
                {
                    int leftIndex = html.IndexOf(leftToken, curpos);
                    int split1Index = html.IndexOf(split1Token, leftIndex);
                    int split2Index = html.IndexOf(split2Token, split1Index);
                    int rightIndex = html.IndexOf(rightToken, split2Index);

                    Edition edition = new Edition();
                    edition.SourceUrl = html.Substring(leftIndex + leftToken.Length, split1Index - leftIndex - leftToken.Length);
                    edition.Name = html.Substring(split1Index + split1Token.Length, split2Index - split1Index - split1Token.Length);
                    edition.Abbreviation = html.Substring(split2Index + split2Token.Length, rightIndex - split2Index - split2Token.Length);

                    // Collect
                    database.Editions.Add(edition);

                    curpos = rightIndex;
                }
            }

            // Process the sets
            foreach (Edition ed in database.Editions)
            {
                System.Console.WriteLine("====" + ed + ":" + ed.SourceUrl + "====");
                McdiEditionParser editionParser = new McdiEditionParser(database);
                editionParser.ParseUrl(ed.SourceUrl);
                //break;
            }
        }
    }
}
