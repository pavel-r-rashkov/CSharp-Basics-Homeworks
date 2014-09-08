using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeChecker
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPrime(2));
    }
    static bool IsPrime(long n)
    {
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(n);
        bool isPrime = true;
        if (n == 0 || n == 1)
        {
            return false;
        }
        for (int i = divider; i <= maxDivider; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
}

