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
    [Serializable]
    public class CubeEntry
    {
        public enum EntryStatus
        {
            Applicant,
            Reapplicant,
            Guest,
            Resident,
            Tenured,
            Emeritus
        }

        private string cardName;
        private string setName;
        private int collectorNumber;

        public string CardName { get { return cardName; } }
        public string SetName { get { return setName; } }
        public int CollectorNumber { get { return collectorNumber; } }
        public EntryStatus Status { get; set; }

        public CubeEntry(string CardName, string SetName, int CollectorNumber, EntryStatus Status)
        {
            cardName = CardName;
            setName = SetName;
            collectorNumber = CollectorNumber;
            Status = Status;
        }

        public CubeEntry(Card Card, Printing Printing, EntryStatus Status)
        {
            cardName = Card.Name;
            setName = Printing.Edition.Name;
            collectorNumber = Printing.CollectorNumber;
            Status = Status;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(CardName).Append(",").Append(SetName).Append("(");
            sb.Append(CollectorNumber).Append(")").Append(":").Append(Status);

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
            Card c = obj as Card;
            if ((object)c == null)
            {
                return false;
            }

            // Return true if the fields match
            return Equals(c);
        }

        public bool Equals(CubeEntry other)
        {
            // If parameter is null return false
            if ((object)other == null)
            {
                return false;
            }

            // Return true if the fields match
            return CardName == other.CardName && SetName == other.SetName &&
                CollectorNumber == other.CollectorNumber && Status == other.Status;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        #region Holdover from when this was a struct
        /*
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
            if (Enum.IsDefined(typeof(EntryStatus), statusString))
            {
                status = (EntryStatus)Enum.Parse(typeof(EntryStatus), statusString, true);
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
         */
        #endregion
    }
}
