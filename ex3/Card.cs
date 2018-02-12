using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Card
    {
        public string Suit { get; set; }
        public int Value { get; set; }

        public Card(string s, int v)
        {
            Suit = s;
            Value = v;
        }
    }
}
