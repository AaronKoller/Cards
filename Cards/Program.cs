using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardOrganizer.Cards;

namespace CardOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartCardOrganizer();
            }
            catch (Exception ex)
            {
                if (args == null)
                {
                    Console.WriteLine("This program is buggy.  Get you money back and contact the developer");
                    return;
                }
                if(args[0] == "dev")
                {
                    Console.WriteLine(ex.Message  + Environment.NewLine + ex.StackTrace);
                }
            }
        }

        private static void StartCardOrganizer()
        {


            var standardCard = new Standard<StandardSuit, StandardValue>();
            var deck = standardCard.CreateDeck();
        }
    }
}

