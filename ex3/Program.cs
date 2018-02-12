using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Construct(); //constructing a new deck with 52 cards
            Console.WriteLine("Contents of the deck of cards: ({0} cards)",deck.Count);
            deck.Contents();
            Console.WriteLine("\nContents of the deck shuffled:");
            deck.Shuffle(); //shuffling deck by swapping places between 3 random cards 100 times
            deck.Contents();

            Console.ReadKey(true);
        }
    }
}
