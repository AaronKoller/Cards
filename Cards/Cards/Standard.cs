using System.ComponentModel;

namespace CardOrganizer.Cards
{
    internal class Standard<S, V> : Card<S, V>
    {
        public Standard(Permutation permutation = Permutation.Standard)
        {
            //check if the permutation of suit-value is valid
            switch (permutation)
            {
                case Permutation.Standard:
                    if (typeof(S) == typeof(StandardSuit) &&
                        typeof(V) == typeof(StandardValue))
                        return;
                    throw new InvalidEnumArgumentException(
                        "A standard card expects a 'suit' enum of StandardSuit and a 'value' of standardValue");
            }
        }

        private Standard(S suit, V value)
        {
            Suit = suit;
            Value = value;
        }

        public S Suit { get; }

        public V Value { get; }

        //Creates a concrete class of this card.  By creating a card this way, the deck can create any type.
        public override ICardSuitValue<S, V> CreateCard(S suit, V value)
        {
            return new Standard<S, V>(suit, value);
        }
    }
}