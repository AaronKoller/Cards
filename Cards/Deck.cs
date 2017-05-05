using System;
using System.Collections.Generic;

namespace Cards
{
    class DeckSuitValue<S,V>
    {
        private readonly ICardSuitValue<S, V> _cardSuitValue;

        public DeckSuitValue(ICardSuitValue<S, V> cardSuitValue)
        {
            _cardSuitValue = cardSuitValue;
        }

        public List<ICardSuitValue<S, V>>CreateDeck()
        {
            var deck = new List<ICardSuitValue<S, V>>();

            foreach (S suit in Enum.GetValues(typeof(S)))
            {
                foreach (V value in Enum.GetValues(typeof(V)))
                {
                    deck.Add(_cardSuitValue.CreateCard(suit, value));
                }

            }
            return deck;
        }
    }

}
