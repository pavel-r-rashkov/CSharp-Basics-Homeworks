using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("x = {0}", (-c / b));
        }
        else
        {
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant == 0)
            {
                Console.WriteLine("x1 = x2 = {0}", -b / (2 * a));
            }
            else if (discriminant > 0)
            {
                Console.WriteLine("x1 = {0}; x2 = {1}", ((-b + Math.Sqrt(discriminant)) / (2 * a)), ((-b - Math.Sqrt(discriminant)) / (2 * a)));
            }
            else
            {
                Console.WriteLine("no real roots ");
            }
        }
    }
}

