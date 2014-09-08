using System;

class SumOfNumbers
{
    static void Main(string[] args)
    {
        char[] tokens = new char[] { ' ' };
        string input = Console.ReadLine();
        string[] numbers = input.Split(tokens);
        double sum = 0;
        foreach (string number in numbers)
        {
            sum += double.Parse(number);
        }
        Console.WriteLine(sum);
    }
}

