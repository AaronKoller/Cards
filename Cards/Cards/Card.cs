using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;

namespace CardOrganizer.Cards
{
    public abstract class Card<S, N> : ICardSuitName<S, N>
    {
        public virtual S Suit { get; }
        public virtual N Name { get; }

        //each class needs to be responsible for creating its own concrete instance
        public virtual ICardSuitName<S, N> CreateCard(S s, N n)
        {
            throw new NotImplementedException();
        }

        public int ValueSuit => GenericEnumToInt<S>();

        public int ValueName => GenericEnumToInt<S>();

        private int GenericEnumToInt<T>() {
            Type genericType = typeof(T);
            if (genericType.IsEnum)
            {
                foreach (T obj in Enum.GetValues(genericType))
                {
                    Enum test = Enum.Parse(typeof(T), obj.ToString()) as Enum;
                    return Convert.ToInt32(test); // x is the integer value of enum
                }
            }
            throw new InvalidEnumArgumentException("Only Enums can be passed to GenericEnumToInt()");
        }


        //all card types regardless of permutation will create a deck the same way
        public List<ICardSuitName<S, N>> CreateDeck()
        {
            var deck = new List<ICardSuitName<S, N>>();

            foreach (S suit in Enum.GetValues(typeof(S)))
            {
                foreach (N name in Enum.GetValues(typeof(N)))
                {
                    deck.Add(CreateCard(suit, name));
                }
            }
            return deck;
        }
    }
}