using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double biggestNumber = double.MinValue;
        if (a > biggestNumber)
        {
            biggestNumber = a;
        }
        if (b > biggestNumber)
        {
            biggestNumber = a;
        }
        if (c > biggestNumber)
        {
            biggestNumber = a;
        }
        if (d > biggestNumber)
        {
            biggestNumber = a;
        }
        if (e > biggestNumber)
        {
            biggestNumber = a;
        }
        Console.WriteLine(biggestNumber);
    }
}

