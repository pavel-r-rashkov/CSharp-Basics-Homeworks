using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MinMaxAverage
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        int count = 0;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < minValue)
            {
                minValue = number;
            }
            if (number > maxValue)
            {
                maxValue = number;
            }
            count++;
            sum += number;
        }
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}", minValue, maxValue, sum, sum / (double)count );
    }
}

