using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            string[] cards = new string[13];
            cards[0] = "Ace";
            cards[1] = "two";
            cards[2] = "three";
            cards[3] = "four";
            cards[4] = "five";
            cards[5] = "six";
            cards[6] = "seven";
            cards[7] = "eight";
            cards[8] = "nine";
            cards[9] = "ten";
            cards[10] = "jack";
            cards[11] = "queen";
            cards[12] = "king";

            string[] cardsType = new string[4];
            cardsType[0] = "club";
            cardsType[1] = "heart";
            cardsType[2] = "diamods";
            cardsType[3] = "spade";



            for (int i = 0; i < cardsType.Length; i++)
            {
                for (int j = 0; j < cards.Length; j++)
                {
                    Console.WriteLine("{0,-10} of {1,10}" , cards[j],cardsType[i]);
                }
                Console.ReadLine();
            }
        }
    }
}
