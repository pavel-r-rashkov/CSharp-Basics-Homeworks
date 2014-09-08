using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 1;
        for (int k = 2; k <= n; k++)
        {
            sum *= (n + k) / (double)k;
        }
        Console.WriteLine("{0:F0}", sum);
    }
}
