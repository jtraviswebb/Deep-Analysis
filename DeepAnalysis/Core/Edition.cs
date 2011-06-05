using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace DeepAnalysis.Core
{
    [Serializable]
    public class Edition// : IXmlSerializable
    {
        //private string set;
        //private string setAbbreviation;
        //private int collectorNumber;
        //private string artist;
        //private string flavorText;
        //private Rarity rarity;
        //private string imageUrl;
        //private string sourceUrl;
        //private Card card;

        //public string Set { get { return set; } }
        //public string SetAbbreviation { get { return set; } }
        //public int CollectorNumber { get { return collectorNumber; } }
        //public string Artist { get { return artist; } }
        //public string FlavorText { get { return flavorText; } }
        //public Rarity Rarity { get { return rarity; } }
        //public string ImageUrl { get { return imageUrl; } }
        //public string SourceUrl { get { return sourceUrl; } }
        //public Card Card { get { return card; } }

        public string Set { get; set; }
        public string SetAbbreviation { get; set; }
        public int CollectorNumber { get; set; }
        public string Artist { get; set; }
        public string FlavorText { get; set; }
        public Rarity Rarity { get; set; }
        public string ImageUrl { get; set; }
        public string SourceUrl { get; set; }

        public Edition()
        {
        }

        public Edition(string Set, string SetAbbreviation, int CollectorNumber, string Artist, string FlavorText, Rarity Rarity, string ImageUrl, string SourceUrl)
        {
            //set = Set;
            //setAbbreviation = SetAbbreviation;
            //collectorNumber = CollectorNumber;
            //artist = Artist;
            //flavorText = FlavorText;
            //rarity = Rarity;
            //imageUrl = ImageUrl;
            //sourceUrl = SourceUrl;
            this.Set = Set;
            this.SetAbbreviation = SetAbbreviation;
            this.CollectorNumber = CollectorNumber;
            this.Artist = Artist;
            this.FlavorText = FlavorText;
            this.Rarity = Rarity;
            this.ImageUrl = ImageUrl;
            this.SourceUrl = SourceUrl;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Set).Append("(").Append(Rarity).Append("),");
            sb.Append(CollectorNumber).Append(":").Append(Artist);

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
            Edition e = obj as Edition;
            if ((object)e == null)
            {
                return false;
            }

            // Return true if the fields match
            return Equals(e);
        }

        public bool Equals(Edition e)
        {
            // If parameter is null return false
            if ((object)e == null)
            {
                return false;
            }

            // Return true if the fields match
            return Set == e.Set &&
                SetAbbreviation == e.SetAbbreviation &&
                CollectorNumber == e.CollectorNumber &&
                Artist == e.Artist &&
                FlavorText == e.FlavorText &&
                Rarity == e.Rarity; // should include urls?
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        /*
        private bool Equals(Edition other)
        {
            return Set == other.Set && CollectorNumber == other.CollectorNumber &&
                Artist == other.Artist && FlavorText == other.FlavorText && Rarity == other.Rarity;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object other)
        {
            return other is Edition && Equals((Edition)other);
        }

        public static bool operator ==(Edition lhs, Edition rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Edition lhs, Edition rhs)
        {
            return !(lhs == rhs);
        }
         */
        /*
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("Set", Set);
            writer.WriteElementString("SetAbbreviation", SetAbbreviation);
            writer.WriteElementString("CollectorNumber", CollectorNumber.ToString());
            writer.WriteElementString("Artist", Artist);
            writer.WriteElementString("FlavorText", FlavorText);
            writer.WriteStartElement(Rarity.GetType().Name);
            Rarity.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteElementString("ImageUrl", ImageUrl);
            writer.WriteElementString("SourceUrl", SourceUrl);
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement(GetType().Name);
            set = reader.ReadElementString("Set");
            setAbbreviation = reader.ReadElementString("SetAbbreviation");
            collectorNumber = int.Parse(reader.ReadElementString("CollectorNumber"));
            artist = reader.ReadElementString("Artist");
            flavorText = reader.ReadElementString("FlavorText");
            rarity.ReadXml(reader);
            imageUrl = reader.ReadElementString("ImageUrl");
            sourceUrl = reader.ReadElementString("SourceUrl");
            reader.ReadEndElement();
        }

        public XmlSchema GetSchema()
        {
            return (null);
        }
         */
    }
}
