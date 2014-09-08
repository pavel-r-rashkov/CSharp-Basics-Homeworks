using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntDoubleString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string ");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Console.WriteLine("Please enter an integer");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer + 1); break;
            case "2":
                Console.WriteLine("Please enter a double");
                double floatingPoint = double.Parse(Console.ReadLine());
                Console.WriteLine(floatingPoint + 1); break;
            case "3":
                Console.WriteLine("Please enter a string");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*"); break;
        }
    }
}

