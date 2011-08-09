using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Google.GData.Spreadsheets;
//using Google.GData.Client;

namespace DeepAnalysis.Cube
{
    /*
    //Begin Bad Code:
    class GdocCube
    {
        public static string SHEET_URL = @"https://spreadsheets.google.com/spreadsheet/ccc?key=0An8uBC-kY1sydGhuZG5SbXRhYzBlMWJiNzB4bUNVcEE&hl=en_US&authkey=CKGU4_UJ";

        SpreadsheetsService service;
        SpreadsheetEntry spreadsheet;
        WorksheetEntry worksheet;

        public List<CubeEntry> Entries { get; set; }

        public GdocCube(string UserName, string Password)
        {
            Login(UserName, Password);
            Entries = Load();
        }

        private void ClearWorksheet()
        {
            AtomLink listFeedLink = worksheet.Links.FindService(GDataSpreadsheetsNameTable.ListRel, null);

            ListQuery query = new ListQuery(listFeedLink.HRef.ToString());
            ListFeed feed = service.Query(query);

            foreach (ListEntry row in feed.Entries)
            {
                // it appears that this doesn't clear the first row if it is protected by the bar
                row.Delete();
            }
        }

        public void Save()
        {
            ClearWorksheet();

            foreach (CubeEntry entry in Entries)
            {
                AddEntry(entry);
            }
        }

        private void AddEntry(CubeEntry entry)
        {
            AtomLink listFeedLink = worksheet.Links.FindService(GDataSpreadsheetsNameTable.ListRel, null);

            ListQuery query = new ListQuery(listFeedLink.HRef.ToString());
            ListFeed feed = service.Query(query);

            ListEntry newRow = new ListEntry();

            ListEntry.Custom nameElement = new ListEntry.Custom();
            nameElement.LocalName = "Name".ToLower();
            nameElement.Value = entry.CardName;
            newRow.Elements.Add(nameElement);

            ListEntry.Custom setElement = new ListEntry.Custom();
            setElement.LocalName = "Set".ToLower();
            setElement.Value = entry.SetName;
            newRow.Elements.Add(setElement);

            ListEntry.Custom collectorElement = new ListEntry.Custom();
            collectorElement.LocalName = "CollectorNumber".ToLower();
            collectorElement.Value = entry.CollectorNumber.ToString();
            newRow.Elements.Add(collectorElement);

            ListEntry.Custom statusElement = new ListEntry.Custom();
            statusElement.LocalName = "Status".ToLower();
            statusElement.Value = entry.Status.ToString();
            newRow.Elements.Add(statusElement);

            ListEntry insertedRow = feed.Insert(newRow);
            Console.WriteLine("Successfully inserted new row: \"{0}\"",
                insertedRow.Content.Content);
        }

        private List<CubeEntry> Load()
        {
            // get the spreadsheet
            {
                SpreadsheetQuery query = new SpreadsheetQuery();
                //TODO: only works for me....
                query.Uri = new Uri(@"https://spreadsheets.google.com/feeds/spreadsheets/private/full/thndnRmtac0e1bb70xmCUpA");
                SpreadsheetFeed feed = service.Query(query);

                spreadsheet = (SpreadsheetEntry)feed.Entries[0];
            }

            // get the worksheet
            {
                AtomLink link = spreadsheet.Links.FindService(GDataSpreadsheetsNameTable.WorksheetRel, null);

                WorksheetQuery query = new WorksheetQuery(link.HRef.ToString());
                WorksheetFeed feed = service.Query(query);

                worksheet = (WorksheetEntry)feed.Entries[0];
            }

            //get all cells
            //TODO: convert to using listentry format
            List<Tuple<string, string, int, string>> rows = new List<Tuple<string, string, int, string>>();
            {
                List<string> cardNames = new List<string>();
                List<string> setNames = new List<string>();
                List<int> collectorNumbers = new List<int>();
                List<string> statusNames = new List<string>();

                AtomLink cellFeedLink = worksheet.Links.FindService(GDataSpreadsheetsNameTable.CellRel, null);

                CellQuery query = new CellQuery(cellFeedLink.HRef.ToString());
                query.MinimumColumn = 1;
                query.MaximumColumn = 4;
                query.MinimumRow = 2;

                CellFeed feed = service.Query(query);
                short oscilator = 0;
                foreach (CellEntry curCell in feed.Entries)
                {
                    Console.WriteLine("({0},{1}): {2}", curCell.Cell.Row, curCell.Cell.Column, curCell.Cell.Value);
                    if (oscilator % 4 + 1 != curCell.Cell.Column)
                    {
                        //throw exception
                        Console.WriteLine("oscilator problem");
                    }
                    if (curCell.Cell.Column == 1)
                    {
                        cardNames.Add(curCell.Cell.Value);
                        oscilator++;
                    }
                    else if (curCell.Cell.Column == 2)
                    {
                        setNames.Add(curCell.Cell.Value);
                        oscilator++;
                    }
                    else if (curCell.Cell.Column == 3)
                    {
                        collectorNumbers.Add(int.Parse(curCell.Cell.Value));
                        oscilator++;
                    }
                    else if (curCell.Cell.Column == 4)
                    {
                        statusNames.Add(curCell.Cell.Value);
                        oscilator++;
                    }
                }

                for (int i = 0; i < cardNames.Count; i++)
                {
                    rows.Add(new Tuple<string, string, int, string>(cardNames[i], setNames[i], collectorNumbers[i], statusNames[i]));
                }
            }

            List<CubeEntry> results = new List<CubeEntry>();
            foreach (Tuple<string, string, int, string> row in rows)
            {
                CubeEntry entry = new CubeEntry(row.Item1, row.Item2, row.Item3, (CubeStatus)Enum.Parse(typeof(CubeStatus), row.Item4));
                results.Add(entry);
            }

            return results;
        }

        private void Login(string UserName, string Password)
        {
            service = new SpreadsheetsService("google-docs-cube");
            service.setUserCredentials(UserName, Password);
        }
    }
     */
}
