using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trapezoids
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter h: ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Trapezoid's area = " + (a + b) * h / 2);
    }
}

