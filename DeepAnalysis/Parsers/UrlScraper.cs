using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace DeepAnalysis.Parsers
{
    class UrlScraper
    {
        public string Scrape(string url)
        {
            string html = null;
            WebRequest request = System.Net.HttpWebRequest.Create(url);

            using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                html = sr.ReadToEnd();
                sr.Close();
            }

            return html;
        }
    }
}
