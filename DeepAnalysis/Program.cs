using DeepAnalysis.Net.Mcdi;
using DeepAnalysis.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using DeepAnalysis.Cube;
using DeepAnalysis.Net;

namespace DeepAnalysis
{
    class Program
    {
        //GdocCube cube = new GdocCube("jtraviswebb", "");
        //cube.Entries.Add(new CubeEntry("TestCardName", "TestSetName", 1000, CubeStatus.Emeritus));
        //cube.Save();
        ////GdocCube cube = new GdocCube("knifebrightinsight", "");
        //Console.ReadLine();

        static void Main(string[] args)
        {
            // Individual Testing
            //McdiSetParser setParser = new McdiSetParser("Test", new List<Card>(), new Dictionary<string, int>());
            //setParser.ParseUrl("5dn/en.html");
            //McdiCardParser cardParser = new McdiCardParser("Test");
            //cardParser.ParseUrl("chk/en/309.html");



            // Pull from the web
            //McdiSiteParser parser = new McdiSiteParser();
            //List<Card> db = parser.Parse();

            // Serialization
            //XmlSerializer serializer = new XmlSerializer(db.GetType());
            //TextWriter textWriter = new StreamWriter(@"C:\cards.xml");
            //serializer.Serialize(textWriter, db);
            //textWriter.Close();

            // Deserialization
            TextReader reader = new StreamReader(@"C:\cards.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Card>));
            List<Card> db = (List<Card>)serializer.Deserialize(reader);
            reader.Close();

            PrintSetCounts(db, "roe", true);
            //PrintSetCounts(db, "wwk", true);
            //PrintSetCounts(db, "zen", true);

            //PrintSetCounts(db, "arb", true);
            //PrintSetCounts(db, "cfx", true);
            //PrintSetCounts(db, "ala", true);

            //PrintSetCounts(db, "eve", false);
            //PrintSetCounts(db, "shm", false);

            //PrintSetCounts(db, "mt", false);
            //PrintSetCounts(db, "lw", false);

            //PrintSetCounts(db, "fut", false);
            //PrintSetCounts(db, "pc", false);
            //PrintSetCounts(db, "ts", false);


            // Purchasing
            //PurchaseOptimizer opt = new PurchaseOptimizer();
            //List<Purchase> purchases = new List<Purchase>();
            ////purchases.Add(new Purchase(
            //McdiCardPricer pricer = new McdiCardPricer();
            //opt.Purchase(pricer, purchases);


            Console.ReadLine();
        }

        private static void PrintSetCounts(List<Card> db, string setAbbreviation, bool packsHaveBasics)
        {
            Console.WriteLine(setAbbreviation + " = [");

            var cardsInSet = from card in db where card.Editions.Any(e => e.SetAbbreviation.ToLower() == setAbbreviation) select card;
            bool hasMythics = (from card in cardsInSet where (from ed in card.Editions where ed.SetAbbreviation.ToLower() == setAbbreviation select ed).First().Rarity.Mainclass == Rarity.RarityMainclass.Mythic select card).Count() > 0;
            int highesCmc = cardsInSet.Max(c => c.Cost.ConvertedManaCost);

            for (int i = 0; i <= highesCmc; i++)
            {
                int whiteCommonsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Common, CardColor.White);
                int blueCommonsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Common, CardColor.Blue);
                int blackCommonsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Common, CardColor.Black);
                int redCommonsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Common, CardColor.Red);
                int greenCommonsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Common, CardColor.Green);
                int colorlessCommonsAtCmc = CountColorlessCardsInSetAtCostAtRarity(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Common);
                int goldCommonsAtCmc = CountGoldCardsInSetAtCostAtRarity(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Common);


                int whiteUncommonsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Uncommon, CardColor.White);
                int blueUncommonsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Uncommon, CardColor.Blue);
                int blackUncommonsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Uncommon, CardColor.Black);
                int redUncommonsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Uncommon, CardColor.Red);
                int greenUncommonsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Uncommon, CardColor.Green);
                int colorlessUncommonsAtCmc = CountColorlessCardsInSetAtCostAtRarity(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Uncommon);
                int goldUncommonsAtCmc = CountGoldCardsInSetAtCostAtRarity(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Uncommon);


                int whiteRaresAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Rare, CardColor.White);
                int blueRaresAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Rare, CardColor.Blue);
                int blackRaresAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Rare, CardColor.Black);
                int redRaresAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Rare, CardColor.Red);
                int greenRaresAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Rare, CardColor.Green);
                int colorlessRaresAtCmc = CountColorlessCardsInSetAtCostAtRarity(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Rare);
                int goldRaresAtCmc = CountGoldCardsInSetAtCostAtRarity(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Rare);

                int whiteMythicsAtCmc = 0, blueMythicsAtCmc = 0, blackMythicsAtCmc = 0, redMythicsAtCmc = 0, greenMythicsAtCmc = 0, colorlessMythicsAtCmc = 0, goldMythicsAtCmc = 0;
                if (hasMythics)
                {
                    whiteMythicsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Mythic, CardColor.White);
                    blueMythicsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Mythic, CardColor.Blue);
                    blackMythicsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Mythic, CardColor.Black);
                    redMythicsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Mythic, CardColor.Red);
                    greenMythicsAtCmc = CountCardsInSetAtCostAtRarityOfColor(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Mythic, CardColor.Green);
                    colorlessMythicsAtCmc = CountColorlessCardsInSetAtCostAtRarity(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Mythic);
                    goldMythicsAtCmc = CountGoldCardsInSetAtCostAtRarity(cardsInSet, setAbbreviation, i, Rarity.RarityMainclass.Mythic);
                }

                double rareFactor = 1;
                if (hasMythics)
                {
                    rareFactor = 7.0 / 8.0;
                }
                int commonFactor = 11;
                if (packsHaveBasics)
                {
                    commonFactor = 10;
                }
                double whiteCountAtCmc = whiteCommonsAtCmc * commonFactor + whiteUncommonsAtCmc * 3 + whiteRaresAtCmc * rareFactor + whiteMythicsAtCmc * (1.0 / 8.0);
                double blueCountAtCmc = blueCommonsAtCmc * commonFactor + blueUncommonsAtCmc * 3 + blueRaresAtCmc * rareFactor + blueMythicsAtCmc * (1.0 / 8.0);
                double blackCountAtCmc = blackCommonsAtCmc * commonFactor + blackUncommonsAtCmc * 3 + blackRaresAtCmc * rareFactor + blackMythicsAtCmc * (1 / 8.0);
                double redCountAtCmc = redCommonsAtCmc * commonFactor + redUncommonsAtCmc * 3 + redRaresAtCmc * rareFactor + redMythicsAtCmc * (1.0 / 8.0);
                double greenCountAtCmc = greenCommonsAtCmc * commonFactor + greenUncommonsAtCmc * 3 + greenRaresAtCmc * rareFactor + greenMythicsAtCmc * (1.0 / 8.0);
                double colorlessCountAtCmc = colorlessCommonsAtCmc * commonFactor + colorlessUncommonsAtCmc * 3 + colorlessRaresAtCmc * rareFactor + colorlessMythicsAtCmc * (1.0 / 8.0);
                double goldCountAtCmc = goldCommonsAtCmc * commonFactor + goldUncommonsAtCmc * 3 + goldRaresAtCmc * rareFactor + goldMythicsAtCmc * (1.0 / 8.0);

                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", whiteCountAtCmc, blueCountAtCmc, blackCountAtCmc, redCountAtCmc, greenCountAtCmc, colorlessCountAtCmc, goldCountAtCmc);
            }
            Console.WriteLine("];");
        }

        private static int CountGoldCardsInSetAtCostAtRarity(IEnumerable<Card> CardsInSet, string SetAbbreviation, int Cmc, Rarity.RarityMainclass Rarity)
        {
            var cards = from card in CardsInSet
             where
                 (from ed in card.Editions where ed.SetAbbreviation.ToLower() == SetAbbreviation select ed).First().Rarity.Mainclass == Rarity &&
                 card.Cost.ConvertedManaCost == Cmc &&
                 card.Cost.IsGold &&
                                card.Typeline.Contains("Creature")
             select card;

            return cards.Count();
        }

        private static int CountColorlessCardsInSetAtCostAtRarity(IEnumerable<Card> CardsInSet, string SetAbbreviation, int Cmc, Rarity.RarityMainclass RarityType)
        {
            var cards = (from card in CardsInSet
                       where
                           (from ed in card.Editions where ed.SetAbbreviation.ToLower() == SetAbbreviation select ed).First().Rarity.Mainclass == RarityType &&
                           card.Cost.ConvertedManaCost == Cmc &&
                           card.Cost.IsColorless &&
                                card.Typeline.Contains("Creature") //&&
                       //(from ed in card.Editions where ed.SetAbbreviation.ToLower() == SetAbbreviation select ed).First().Rarity.Mainclass != Rarity.RarityMainclass.Land
                       select card);

            foreach (Card item in cards)
            {
                Console.WriteLine(item.Name);
            }

            return cards.Count();
        }

        private enum CardColor
	    {
            White,
            Blue,
            Black,
            Red,
            Green
	    }

        private static int CountCardsInSetAtCostAtRarityOfColor(IEnumerable<Card> CardsInSet, string SetAbbreviation, int Cmc, Rarity.RarityMainclass Rarity, CardColor color)
        {
            IEnumerable<Card> cards = null;
            switch (color)
            {
                case CardColor.White:
                    cards = from card in CardsInSet
                            where
                                (from ed in card.Editions where ed.SetAbbreviation.ToLower() == SetAbbreviation select ed).First().Rarity.Mainclass == Rarity &&
                                card.Cost.ConvertedManaCost == Cmc &&
                                card.Cost.IsWhite &&
                                !card.Cost.IsGold &&
                                card.Typeline.Contains("Creature")
                            select card;
                    break;
                case CardColor.Blue:
                    cards = from card in CardsInSet
                            where
                                (from ed in card.Editions where ed.SetAbbreviation.ToLower() == SetAbbreviation select ed).First().Rarity.Mainclass == Rarity &&
                                card.Cost.ConvertedManaCost == Cmc &&
                                card.Cost.IsBlue &&
                                !card.Cost.IsGold &&
                                card.Typeline.Contains("Creature")
                            select card;
                    break;
                case CardColor.Black:
                    cards = from card in CardsInSet
                            where
                                (from ed in card.Editions where ed.SetAbbreviation.ToLower() == SetAbbreviation select ed).First().Rarity.Mainclass == Rarity &&
                                card.Cost.ConvertedManaCost == Cmc &&
                                card.Cost.IsBlack &&
                                !card.Cost.IsGold &&
                                card.Typeline.Contains("Creature")
                            select card;
                    break;
                case CardColor.Red:
                    cards = from card in CardsInSet
                            where
                                (from ed in card.Editions where ed.SetAbbreviation.ToLower() == SetAbbreviation select ed).First().Rarity.Mainclass == Rarity &&
                                card.Cost.ConvertedManaCost == Cmc &&
                                card.Cost.IsRed &&
                                !card.Cost.IsGold &&
                                card.Typeline.Contains("Creature")
                            select card;
                    break;
                case CardColor.Green:
                    cards = from card in CardsInSet
                            where
                                (from ed in card.Editions where ed.SetAbbreviation.ToLower() == SetAbbreviation select ed).First().Rarity.Mainclass == Rarity &&
                                card.Cost.ConvertedManaCost == Cmc &&
                                card.Cost.IsGreen &&
                                !card.Cost.IsGold &&
                                card.Typeline.Contains("Creature")
                            select card;
                    break;
                default:
                    return -1;
            }

            return cards.Count();
        }
    }
}
