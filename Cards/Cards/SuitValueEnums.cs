namespace CardOrganizer.Cards
{
    //should be used in conjunction with card Generics validation - yeah, that's what I said, validating a Generic
    public enum Permutation
    {
        Any,
        Standard
    }

    public enum StandardName
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