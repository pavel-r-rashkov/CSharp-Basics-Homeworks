using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddEvenIntegers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer number: ");
        int testInteger = int.Parse(Console.ReadLine());
        Console.Write("Odd? " + (testInteger % 2 == 1));
        Console.WriteLine();
    }
}

