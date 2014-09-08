using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PointCircleRectangle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter x coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y coordinate: ");
        double y = double.Parse(Console.ReadLine());
        bool insideCircle = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= Math.Pow(1.5, 2);
        bool insideRectangle = x >= -1 && x <= 5 && y <= 1 && y >= -1;
        Console.WriteLine("The point is inside the circle and out of the rectangle? : " + (insideCircle && !insideRectangle ? "yes" : "no"));
    }
}

