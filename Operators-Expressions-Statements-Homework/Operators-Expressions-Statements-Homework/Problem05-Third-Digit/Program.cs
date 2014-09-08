using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ThirdDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Third digit is 7? : " + (((number / 100) % 10) == 7));
    }
}

