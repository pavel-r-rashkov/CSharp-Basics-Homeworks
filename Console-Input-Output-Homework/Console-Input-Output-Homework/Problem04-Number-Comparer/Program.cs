using System;

class NumberComaparer
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(a < b ? b : a);
    }
}

