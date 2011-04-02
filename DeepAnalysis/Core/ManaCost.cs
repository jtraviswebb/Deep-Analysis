using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;

namespace DeepAnalysis.Core
{
    [Serializable]
    public struct ManaCost : IComparable<ManaCost>, IXmlSerializable
    {
        private bool applicable;
        private int xs;
        private int ys;
        private int zs;
        private int colorless;
        private int white;
        private int blue;
        private int black;
        private int red;
        private int green;
        private int whiteBlueHybrid;
        private int whiteBlackHybrid;
        private int whiteRedHybrid;
        private int whiteGreenHybrid;
        private int blueBlackHybrid;
        private int blueRedHybrid;
        private int blueGreenHybrid;
        private int blackRedHybrid;
        private int blackGreenHybrid;
        private int redGreenHybrid;
        private int whiteTwoHybrid;
        private int blueTwoHybrid;
        private int blackTwoHybrid;
        private int redTwoHybrid;
        private int greenTwoHybrid;

        public bool Applicable { get { return applicable; } }
        public int Xs { get { return xs; } }
        public int Ys { get { return ys; } }
        public int Zs { get { return zs; } }
        public int Colorless { get { return colorless; } }
        public int White { get { return white; } }
        public int Blue { get { return blue; } }
        public int Black { get { return black; } }
        public int Red { get { return red; } }
        public int Green { get { return green; } }
        public int WhiteBlueHybrid { get { return whiteBlueHybrid; } }
        public int WhiteBlackHybrid { get { return whiteBlackHybrid; } }
        public int WhiteRedHybrid { get { return whiteRedHybrid; } }
        public int WhiteGreenHybrid { get { return whiteGreenHybrid; } }
        public int BlueBlackHybrid { get { return blueBlackHybrid; } }
        public int BlueRedHybrid { get { return blueRedHybrid; } }
        public int BlueGreenHybrid { get { return blueGreenHybrid; } }
        public int BlackRedHybrid { get { return blackRedHybrid; } }
        public int BlackGreenHybrid { get { return blackGreenHybrid; } }
        public int RedGreenHybrid { get { return redGreenHybrid; } }
        public int WhiteTwoHybrid { get { return whiteTwoHybrid; } }
        public int BlueTwoHybrid { get { return blueTwoHybrid; } }
        public int BlackTwoHybrid { get { return blackTwoHybrid; } }
        public int RedTwoHybrid { get { return redTwoHybrid; } }
        public int GreenTwoHybrid { get { return greenTwoHybrid; } }

        public ManaCost(string cost)
            : this(cost != null && cost.Trim() != string.Empty)
        {
            parseString(cost);
        }

        private void parseString(string cost)
        {
            if (cost == null || cost.Trim() == string.Empty)
            {
                return;
            }
            applicable = true;

            for (int i = 0; i < cost.Length; i++)
            {
                char c = char.ToUpper(cost[i]);
                if (c == 'X')
                {
                    xs++;
                }
                else if (c == 'Y')
                {
                    ys++;
                }
                else if (c == 'Z')
                {
                    zs++;
                }
                else if (char.IsDigit(cost[i]))
                {
                    int s = i;
                    for (; i < cost.Length && char.IsDigit(cost[i]); i++) ;
                    colorless += int.Parse(cost.Substring(s, i - s));
                    i--;
                }
                else if (c == 'W')
                {
                    white++;
                }
                else if (c == 'U')
                {
                    blue++;
                }
                else if (c == 'B')
                {
                    black++;
                }
                else if (c == 'R')
                {
                    red++;
                }
                else if (c == 'G')
                {
                    green++;
                }
                else if (cost[i] == '{')
                {
                    char c1 = char.ToUpper(cost[i + 1]);
                    char c2 = char.ToUpper(cost[i + 3]);

                    if (cost[i + 4] != '}' || c1 == c2)
                    {
                        throw new ArgumentException("Invalid hybrid symbol in cost: " + cost);
                    }

                    i += 4;

                    // find out which sort of hybrid it is
                    bool hasColorless = false;
                    bool hasWhite = false;
                    bool hasBlack = false;
                    bool hasBlue = false;
                    bool hasRed = false;
                    bool hasGreen = false;

                    if (c1 == '2' || c2 == '2')
                    {
                        hasColorless = true;
                    }
                    if (c1 == 'W' || c2 == 'W')
                    {
                        hasWhite = true;
                    }
                    if (c1 == 'U' || c2 == 'U')
                    {
                        hasBlue = true;
                    }
                    if (c1 == 'B' || c2 == 'B')
                    {
                        hasBlack = true;
                    }
                    if (c1 == 'R' || c2 == 'R')
                    {
                        hasRed = true;
                    }
                    if (c1 == 'G' || c2 == 'G')
                    {
                        hasGreen = true;
                    }

                    // update the cost counts
                    if (hasColorless && hasWhite)
                    {
                        whiteTwoHybrid++;
                    }
                    if (hasColorless && hasBlue)
                    {
                        blueTwoHybrid++;
                    }
                    if (hasColorless && hasBlack)
                    {
                        whiteTwoHybrid++;
                    }
                    if (hasColorless && hasRed)
                    {
                        redTwoHybrid++;
                    }
                    if (hasColorless && hasGreen)
                    {
                        greenTwoHybrid++;
                    }
                    if (hasWhite && hasBlue)
                    {
                        whiteBlueHybrid++;
                    }
                    if (hasWhite && hasBlack)
                    {
                        whiteBlackHybrid++;
                    }
                    if (hasWhite && hasRed)
                    {
                        whiteRedHybrid++;
                    }
                    if (hasWhite && hasGreen)
                    {
                        whiteGreenHybrid++;
                    }
                    if (hasBlue && hasBlack)
                    {
                        blueBlackHybrid++;
                    }
                    if (hasBlue && hasRed)
                    {
                        blueRedHybrid++;
                    }
                    if (hasBlue && hasGreen)
                    {
                        blueGreenHybrid++;
                    }
                    if (hasBlack && hasRed)
                    {
                        blackRedHybrid++;
                    }
                    if (hasBlack && hasGreen)
                    {
                        blackGreenHybrid++;
                    }
                    if (hasRed && hasGreen)
                    {
                        redGreenHybrid++;
                    }
                }
            }
        }

        public ManaCost(bool Applicable)
        {
            applicable = Applicable;
            xs = 0;
            ys = 0;
            zs = 0;
            colorless = 0;
            white = 0;
            blue = 0;
            black = 0;
            red = 0;
            green = 0;
            whiteBlueHybrid = 0;
            whiteBlackHybrid = 0;
            whiteRedHybrid = 0;
            whiteGreenHybrid = 0;
            blueBlackHybrid = 0;
            blueRedHybrid = 0;
            blueGreenHybrid = 0;
            blackRedHybrid = 0;
            blackGreenHybrid = 0;
            redGreenHybrid = 0;
            whiteTwoHybrid = 0;
            blueTwoHybrid = 0;
            blackTwoHybrid = 0;
            redTwoHybrid = 0;
            greenTwoHybrid = 0;
        }

        public ManaCost(int Xs, int Ys, int Zs, int Colorless, int White, int Blue, int Black, int Red, int Green,
            int WhiteBlueHybrid, int WhiteBlackHybrid, int WhiteRedHybrid, int WhiteGreenHybrid,
            int BlueBlackHybrid, int BlueRedHybrid, int BlueGreenHybrid,
            int BlackRedHybrid, int BlackGreenHybrid, int RedGreenHybrid,
            int WhiteTwoHybrid, int BlueTwoHybrid, int BlackTwoHybrid, int RedTwoHybrid, int GreenTwoHybrid)
        {
            applicable = true;
            xs = Xs;
            ys = Ys;
            zs = Zs;
            colorless = Colorless;
            white = White;
            blue = Blue;
            black = Black;
            red = Red;
            green = Green;
            whiteBlueHybrid = WhiteBlueHybrid;
            whiteBlackHybrid = WhiteBlackHybrid;
            whiteRedHybrid = WhiteRedHybrid;
            whiteGreenHybrid = WhiteGreenHybrid;
            blueBlackHybrid = BlueBlackHybrid;
            blueRedHybrid = BlueRedHybrid;
            blueGreenHybrid = BlueGreenHybrid;
            blackRedHybrid = BlackRedHybrid;
            blackGreenHybrid = BlackGreenHybrid;
            redGreenHybrid = RedGreenHybrid;
            whiteTwoHybrid = WhiteTwoHybrid;
            blueTwoHybrid = BlueTwoHybrid;
            blackTwoHybrid = BlackTwoHybrid;
            redTwoHybrid = RedTwoHybrid;
            greenTwoHybrid = GreenTwoHybrid;
        }

        public int ConvertedManaCost
        {
            get
            { 
                return Colorless + White + Blue + Black + Red + Green + 
                    WhiteBlueHybrid + WhiteBlackHybrid + WhiteRedHybrid + WhiteGreenHybrid + 
                    BlueBlackHybrid + BlueRedHybrid + BlueGreenHybrid + 
                    BlackRedHybrid + BlackGreenHybrid + 
                    RedGreenHybrid + 
                    WhiteTwoHybrid + BlueTwoHybrid + BlackTwoHybrid + RedTwoHybrid + GreenTwoHybrid;
            }
        }

        public bool IsHybrid
        {
            get
            {
                return WhiteBlueHybrid + WhiteBlackHybrid + WhiteRedHybrid + WhiteGreenHybrid +
                    BlueBlackHybrid + BlueRedHybrid + BlueGreenHybrid +
                    BlackRedHybrid + BlackGreenHybrid +
                    RedGreenHybrid +
                    WhiteTwoHybrid + BlueTwoHybrid + BlackTwoHybrid + RedTwoHybrid + GreenTwoHybrid > 0;
            }
        }

        public int ColorCount
        {
            get
            {
                return Convert.ToInt32(IsWhite) + Convert.ToInt32(IsBlue) +
                    Convert.ToInt32(IsBlack) + Convert.ToInt32(IsRed) +
                    Convert.ToInt32(IsGreen);
            }
        }

        public bool IsGold { get { return ColorCount > 1; } }

        public bool IsColorless { get { return ColorCount == 0; } }

        public bool IsWhite
        {
            get
            {
                return White + WhiteBlueHybrid + WhiteBlackHybrid + WhiteRedHybrid + WhiteGreenHybrid + WhiteTwoHybrid > 0;
            }
        }

        public bool IsBlue
        {
            get
            {
                return Blue + WhiteBlueHybrid + BlueBlackHybrid + BlueRedHybrid + BlueGreenHybrid + BlueTwoHybrid > 0;
            }
        }

        public bool IsBlack
        {
            get
            {
                return Black + BlueBlackHybrid + WhiteBlackHybrid + BlackRedHybrid + BlackGreenHybrid + BlackTwoHybrid > 0;
            }
        }

        public bool IsRed
        {
            get
            {
                return Red + BlueRedHybrid + BlackRedHybrid + WhiteRedHybrid + RedGreenHybrid + RedTwoHybrid > 0;
            }
        }

        public bool IsGreen
        {
            get
            {
                return Green + BlueGreenHybrid + BlackGreenHybrid + RedGreenHybrid + WhiteGreenHybrid + GreenTwoHybrid > 0;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (!Applicable)
            {
                sb.Append("N/A");
                return sb.ToString();
            }

            // Xs
            for (int i = 0; i < Xs; i++)
            {
                sb.Append('X');
            }

            // Ys
            for (int i = 0; i < Ys; i++)
            {
                sb.Append('Y');
            }

            // Zs
            for (int i = 0; i < Zs; i++)
            {
                sb.Append('Z');
            }

            // Colorless
            if (Colorless > 0 || (IsColorless && Xs == 0))
            {
                sb.Append(Colorless);
            }

            // White
            for (int i = 0; i < White; i++)
            {
                sb.Append('W');
            }

            // Blue
            for (int i = 0; i < Blue; i++)
            {
                sb.Append('U');
            }

            // Black
            for (int i = 0; i < Black; i++)
            {
                sb.Append('B');
            }

            // Red
            for (int i = 0; i < Red; i++)
            {
                sb.Append('R');
            }

            // Green
            for (int i = 0; i < Green; i++)
            {
                sb.Append('G');
            }

            // WhiteBlue
            for (int i = 0; i < WhiteBlueHybrid; i++)
            {
                sb.Append("{W/U}");
            }

            // WhiteBlack
            for (int i = 0; i < WhiteBlackHybrid; i++)
            {
                sb.Append("{W/B}");
            }

            // WhiteRed
            for (int i = 0; i < WhiteRedHybrid; i++)
            {
                sb.Append("{W/R}");
            }

            // WhiteGreen
            for (int i = 0; i < WhiteGreenHybrid; i++)
            {
                sb.Append("{W/G}");
            }

            // BlueBlack
            for (int i = 0; i < BlueBlackHybrid; i++)
            {
                sb.Append("{U/B}");
            }

            // BlueRed
            for (int i = 0; i < BlueRedHybrid; i++)
            {
                sb.Append("{U/R}");
            }

            // BlueGreen
            for (int i = 0; i < BlueGreenHybrid; i++)
            {
                sb.Append("{U/G}");
            }

            // BlackRed
            for (int i = 0; i < BlackRedHybrid; i++)
            {
                sb.Append("{B/R}");
            }

            // BlackGreen
            for (int i = 0; i < BlackGreenHybrid; i++)
            {
                sb.Append("{B/G}");
            }

            // RedGreen
            for (int i = 0; i < RedGreenHybrid; i++)
            {
                sb.Append("{R/G}");
            }

            // WhiteTwo
            for (int i = 0; i < WhiteTwoHybrid; i++)
            {
                sb.Append("{W/2}");
            }

            // BlueTwo
            for (int i = 0; i < BlueTwoHybrid; i++)
            {
                sb.Append("{U/2}");
            }

            // BlackTwo
            for (int i = 0; i < BlackTwoHybrid; i++)
            {
                sb.Append("{B/2}");
            }

            // RedTwo
            for (int i = 0; i < RedTwoHybrid; i++)
            {
                sb.Append("{R/2}");
            }

            // GreenTwo
            for (int i = 0; i < GreenTwoHybrid; i++)
            {
                sb.Append("{G/2}");
            }

            return sb.ToString();
        }

        private bool Equals(ManaCost other)
        {
            return Applicable == other.Applicable &&
                Colorless == other.Colorless && White == other.White &&
                Blue == other.Blue && Black == other.Black &&
                Red == other.Red && Green == other.Green &&
                WhiteBlueHybrid == other.WhiteBlueHybrid && WhiteBlackHybrid == other.WhiteBlackHybrid &&
                WhiteRedHybrid == other.WhiteRedHybrid && WhiteGreenHybrid == other.WhiteGreenHybrid &&
                BlueBlackHybrid == other.BlueBlackHybrid && BlueRedHybrid == other.BlueRedHybrid &&
                BlueGreenHybrid == other.BlueGreenHybrid && BlackRedHybrid == other.BlackRedHybrid &&
                BlackGreenHybrid == other.BlackGreenHybrid && RedGreenHybrid == other.RedGreenHybrid &&
                WhiteTwoHybrid == other.WhiteTwoHybrid && BlueTwoHybrid == other.BlueTwoHybrid &&
                BlackTwoHybrid == other.BlackTwoHybrid && RedTwoHybrid == other.RedTwoHybrid &&
                GreenTwoHybrid == other.GreenTwoHybrid;
        }

        public override bool Equals(object other)
        {
            return other is ManaCost && Equals((ManaCost)other);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public int CompareTo(ManaCost other)
        {
            return ConvertedManaCost - other.ConvertedManaCost;
        }

        public static bool operator ==(ManaCost lhs, ManaCost rhs)
        {
            // If both are null, or both are same instance, return true
            if (System.Object.ReferenceEquals(lhs, rhs))
            {
                return true;
            }

            // If one is null, but not both, return false
            if (((object)lhs == null) || ((object)rhs == null))
            {
                return false;
            }

            // Return true if the fields match
            return lhs.Equals(rhs);
        }

        public static bool operator !=(ManaCost lhs, ManaCost rhs)
        {
            return !(lhs == rhs);
        }

        public static bool operator <(ManaCost lhs, ManaCost rhs)
        {
            return lhs.CompareTo(rhs) < 0;
        }

        public static bool operator <=(ManaCost lhs, ManaCost rhs)
        {
            return lhs.CompareTo(rhs) <= 0;
        }

        public static bool operator >(ManaCost lhs, ManaCost rhs)
        {
            return lhs.CompareTo(rhs) > 0;
        }

        public static bool operator >=(ManaCost lhs, ManaCost rhs)
        {
            return lhs.CompareTo(rhs) >= 0;
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(ToString());
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
