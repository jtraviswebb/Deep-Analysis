using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepAnalysis.Core
{
    [Serializable]
    public class Printing
    {
        public Edition Edition { get; set; }
        public int CollectorNumber { get; set; }
        public string Artist { get; set; }
        public string FlavorText { get; set; }
        public Rarity Rarity { get; set; }
        public string ImageUrl { get; set; }
        public string SourceUrl { get; set; }

        public Printing()
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Edition).Append('@').Append(Rarity).Append(',').Append(CollectorNumber).Append(":").Append(Artist);

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            // If parameter is null return false
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Card return false
            Printing p = obj as Printing;
            if ((object)p == null)
            {
                return false;
            }

            // Return true if the fields match
            return Equals(p);
        }

        public bool Equals(Printing p)
        {
            // If parameter is null return false
            if ((object)p == null)
            {
                return false;
            }

            // Return true if the fields match
            // This doesn't include url's because currently those are based on the parsed source
            return Edition == p.Edition &&
                CollectorNumber == p.CollectorNumber &&
                Artist == p.Artist &&
                FlavorText == p.FlavorText &&
                Rarity == p.Rarity;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
