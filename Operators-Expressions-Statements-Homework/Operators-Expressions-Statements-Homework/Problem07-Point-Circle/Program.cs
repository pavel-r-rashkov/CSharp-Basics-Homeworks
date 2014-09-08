using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PointInsideCircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter x coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y coordinate: ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine("The point is inside the circle? : " + (Math.Pow(x, 2) + Math.Pow(y, 2) <= 4));
    }
}

