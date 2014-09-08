using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MoonGravity
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your weight: ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Your weight on the Moon is: ");
        Console.Write(0.17 * weight);
        Console.WriteLine();
    }
}

