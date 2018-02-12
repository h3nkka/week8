using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++)
            {
                Person p = new Person();
                p.CreateName();
                personList.Add(p);
            }
            watch.Stop();
            Console.WriteLine("Done adding people to list. Took {0} ms", watch.ElapsedMilliseconds);

            List<string> alphabet = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            watch = System.Diagnostics.Stopwatch.StartNew();
            for (int amount = 0; amount < 1000; amount++)
            {
                Random RNG = new Random(Guid.NewGuid().GetHashCode());
                StringBuilder sb = new StringBuilder(alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)]);
                string randomName = sb.ToString();
                for (int i = 0; i < 10000; i++)
                {
                    if (personList[i].FirstName == randomName)
                    {
                        Console.WriteLine("Found person with {0} firstname : {1} {2} ", randomName, personList[i].FirstName, personList[i].LastName);
                        break;
                    }
                }
            }
            watch.Stop();
            Console.WriteLine("Done attemping to find random people from list. Took {0} ms", watch.ElapsedMilliseconds);

            Dictionary<string,Person> personDictionary = new Dictionary<string,Person>();
            watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 10000; i++)
            {
                Person p = new Person();
                p.CreateName();
                if (!personDictionary.ContainsKey(p.FirstName))
                    personDictionary.Add(p.FirstName,p);
                else
                    i--;
            }
            watch.Stop();
            Console.WriteLine("Done adding people to dictionary. Took {0} ms", watch.ElapsedMilliseconds);     

            watch = System.Diagnostics.Stopwatch.StartNew();
            for (int amount = 0; amount < 1000; amount++)
            {
                Random RNG = new Random(Guid.NewGuid().GetHashCode());
                StringBuilder sb = new StringBuilder(alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)] + alphabet[RNG.Next(0, alphabet.Count - 1)]);
                string randomName = sb.ToString();

                if(personDictionary.TryGetValue(randomName, out Person x))
                    Console.WriteLine("Found person with {0} firstname : {1} {2} ", randomName, x.FirstName, x.LastName);
            }
            watch.Stop();
            Console.WriteLine("Done attemping to find random people from dictionary. Took {0} ms", watch.ElapsedMilliseconds);

            Console.ReadKey(true);
        }
    }
}
