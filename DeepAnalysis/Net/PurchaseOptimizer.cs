using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeepAnalysis.Net
{
    class PurchaseOptimizer
    {
        public void Purchase(CardPricer pricer, List<Purchase> items)
        {
            HashSet<string> allVendors = new HashSet<string>();
            Dictionary<Purchase, List<PriceEntry>> allEntries = new Dictionary<Purchase, List<PriceEntry>>();

            foreach (Purchase purchase in items)
            {
                List<PriceEntry> prices = pricer.PriceCard(purchase.Card, purchase.Printing);

                Dictionary<string, List<PriceEntry>> priceMapByVendor = VendorPriceMap(prices);

                allEntries[purchase] = new List<PriceEntry>();
                foreach (List<PriceEntry> pricesPerVendor in priceMapByVendor.Values)
                {
                    PriceEntry toAdd = BestPrice(pricesPerVendor, purchase.TargetCondition);
                    if (toAdd != null)
                    {
                        allEntries[purchase].Add(toAdd);
                        allVendors.Add(toAdd.Vendor);
                    }
                }
            }
            Console.WriteLine("done");
        }

        private PriceEntry BestPrice(List<PriceEntry> Prices, PhysicalCondition TargetCondidition)
        {
            PriceEntry result = null;
            foreach (PriceEntry priceEntry in Prices)
            {
                if (priceEntry.Condition > TargetCondidition && (result == null || priceEntry.Price > result.Price))
                {
                    result = priceEntry;
                }
            }
            return result;
        }

        private Dictionary<string, List<PriceEntry>> VendorPriceMap(List<PriceEntry> prices)
        {
            Dictionary<string, List<PriceEntry>> result = new Dictionary<string, List<PriceEntry>>();

            foreach (PriceEntry item in prices)
            {
                if (!result.ContainsKey(item.Vendor))
                {
                    result[item.Vendor] = new List<PriceEntry>();
                }
                result[item.Vendor].Add(item);
            }

            return result;
        }
    }
}
