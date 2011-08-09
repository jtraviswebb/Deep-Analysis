using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeepAnalysis.Core;

namespace DeepAnalysis.Net
{
    public abstract class CardPricer
    {
        public List<PriceEntry> PriceCard(Card card)
        {
            List<PriceEntry> results = new List<PriceEntry>();
            foreach (Printing printing in card.Printings)
            {
                results.AddRange(PriceCard(printing));
            }
            return results;
        }

        public List<PriceEntry> PriceCard(Card card, Printing printing)
        {
            if (printing == null)
            {
                return PriceCard(card);
            }
            else
            {
                return PriceCard(printing);
            }
        }

        public abstract List<PriceEntry> PriceCard(Printing printing);
    }
}
