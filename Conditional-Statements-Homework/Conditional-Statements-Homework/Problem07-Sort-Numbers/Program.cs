using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortNumbers
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.Write(a + " ");
            if (b >= c)
            {
                Console.Write(b + " ");
                Console.Write(c);
            }
            else
            {
                Console.Write(c + " ");
                Console.Write(b);   
            }
        }
        else if (b >= a && b >= c)
        {
            Console.Write(b + " ");
            if (a >= c)
            {
                Console.Write(a + " ");
                Console.Write(c);
            }
            else
            {
                Console.Write(c + " ");
                Console.Write(a);
            }
        }
        else if (c >= b && c >= a)
        {
            Console.Write(c + " ");
            if (b >= a)
            {
                Console.Write(b + " ");
                Console.Write(a);
            }
            else
            {
                Console.Write(a + " ");
                Console.Write(b);
            }
        }
        Console.WriteLine();
    }
}

