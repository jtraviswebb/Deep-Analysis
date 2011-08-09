using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace DeepAnalysis.Net
{
    class UrlScraper
    {
        public string Scrape(string Url)
        {
            return Scrape(Url, null);
        }

        public string Scrape(string Url, string Referer)
        {
            string html = null;
            HttpWebRequest request = (HttpWebRequest)System.Net.HttpWebRequest.Create(Url);

            if (Referer != null && Referer != string.Empty)
            {
                request.Referer = Referer;
            }

            using (StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream()))
            {
                html = sr.ReadToEnd();
                sr.Close();
            }

            return html;
        }
    }
}
