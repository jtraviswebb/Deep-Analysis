using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Xml;
using DeepAnalysis.Core;

namespace DeepAnalysis.Cube
{
    public enum CubeStatus
    {
        Applicant,
        Reapplicant,
        Guest,
        Resident,
        Tenured,
        Emeritus
    }

    [Serializable]
    public struct CubeEntry : IXmlSerializable
    {
        private string cardName;
        private string setName;
        private int collectorNumber;
        private CubeStatus status;

        public string CardName { get { return cardName; } }
        public string SetName { get { return setName; } }
        public int CollectorNumber { get { return collectorNumber; } }
        public CubeStatus Status { get { return status; } }

        public CubeEntry(string CardName, string SetName, int CollectorNumber, CubeStatus Status)
        {
            cardName = CardName;
            setName = SetName;
            collectorNumber = CollectorNumber;
            status = Status;
        }

        public CubeEntry(Card Card, Edition Edition, CubeStatus Status)
        {
            cardName = Card.Name;
            setName = Edition.Set;
            collectorNumber = Edition.CollectorNumber;
            status = Status;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(CardName).Append(",").Append(SetName).Append("(");
            sb.Append(CollectorNumber).Append(")").Append(":").Append(Status);

            return sb.ToString();
        }

        private bool Equals(CubeEntry other)
        {
            return CardName == other.CardName && SetName == other.SetName &&
                CollectorNumber == other.CollectorNumber && Status == other.Status;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object other)
        {
            return other is CubeEntry && Equals((CubeEntry)other);
        }

        public static bool operator ==(CubeEntry lhs, CubeEntry rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(CubeEntry lhs, CubeEntry rhs)
        {
            return !(lhs == rhs);
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteElementString("CardName", CardName);
            writer.WriteElementString("SetName", SetName);
            writer.WriteElementString("CollectorNumber", CollectorNumber.ToString());
            writer.WriteElementString("Status", Status.ToString());
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement(GetType().Name);
            cardName = reader.ReadElementString("CardName");
            setName = reader.ReadElementString("SetName");
            collectorNumber = int.Parse(reader.ReadElementString("CollectorNumber"));
            string statusString = reader.ReadElementString("Status");
            if (Enum.IsDefined(typeof(CubeStatus), statusString))
            {
                status = (CubeStatus)Enum.Parse(typeof(CubeStatus), statusString, true);
            }
            else
            {
                throw new ArgumentException("Invalid cube status string: " + statusString);
            }
            reader.ReadEndElement();
        }

        public XmlSchema GetSchema()
        {
            return (null);
        }
    }
}
