using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Person
    {
        static List<string> alphabet = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void CreateName()
        {
            Random RNG = new Random(Guid.NewGuid().GetHashCode());
            StringBuilder sb = new StringBuilder(alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)]);
            FirstName = sb.ToString();
            sb = new StringBuilder(alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)]);
            LastName = sb.ToString();
        }

    }
}
