using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

class OddEvenElements
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

        char[] separators = new char[]{' '};
        string input = Console.ReadLine();
        string[] numbers;
        if (input.Length == 0)
        {
            numbers = new string[0];
        }
        else
        {
            numbers = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }
        
        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        decimal number;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                number = decimal.Parse(numbers[i]);
                oddSum += number;
                if (number < oddMin)
                {
                    oddMin = number;
                }
                if (number > oddMax)
                {
                    oddMax = number;
                }
            }
            else
            {
                number = decimal.Parse(numbers[i]);
                evenSum += number;
                if (number < evenMin)
                {
                    evenMin = number;
                }
                if (number > evenMax)
                {
                    evenMax = number;
                }
            }
        }

        if (numbers.Length == 1)
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3}, EvenMin={3}, EvenMax={3}", oddSum, oddMin, oddMax, "No");
        }
        else if (numbers.Length == 0)
        {
            Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum={0}, EvenMin={0}, EvenMax={0}", "No");
        }
        else
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3:0.##}, EvenMin={4:0.##}, EvenMax={5:0.##}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }
    }
}

