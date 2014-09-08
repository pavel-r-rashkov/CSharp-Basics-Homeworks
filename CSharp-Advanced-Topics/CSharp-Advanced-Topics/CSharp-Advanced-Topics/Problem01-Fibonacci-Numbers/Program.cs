using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine(Fib(25));
    }
    static long Fib(int n)
    {
        long first = 1;
        long second = 1;
        for (int i = 2; i <= n; i++)
        {
            long oldFirst = first;
            first = second;
            second += oldFirst;
        }
        return second;
    }
}

