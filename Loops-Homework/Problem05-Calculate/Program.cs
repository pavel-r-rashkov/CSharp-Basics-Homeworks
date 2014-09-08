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
        Console.WriteLine("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        double addend = 1;
        for (int i = 1; i <= n; i++)
        {
            addend *= ((double)i / x);
            sum += addend;
        }
        Console.WriteLine("{0:F5}", sum);
    }
}

