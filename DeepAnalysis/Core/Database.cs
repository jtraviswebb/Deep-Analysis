using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepAnalysis.Core
{
    [Serializable]
    public class Database
    {
        public List<Card> Cards { get; set; }
        public List<Edition> Editions { get; set; }

        public Database()
        {
            Cards = new List<Card>();
            Editions = new List<Edition>();
        }
    }
}
