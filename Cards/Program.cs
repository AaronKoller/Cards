using System;
using System.Linq;
using CardOrganizer.Cards;
using CardOrganizer.Library;

namespace CardOrganizer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                StartSuperGenericCardOrganizer();
            }
            catch (Exception ex)
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("This program is buggy.  Get you money back and contact the developer.");
                }
               else if (args[0] == "dev")
                    Console.WriteLine("ERROR MESSAGE: "+ ex.Message + Environment.NewLine + 
                                      "STACK TRACE " + ex.StackTrace);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void StartSuperGenericCardOrganizer()
        {
            //we will create just a standard card
            var standardCard = new Standard<StandardSuit, StandardName>();
            var deck = standardCard.CreateDeck();
            deck.Shuffle();
            Console.WriteLine("Shuffle the cards.  Press any key.");
            Console.ReadKey();
            foreach (var card in deck)
            {
                Console.WriteLine($"{card.Suit} - {card.Name}");
            }

            Console.WriteLine("Sort the cards.  Press any key.");
            Console.ReadKey();
            var orderedDeck = deck.OrderBy(a => (int) a.Suit).ThenBy(b => (int) b.Name).ToList();

            foreach (var card in orderedDeck)
            {
                Console.WriteLine($"{card.Suit} - {card.Name}");
            }

            //var unoCard = new Standard<UnoSuit, UnoName>();
            //var unoDeck = unoCard.CreateDeck();
            //unoDeck.Shuffle();
            //var orderedUnoDeck = unoDeck.OrderBy(a => (int)a.Suit).ThenBy(b => (int)b.Name).ToList();

            //var standardCard1 = new Standard<StandardName, StandardSuit>(Permutation.Any);
            //var standardCard2 = new Standard<StandardName, StandardSuit>();

        }
    }
}