using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepAnalysis.Core
{
    // no support for split cards
    // no support for flip cards
    [Serializable]
    public class Card
    {
        public string Name { get; set; }
        public string Typeline { get; set; }
        public string Text { get; set; }
        public ManaCost Cost { get; set; }
        public List<Printing> Printings { get; set; }

        public Card()
        {
            Printings = new List<Printing>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name).Append(" : ").Append(Cost);
            sb.Append('\n').Append(Typeline);
            sb.Append('\n').Append(Text);

            foreach (Printing p in Printings)
            {
                sb.Append("\n").Append(p);
            }

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

        public bool Equals(Card c)
        {
            // If parameter is null return false
            if ((object)c == null)
            {
                return false;
            }

            // Return true if the fields match
            return Name == c.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
