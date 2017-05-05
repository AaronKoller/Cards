using System;
using System.Collections.Generic;
using System.ComponentModel;
using CardOrganizer;
using CardOrganizer.Cards;

namespace CardOrganizer
{
    class Standard<S, V> : Card<StandardSuit, StandardValue>
    {
        public Standard(Permutation permutation = Permutation.Standard)
        {
            switch (permutation)
            {
                 case   Permutation.Standard:
                    if (typeof(S) == typeof(StandardSuit) &&
                        typeof(V) == typeof(StandardValue))
                    {
                        return;
                    }
                    throw new InvalidEnumArgumentException("A standard card expects a 'suit' enum of StandardSuit and a 'value' of standardValue");
            }
        }

        private Standard(StandardSuit suit, StandardValue value)
        {
            Suit = suit;
            Value = value;
        }

        public override ICardSuitValue<StandardSuit, StandardValue> CreateCard(StandardSuit suit, StandardValue value)
        {
            return new Standard<S, V>(suit, value);
        }

        public StandardSuit Suit { get; }

        public StandardValue Value { get; }

        public int LengthSuit => Enum.GetNames(typeof(StandardSuit)).Length;

        public int LengthValue => Enum.GetNames(typeof(StandardValue)).Length;
    }





}
