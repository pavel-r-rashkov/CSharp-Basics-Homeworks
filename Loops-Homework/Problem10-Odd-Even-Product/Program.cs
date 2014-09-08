using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddEvenProduct
{
    static void Main(string[] args)
    {
        char[] separators = new char[] { ' ' };
        string input = Console.ReadLine();
        string[] numbers = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        long oddProduct = 1;
        long evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes\nproduct = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", oddProduct, evenProduct);
        }
    }
}

