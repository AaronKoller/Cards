namespace CardOrganizer.Cards
{
    public interface ICardSuitValue<S, V>
    {
        S Suit { get; }

        V Value { get; }

        int LengthSuit { get; }

        int LengthValue { get; }

        ICardSuitValue<S, V> CreateCard(S suit, V value);
    }
}