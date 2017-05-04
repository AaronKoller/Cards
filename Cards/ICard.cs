using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public interface ICardSuitValue<out S, V>
    {
        S Suit { get; }

        V Value { get; }

        int LengthSuit { get; }

        int LengthValue { get; }
    }
}
