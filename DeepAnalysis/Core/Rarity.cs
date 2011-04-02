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
    public struct Rarity : IComparable<Rarity>, IXmlSerializable
    {
        public enum RarityMainclass
        {
            Unknown,
            Land, //meaning basic land
            Common,
            Uncommon,
            Rare,
            Mythic,
            Special
        }

        public enum RaritySubclass
        {
            None,
            C1,
            C2,
            C3,
            C4,
            C5,
            C11,
            U1,
            U2,
            U3,
            U4,
            R1
        }

        private string fullDefinition;
        private RarityMainclass mainclass;
        private RaritySubclass subclass;

        public string FullDefinition { get { return fullDefinition; } }
        public RarityMainclass Mainclass { get { return mainclass; } }
        public RaritySubclass Subclass { get { return subclass; } }

        public Rarity(string FullDefinition)
        {
            fullDefinition = "Unknown";
            mainclass = RarityMainclass.Unknown;
            subclass = RaritySubclass.None;

            parseString(FullDefinition);
        }

        private void parseString(string FullDefinition)
        {
            fullDefinition = FullDefinition;

            string mainclassString = FullDefinition;
            string leftSubToken = "(";
            string rightSubToken = ")";
            int subindex = FullDefinition.IndexOf(leftSubToken);
            if (subindex != -1)
            {
                mainclassString = FullDefinition.Substring(0, subindex).Trim();
                string subclassString = FullDefinition.Substring(subindex + leftSubToken.Length, FullDefinition.Length - subindex - leftSubToken.Length - rightSubToken.Length);

                if (Enum.IsDefined(typeof(RaritySubclass), subclassString))
                {
                    subclass = (RaritySubclass)Enum.Parse(typeof(RaritySubclass), subclassString, true);
                }
                else
                {
                    throw new ArgumentException("Invalid rarity subclass string: " + subclassString);
                }
            }
            else
            {
                subclass = RaritySubclass.None;
            }

            // hack to convert 'Mythic Rare' to Mythic
            if (mainclassString.Contains("Mythic"))
            {
                mainclassString = "Mythic";
            }

            if (Enum.IsDefined(typeof(RarityMainclass), mainclassString))
            {
                mainclass = (RarityMainclass)Enum.Parse(typeof(RarityMainclass), mainclassString, true);
            }
            else
            {
                throw new ArgumentException("Invalid rarity class string: " + mainclassString);
            }
        }

        public override string ToString()
        {
            return Mainclass.ToString();
        }

        private bool Equals(Rarity other)
        {
            return Mainclass == other.Mainclass;
        }

        public override int GetHashCode()
        {
            return (int)Mainclass;
        }

        public override bool Equals(object other)
        {
            return other is Rarity && Equals((Rarity)other);
        }

        public static bool operator ==(Rarity lhs, Rarity rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Rarity lhs, Rarity rhs)
        {
            return !(lhs == rhs);
        }

        public int CompareTo(Rarity other)
        {
            return Mainclass - other.Mainclass; 
        }

        public static bool operator <(Rarity lhs, Rarity rhs)
        {
            return lhs.CompareTo(rhs) < 0;
        }

        public static bool operator <=(Rarity lhs, Rarity rhs)
        {
            return lhs.CompareTo(rhs) <= 0;
        }

        public static bool operator >(Rarity lhs, Rarity rhs)
        {
            return lhs.CompareTo(rhs) > 0;
        }

        public static bool operator >=(Rarity lhs, Rarity rhs)
        {
            return lhs.CompareTo(rhs) >= 0;
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(FullDefinition);
        }

        public void ReadXml(XmlReader reader)
        {
            parseString(reader.ReadString());
            reader.ReadEndElement();
        }

        public XmlSchema GetSchema()
        {
            return (null);
        }
    }
}
