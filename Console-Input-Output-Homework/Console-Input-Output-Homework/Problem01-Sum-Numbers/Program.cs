using System;

class SumOFNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Sum = " + (firstNumber + secondNumber + thirdNumber));
    }
}

