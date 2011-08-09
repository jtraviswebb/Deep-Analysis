using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepAnalysis.Net
{
    public class PriceEntry
    {
        private string vendor;
        private PhysicalCondition condition;
        private int quantity;
        private decimal price;

        public string Vendor { get { return vendor; } }
        public PhysicalCondition Condition { get { return condition; } }
        public int Quantity { get { return quantity; } }
        public decimal Price { get { return price; } }

        public PriceEntry(string Vendor, PhysicalCondition Condition, int Quantity, decimal Price)
        {
            vendor = Vendor;
            condition = Condition;
            quantity = Quantity;
            price = Price;
        }

        public override string ToString()
        {
            return vendor + " : " + condition + " , " + quantity + " = " + price;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            // If parameter is null return false
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Card return false
            PriceEntry pe = obj as PriceEntry;
            if ((object)pe == null)
            {
                return false;
            }

            // Return true if the fields match
            return Equals(pe);
        }

        public bool Equals(PriceEntry pe)
        {
            // If parameter is null return false
            if ((object)pe == null)
            {
                return false;
            }

            // Return true if the fields match
            return Vendor == pe.Vendor &&
                Condition == pe.Condition &&
                Quantity == pe.Quantity &&
                Price == pe.Price; //TODO eps??;
        }
    }
}
