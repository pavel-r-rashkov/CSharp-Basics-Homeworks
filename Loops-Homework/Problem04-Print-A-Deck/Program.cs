using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintDeck
{
    static void Main(string[] args)
    {
        char[] suits = new char[] { '\u2663', '\u2666', '\u2665', '\u2660' };
        string[] faces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        for (int face = 0; face < 13; face++)
        {
            for (int suit = 0; suit < 4; suit++)
            {
                Console.Write((faces[face] + suits[suit]).PadLeft(4));             
            }
            Console.WriteLine();
        }
    }
}

