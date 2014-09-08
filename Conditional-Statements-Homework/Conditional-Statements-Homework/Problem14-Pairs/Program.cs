using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pairs
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] tokens = new char[]{ ' ' };
        string[] numbers = input.Split(tokens);
        bool equal = true;
        int value = int.Parse(numbers[0]) + int.Parse(numbers[1]);
        int maxDifference = 0;

        for (int i = 2; i < numbers.Length; i += 2)
        {
            if (int.Parse(numbers[i]) + int.Parse(numbers[i + 1]) != value)
            {
                equal = false;
                maxDifference = Math.Max(maxDifference, Math.Abs(int.Parse(numbers[i]) + int.Parse(numbers[i + 1]) - value));
                value = int.Parse(numbers[i]) + int.Parse(numbers[i + 1]);
            }
        }
        if (equal)
	    {
		    Console.WriteLine("Yes, value=" + value);
	    }
        else
        {
            Console.WriteLine("No, maxdiff=" + maxDifference);
        }
    }
}

