using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeepAnalysis.Parsers;
using DeepAnalysis.Core;
using System.Xml.Serialization;
using System.IO;

namespace DeepAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            //McdiSetParser setParser = new McdiSetParser("Test", new List<Card>(), new Dictionary<string, int>());
            //setParser.ParseUrl("5dn/en.html");
            //McdiCardParser cardParser = new McdiCardParser("Test");
            //cardParser.ParseUrl("chk/en/309.html");

            // Pull from the web
            McdiParser parser = new McdiParser();
            List<Card> db = parser.Parse();

            // Serialization
            XmlSerializer serializer = new XmlSerializer(db.GetType());
            TextWriter textWriter = new StreamWriter(@"C:\cards.xml");
            serializer.Serialize(textWriter, db);
            textWriter.Close();

            // Deserialization
            //TextReader reader = new StreamReader(@"C:\cards.xml");
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Card>));
            //List<Card> db = (List<Card>)serializer.Deserialize(reader);
            //reader.Close();
        }
    }
}
