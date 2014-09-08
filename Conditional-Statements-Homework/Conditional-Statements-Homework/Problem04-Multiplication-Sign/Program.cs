using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MultiplicationSign
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        int sign = Math.Sign(a) * Math.Sign(b) * Math.Sign(c);
        
        switch (sign)
        {
            case -1:
                Console.WriteLine("-"); break;
            case 1:
                Console.WriteLine("+"); break;
            case 0:
                Console.WriteLine("0"); break;
        }

    }
}

