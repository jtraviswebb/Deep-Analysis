using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepAnalysis.Net
{
    public enum ConditionLabel
	{
        NewMint = 8,
        SlightlyPlayed = 6,
        Played = 4,
        HeavilyPlayed = 2,
        Damaged = 0
	}

    public struct PhysicalCondition : IComparable<PhysicalCondition>
    {
        private bool foil;
        private ConditionLabel conditionLabel;

        public bool Foil { get { return foil; } }
        public ConditionLabel ConditionLabel { get { return conditionLabel; } }

        public PhysicalCondition(ConditionLabel ConditionLabel, bool Foil)
        {
            foil = Foil;
            conditionLabel = ConditionLabel;
        }

        public static PhysicalCondition Parse(string ConditionString)
        {
            bool foil = false;
            ConditionLabel conditionLabel = ConditionLabel.Played;

            string conditionString = ConditionString.ToLower().Trim();

            if (conditionString.Contains("foil"))
            {
                foil = true;
            }

            if (conditionString.Contains("New") || conditionString.Contains("NM"))
            {
                conditionLabel = ConditionLabel.NewMint;
            }
            else if (conditionString.Contains("Mint"))
            {
                conditionLabel = ConditionLabel.NewMint;
            }
            else if (conditionString.Contains("Slightly") || conditionString.Contains("SP"))
            {
                conditionLabel = ConditionLabel.SlightlyPlayed;
            }
            else if (conditionString.Contains("Heavily") || conditionString.Contains("HP"))
            {
                conditionLabel = ConditionLabel.HeavilyPlayed;
            }
            else if (conditionString.Contains("Damaged") || conditionString.Contains("DM"))
            {
                conditionLabel = ConditionLabel.Damaged;
            }

            return new PhysicalCondition(conditionLabel, foil);
        }

        public override string ToString()
        {
            return ConditionLabel + (Foil ? " Foil" : "");
        }

        public override bool Equals(object other)
        {
            return other is PhysicalCondition && Equals((PhysicalCondition)other);
        }

        private bool Equals(PhysicalCondition other)
        {
            return ConditionLabel == other.ConditionLabel &&
                Foil == other.Foil;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public int CompareTo(PhysicalCondition other)
        {
            return ((int)ConditionLabel + (Foil ? 1 : 0)) - ((int)other.ConditionLabel + (other.Foil ? 1 : 0));
        }

        public static bool operator ==(PhysicalCondition lhs, PhysicalCondition rhs)
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

        public static bool operator !=(PhysicalCondition lhs, PhysicalCondition rhs)
        {
            return !(lhs == rhs);
        }

        public static bool operator <(PhysicalCondition lhs, PhysicalCondition rhs)
        {
            return lhs.CompareTo(rhs) < 0;
        }

        public static bool operator <=(PhysicalCondition lhs, PhysicalCondition rhs)
        {
            return lhs.CompareTo(rhs) <= 0;
        }

        public static bool operator >(PhysicalCondition lhs, PhysicalCondition rhs)
        {
            return lhs.CompareTo(rhs) > 0;
        }

        public static bool operator >=(PhysicalCondition lhs, PhysicalCondition rhs)
        {
            return lhs.CompareTo(rhs) >= 0;
        }
    }
}
