namespace CardOrganizer.Cards
{
    public interface ICardSuitName<S, N>
    {
        S Suit { get; }

        N Name { get; }

        int ValueSuit { get; }

        int ValueName { get; }

        ICardSuitName<S, N> CreateCard(S suit, N name);
    }
}