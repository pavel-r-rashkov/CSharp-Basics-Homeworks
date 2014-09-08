using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

class Triangle
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());

        double a = Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2));
        double b = Math.Sqrt(Math.Pow(cX - bX, 2) + Math.Pow(cY - bY, 2));
        double c = Math.Sqrt(Math.Pow(aX - cX, 2) + Math.Pow(aY - cY, 2));

        bool formingTriangle = a + b > c && b + c > a && a + c > b;
        double p = (a + b + c) / 2.0;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        if (formingTriangle)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", a);
        }   
    }
}

