
using System;

namespace Cards
{
    class Standard52 : ICardSuitValue<Standard52Suit, Standard52Value>
    {
        public Standard52(Standard52Suit suit, Standard52Value value)
        {
            Suit = suit;
            Value = value;
        }

        public Standard52Suit Suit { get; }

        public Standard52Value Value { get; }

        public int LengthSuit => Enum.GetNames(typeof(Standard52Suit)).Length;

        public int LengthValue => Enum.GetNames(typeof(Standard52Value)).Length;
    }

    public enum Standard52Value
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

    public enum Standard52Suit
    {
        Hearts = 1,
        Spades = 2,
        Clubs = 3,
        Diamonds = 4
    }

}
