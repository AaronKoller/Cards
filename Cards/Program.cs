using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new DeckSuitValue<StandardSuit, StandardValue>(new Standard());
            var deck = card.CreateDeck();
        }
    }
}
