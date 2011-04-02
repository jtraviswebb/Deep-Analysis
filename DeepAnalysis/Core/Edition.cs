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
    public struct Edition : IXmlSerializable
    {
        private string set;
        private int collectorNumber;
        private string artist;
        private string flavorText;
        private Rarity rarity;
        private string imageUrl;

        public string Set { get { return set; } }
        public int CollectorNumber { get { return collectorNumber; } }
        public string Artist { get { return artist; } }
        public string FlavorText { get { return flavorText; } }
        public Rarity Rarity { get { return rarity; } }
        public string ImageUrl { get { return imageUrl; } }

        public Edition(string Set, int CollectorNumber, string Artist, string FlavorText, Rarity Rarity, string ImageUrl)
        {
            set = Set;
            collectorNumber = CollectorNumber;
            artist = Artist;
            flavorText = FlavorText;
            rarity = Rarity;
            imageUrl = ImageUrl;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Set).Append("(").Append(Rarity).Append("),");
            sb.Append(CollectorNumber).Append(":").Append(Artist);

            return sb.ToString();
        }

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

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("Set", Set);
            writer.WriteElementString("CollectorNumber", CollectorNumber.ToString());
            writer.WriteElementString("Artist", Artist);
            writer.WriteElementString("FlavorText", FlavorText);
            writer.WriteStartElement(Rarity.GetType().Name);
            Rarity.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteElementString("ImageUrl", ImageUrl);
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement(GetType().Name);
            set = reader.ReadElementString("Set");
            collectorNumber = int.Parse(reader.ReadElementString("CollectorNumber"));
            artist = reader.ReadElementString("Artist");
            flavorText = reader.ReadElementString("FlavorText");
            rarity.ReadXml(reader);
            imageUrl = reader.ReadElementString("ImageUrl");
            reader.ReadEndElement();
        }

        public XmlSchema GetSchema()
        {
            return (null);
        }
    }
}
