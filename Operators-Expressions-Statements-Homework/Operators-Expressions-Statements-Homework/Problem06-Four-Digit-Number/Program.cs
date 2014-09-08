using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter four-digit number: ");
        int number = int.Parse(Console.ReadLine());
        int fourthDigit = number % 10;
        int thirdDigit = (number / 10) % 10;
        int secondDigit = (number / 100) % 10;
        int firstDigit = number / 1000;
        Console.WriteLine("Sum of digits: " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
        Console.WriteLine("Reversed order: " + fourthDigit + thirdDigit + secondDigit + firstDigit);
        Console.WriteLine("Last digit at first position: " + fourthDigit + firstDigit + secondDigit + thirdDigit);
        Console.WriteLine("Second and third digit exchange: " + firstDigit + thirdDigit + secondDigit + fourthDigit);
    }
}

