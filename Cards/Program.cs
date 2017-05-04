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
            var deck = new DeckSuitValue<Standard52Suit, Standard52Value>();
            deck.CreateDeck(new Standard52());
        }
    }
}
