using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class JoroFootballPlayer
{
    static void Main(string[] args)
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int normal = 52 - h;
        double res = h + (1.0 / 2) * p + (2.0 / 3) * normal;
        if (year == "t")
        {
            res += 3;
        }
        Console.WriteLine((int)res);
    }
}

