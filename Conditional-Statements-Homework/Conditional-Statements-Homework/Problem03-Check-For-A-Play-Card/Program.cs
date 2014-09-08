using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckForAPlayCard
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        Console.WriteLine(cards.Contains(input) ? "Yes" : "No");
    }
}

