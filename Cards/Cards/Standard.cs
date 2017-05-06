using System.ComponentModel;

namespace CardOrganizer.Cards
{
    internal class Standard<S, N> : Card<S, N>
    {
        public Standard(Permutation permutation = Permutation.Standard)
        {
            //check if the permutation of suit-name is valid
            switch (permutation)
            {
                case Permutation.Standard:
                    if (typeof(S) == typeof(StandardSuit) &&
                        typeof(N) == typeof(StandardName))
                        return;
                    throw new InvalidEnumArgumentException(
                        "A standard card expects a 'suit' enum of StandardSuit and a 'name' of standardName");
            }
        }

        private Standard(S suit, N name)
        {
            Suit = suit;
            Name = name;
        }

        public override S Suit { get; }

        public override N Name { get; }

        //Creates a concrete class of this card.  By creating a card this way, the deck can create any type.
        public override ICardSuitName<S, N> CreateCard(S suit, N name)
        {
            return new Standard<S, N>(suit, name);
        }
    }
}