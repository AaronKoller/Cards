using System;
using System.Collections.Generic;

namespace Cards
{
    class DeckSuitValue<S,V>
    {

        public List<ICardSuitValue<S, V>>CreateDeck(ICardSuitValue<S, V> cardSuitValue)
        {
            var deck = new List<ICardSuitValue<S, V>>();

            foreach (S suit in Enum.GetValues(typeof(S)))
            {
                foreach (V value in Enum.GetValues(typeof(V)))
                {
                    deck.Add(cardSuitValue.CreateCard(suit, value));
                }

            }
            return deck;
        }
    }
}
