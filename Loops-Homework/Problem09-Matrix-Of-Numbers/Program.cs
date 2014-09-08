using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int startNumber = 1; startNumber <= n; startNumber++)
        {
            for (int number = startNumber, count = 1; count <= n; number++, count ++)
            {
                Console.Write(number.ToString().PadLeft(3));
            }
            Console.WriteLine();
        }
    }
}

