using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number : ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number != 2)
        {
            for (int divider = 3; divider <= Math.Sqrt(number); divider += 2)
            {
                if (number % divider == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        Console.WriteLine("Prime? : " + isPrime);
    }
}

