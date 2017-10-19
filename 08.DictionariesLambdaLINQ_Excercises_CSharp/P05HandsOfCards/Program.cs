using System;
using System.Collections.Generic;
using System.Linq;

namespace P05HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dic = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                string[] name = input.Split(':').Take(1).ToArray();
                var drowedCards = input.Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
                if (!dic.ContainsKey(name[0]))
                {
                    dic[name[0]] = new Dictionary<string, int>();
                    foreach (string card in drowedCards.Distinct())
                    {
                        dic[name[0]].Add(cardNames(card), cardValues(card));
                    }
                }
                else
                {
                    foreach (string card in drowedCards.Distinct())
                    {
                        if (!dic[name[0]].ContainsKey(cardNames(card)))
                        {
                            dic[name[0]].Add(cardNames(card), cardValues(card));
                        }
                    };
                }
                input = Console.ReadLine();
            }
            foreach (string person in dic.Keys)
            {
                Console.Write(person + ": ");
                int value = dic[person].Values.Distinct().Sum();
                Console.WriteLine(value);
            }
        }

        private static int cardValues(string drowedCards)
        {
            int values = values = GetCardValu(drowedCards); ;
            return values;
        }

        private static string cardNames(string drowedCards)
        {
            string cards = drowedCards;
            return cards;
        }

        private static int GetCardValu(string card)
        {
            int cardsValue = 0;
            Dictionary<string, int> cardsPower = new Dictionary<string, int>()
            {
                {"2" ,2 },
                {"3" ,3 },
                {"4" ,4 },
                {"5" ,5 },
                {"6" ,6 },
                {"7" ,7 },
                {"8" ,8 },
                {"9" ,9 },
                {"1" ,10 },
                {"J" ,11 },
                {"Q" ,12 },
                {"K" ,13 },
                {"A" ,14 }

            };
            if (cardsPower.ContainsKey(card[0].ToString()))
            {
                cardsValue = cardsPower[card[0].ToString()];
            }
            cardsValue *= GetCardMultiplier(card);

            return cardsValue;
        }
        private static int GetCardMultiplier(string cardType)
        {
            int multiplier = 0;
            Dictionary<string, int> cardsMultiplier = new Dictionary<string, int>()
            {
                { "S" , 4 }, {"H", 3 }, {"D", 2 }, {"C" , 1 }
            };
            if (cardsMultiplier.ContainsKey(cardType[(cardType.Length - 1)].ToString()))
            {
                multiplier = cardsMultiplier[cardType[(cardType.Length - 1)].ToString()];
            }
            return multiplier;
        }
    }
}
