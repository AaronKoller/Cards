using System;
using System.Collections.Generic;

namespace CardOrganizer
{
    class DeckSuitValue<S, V>
    {
        private readonly ICardSuitValue<S, V> _cardSuitValue;

        public DeckSuitValue(ICardSuitValue<S, V> cardSuitValue)
        {
            _cardSuitValue = cardSuitValue;
        }


    }

}
