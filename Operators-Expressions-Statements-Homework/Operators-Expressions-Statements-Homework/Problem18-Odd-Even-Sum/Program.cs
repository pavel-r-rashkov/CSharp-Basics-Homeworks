using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddEvenSum
{
    static void Main(string[] args)
    {
        int oddSum = 0;
        int evenSum = 0;
        int n = int.Parse(Console.ReadLine());
        for (int c = 1; c <= (2 * n); c++)
        {
            if (c % 2 == 0)
            {
                evenSum += int.Parse(Console.ReadLine());
            }
            else if (c % 2 == 1)
            {
                oddSum += int.Parse(Console.ReadLine());
            }
        }
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
        }
    }
}

