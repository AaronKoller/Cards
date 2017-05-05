using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardOrganizer.Cards
{
    public abstract class Card<S, V> : ICardSuitValue<S, V>
    {
        public virtual S Suit { get; }
        public virtual V Value { get; }
        public virtual int LengthSuit { get; }
        public virtual int LengthValue { get; }

        public List<ICardSuitValue<S, V>> CreateDeck()
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

        public virtual ICardSuitValue<S, V> CreateCard(S suit, V v)
        {
            throw new NotImplementedException();
        }
    }
}
