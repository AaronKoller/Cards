namespace Cards
{
    public interface ICardSuitValue<out S, out V>
    {
        S Suit { get; }

        V Value { get; }

        int LengthSuit { get; }

        int LengthValue { get; }
    }
}
