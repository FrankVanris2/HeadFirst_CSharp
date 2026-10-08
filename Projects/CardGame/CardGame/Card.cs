using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace CardGame
{
    class Card(Values value, Suits suit)
    {
        public Values Value { get { return value;  } }
        public Suits Suit { get { return suit; } }

        public string Name
        {
            get { return $"{Value} of {Suit}"; }
        }
    }
}
