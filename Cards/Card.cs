using System;

namespace Cards
{
    class Standard : ICardSuitValue<StandardSuit, StandardValue>
    {
        public Standard()
        {
        }

        private Standard(StandardSuit suit, StandardValue value)
        {
            Suit = suit;
            Value = value;
        }

        ICardSuitValue<StandardSuit, StandardValue> 
            ICardSuitValue<StandardSuit, StandardValue>
            .CreateCard(StandardSuit suit, StandardValue value)
        {
            return new Standard(suit, value);
        }

        public StandardSuit Suit { get; }

        public StandardValue Value { get; }

        public int LengthSuit => Enum.GetNames(typeof(StandardSuit)).Length;

        public int LengthValue => Enum.GetNames(typeof(StandardValue)).Length;
    }

    public enum StandardValue
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }

    public enum StandardSuit
    {
        Hearts = 1,
        Spades = 2,
        Clubs = 3,
        Diamonds = 4
    }

}
