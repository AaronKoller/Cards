using CardOrganizer.Cards;

namespace CardOrganizer.Deck
{
    internal class DeckSuitValue<S, V>
    {
        private readonly ICardSuitValue<S, V> _cardSuitValue;

        public DeckSuitValue(ICardSuitValue<S, V> cardSuitValue)
        {
            _cardSuitValue = cardSuitValue;
        }
    }
}