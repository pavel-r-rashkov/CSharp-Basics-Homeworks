using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateSum
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        long sum = 1;

        for (int i = 1, j = k + 1; i <= n - k; i++, j++)
        {
            sum *= j;
            sum /= i;
        }
        Console.WriteLine(sum);
    }
}

