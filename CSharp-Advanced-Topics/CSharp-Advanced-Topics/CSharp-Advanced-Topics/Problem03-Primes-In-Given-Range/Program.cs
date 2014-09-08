using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimesInRange
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter start number: ");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end number: ");
        int end = int.Parse(Console.ReadLine());

        PrintList(FindPrimesInRange(start, end));
    }
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> listOfPrimes = new List<int>();
        for (int number = startNum; number <= endNum; number++)
        {
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);
            bool isPrime = true;
            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            for (int j = divider; j <= maxDivider; j++)
            {
                if (number % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                listOfPrimes.Add(number);
            }
        }
        return listOfPrimes;
    }
    static void PrintList(List<int> list)
    {
        foreach (var num in list)
        {
            Console.Write(num + " ");
        }
        if (list.Count == 0)
        {
            Console.WriteLine("(empty list)");
        }
    }
}

