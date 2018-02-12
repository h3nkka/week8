using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Deck
    {
        public List<Card> CardStack { get; set; }
        public int Count { get; set; }
        public void Construct()
        {
            CardStack = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                for (int v = 2; v < 15; v++)
                {
                    switch (i)
                    {
                        case 0:
                            CardStack.Add(new Card("Spades", v));
                            break;
                        case 1:
                            CardStack.Add(new Card("Clubs", v));
                            break;
                        case 2:
                            CardStack.Add(new Card("Hearts", v));
                            break;
                        case 3:
                            CardStack.Add(new Card("Diamonds", v));
                            break;
                    }
                    Count++;
                }
            }
        }

        public void Contents()
        {
            foreach (Card c in CardStack)
            {
                Console.WriteLine("{0} of {1}", c.Value, c.Suit);
            }
        }

        public void Shuffle()
        {
            Random RNG = new Random();
            int index;
            int index2;
            int index3;
            Card temp;

            for (int i = 0; i < 100; i++)
            {
                index = RNG.Next(0, Count);
                index2 = RNG.Next(0, Count);
                index3 = RNG.Next(0, Count);

                temp = CardStack[index];
                CardStack[index] = CardStack[index2];
                CardStack[index2] = CardStack[index3];
                CardStack[index3] = temp;
            }
        }
    }
}
