using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomizeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter n: ");
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            int number = rnd.Next(n + 1);
            while (numbers.Contains(number))
            {
                number = rnd.Next(n + 1); 
            }
            numbers[i] = number; 
        }

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}

