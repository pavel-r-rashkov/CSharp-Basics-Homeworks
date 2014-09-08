using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Volleyball
{
    static void Main(string[] args)
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int normal = 48 - h;
        double res = h + (2.0 / 3) * p + (3.0 / 4) * normal;
        if (year == "leap")
        {
            res = 1.15 * res;
        }
        Console.WriteLine((int)res);
    }
}

