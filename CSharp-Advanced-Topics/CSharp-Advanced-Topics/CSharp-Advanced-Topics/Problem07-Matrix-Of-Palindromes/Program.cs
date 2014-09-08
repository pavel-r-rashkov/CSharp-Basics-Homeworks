using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixPalindromes
{
    static void Main(string[] args)
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        
        for (int i = 97; i < 97 + r; i++)
        {
            for (int j = i; j < i + c; j++)
            {
                Console.Write("" + (char)i + (char)j + (char)i + " ");
            }
            Console.WriteLine();
        }
    }  
}

