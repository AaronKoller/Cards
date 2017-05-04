namespace Cards
{
    public interface ICardSuitValue<S, V>
    {
        S Suit { get; }

        V Value { get; }

        int LengthSuit { get; }

        int LengthValue { get; }

        ICardSuitValue<S, V> CreateCard(S s,V v);

    }
}
