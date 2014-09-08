using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Divide
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Divided by 7 and 5? : " + (number != 0 && number % 5 == 0 && number % 7 == 0 ));
    }
}

