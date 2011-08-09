using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeepAnalysis.Core;
using System.Xml.Serialization;
using System.IO;
using DeepAnalysis.Net.Mcdi;

namespace WebExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: take out when not testing
            args = new string[] { @"C:\cards.xml" };

            // make sure there is a filename
            if (args.Length != 1)
            {
                Console.WriteLine("The first argument should be the filename for the xml output.");
                return;
            }

            string filename = args[0];

            // validate the filename
            {
                bool filenameOk = false;
                try
                {
                    new System.IO.FileInfo(filename);
                    filenameOk = true;
                }
                catch (ArgumentException argE)
                {
                    Console.WriteLine("The input filename invalid. Exception: " + argE.Message);
                }
                catch (System.IO.PathTooLongException)
                {
                    Console.WriteLine("The input filename was too long.");
                }
                catch (NotSupportedException notSupE)
                {
                    Console.WriteLine("The input filename invalid. Exception: " + notSupE.Message);
                }
                if (!filenameOk)
                {
                    return;
                }
            }

            // Pull from the web
            {
                Database db = new Database();
                McdiSiteParser parser = new McdiSiteParser(db);
                parser.Parse();

                Console.WriteLine("Saving...");

                // Serialization
                using (TextWriter textWriter = new StreamWriter(filename))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Database));
                    serializer.Serialize(textWriter, db);
                    textWriter.Close();
                }

                Console.WriteLine("Done!");
                Console.ReadLine();
            }
        }
    }
}
