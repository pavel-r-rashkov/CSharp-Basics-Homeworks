using System;

class CirclePerimeterArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter r: ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter: {0:F2}", 2 * Math.PI * r);
        Console.WriteLine("Area: {0:F2}", Math.PI * Math.Pow(r, 2));
    }
}

