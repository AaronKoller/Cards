using System;
using CardOrganizer.Cards;

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
                    return;
                }
                if (args[0] == "dev")
                    Console.WriteLine("ERROR MESSAGE: "+ ex.Message + Environment.NewLine + 
                                      "STACK TRACE " + ex.StackTrace);
            }
        }

        private static void StartSuperGenericCardOrganizer()
        {
            //we will create just a standard card
            var standardCard = new Standard<StandardSuit, StandardValue>();
            var test = standardCard.Suit;
            var lengthSuite = standardCard.LengthSuit;
            var lengthValue = standardCard.LengthValue;
            var deck = standardCard.CreateDeck();

            var standardCard1 = new Standard<StandardValue, StandardSuit>(Permutation.Any);
            var deck1 = standardCard1.CreateDeck();

            var standardCard2 = new Standard<StandardValue, StandardSuit>();

        }
    }
}