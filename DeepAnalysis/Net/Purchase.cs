using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeepAnalysis.Core;

namespace DeepAnalysis.Net
{
    public struct Purchase
    {
        private PhysicalCondition targetCondition;
        private Card card;
        private Printing printing;

        public PhysicalCondition TargetCondition { get { return targetCondition; } }
        public Card Card { get { return card; } }
        public Printing Printing { get { return printing; } }

        public Purchase(PhysicalCondition TargetCondition, Card Card)
            : this(TargetCondition, Card, null)
        {
        }

        public Purchase(PhysicalCondition TargetCondition, Card Card, Printing Printing)
        {
            targetCondition = TargetCondition;
            card = Card;
            printing = Printing;
        }

        public override string ToString()
        {
            return Card.Name + " " + (Printing == null ? "" : "(" + Printing.Edition.Name + ") " ) + ": " + TargetCondition;
        }

        public override bool Equals(object other)
        {
            return other is Purchase && Equals((Purchase)other);
        }

        private bool Equals(Purchase other)
        {
            return TargetCondition == other.TargetCondition &&
                Card == other.Card &&
                Printing.Equals(other.Printing);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public static bool operator ==(Purchase lhs, Purchase rhs)
        {
            // If both are null, or both are same instance, return true
            if (object.ReferenceEquals(lhs, rhs))
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

        public static bool operator !=(Purchase lhs, Purchase rhs)
        {
            return !(lhs == rhs);
        }
    }
}
