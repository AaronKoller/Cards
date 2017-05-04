
namespace Cards
{
    class Card
    {
        public Card(Suit suit, CardValue cardValue)
        {
            Suit = suit;
            CardValue = cardValue;
        }

        public Suit Suit { get; }

        public CardValue CardValue { get; }
    }

    public enum CardValue
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

    public enum Suit
    {
        Hearts = 1,
        Spades = 2,
        Clubs = 3,
        Diamonds = 4
    }

}
