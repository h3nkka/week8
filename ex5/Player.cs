using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public char Handedness { get; set; }

        public Player(string fn, string ln, int n, char h)
        {
            FirstName = fn;
            LastName = ln;
            Number = n;
            Handedness = h;
        }
    }
}
