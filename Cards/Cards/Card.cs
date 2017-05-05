using System;
using System.Collections.Generic;

namespace CardOrganizer.Cards
{
    public abstract class Card<S, V> : ICardSuitValue<S, V>
    {
        public virtual S Suit { get; }
        public virtual V Value { get; }

        //each class needs to be responsible for creating its own concrete instance
        public virtual ICardSuitValue<S, V> CreateCard(S s, V v)
        {
            throw new NotImplementedException();
        }

        public int LengthSuit => Enum.GetNames(typeof(S)).Length;

        public int LengthValue => Enum.GetNames(typeof(V)).Length;

        //all card types regardless of permutation will create a deck the same way
        public IEnumerable<ICardSuitValue<S, V>> CreateDeck()
        {
            var deck = new List<ICardSuitValue<S, V>>();

            foreach (S suit in Enum.GetValues(typeof(S)))
            {
                foreach (V value in Enum.GetValues(typeof(V)))
                {
                    deck.Add(CreateCard(suit, value));
                }
            }
            return deck;
        }
    }
}