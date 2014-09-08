using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitRoller
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        string num = Convert.ToString(n, 2);
        StringBuilder number = new StringBuilder(num);
        int numLenght = number.Length;

        for (int i = 0; i < 19 - numLenght; i++)
        {
            number.Insert(0, '0');
        }

        char frozen = number[number.Length - f - 1];
        number.Remove(number.Length - f - 1, 1);

        for (int i = 0; i < r; i++)
        {
            char lastDigit = number[number.Length - 1];
            number.Remove(number.Length - 1, 1);
            number.Insert(0, lastDigit);
        }

        number.Insert(number.Length - f, frozen);
        Console.WriteLine(Convert.ToInt32(number.ToString(), 2));
    }
}

