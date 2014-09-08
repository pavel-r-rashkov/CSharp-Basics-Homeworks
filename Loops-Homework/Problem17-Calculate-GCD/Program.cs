using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateGCD
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        while (min != 0)
        {
            int oldMax = max;
            max = min;
            min = oldMax % min;
        }
        Console.WriteLine("GCD({0}, {1}) = {2}", a, b, max);
    }
}

