using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortingNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> listOfNumbers = new List<int>();
        for (int i = 0; i < n; i++)
        {
            listOfNumbers.Add(int.Parse(Console.ReadLine()));
        }

        listOfNumbers.Sort();
        Console.WriteLine("Sorted: ");
        foreach (var num in listOfNumbers)
        {
            Console.WriteLine(num);
        }
    }
}

