using System;
using System.Globalization;
using System.Threading;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        Console.WriteLine("Enter integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter floating point number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter floating point number: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("|{0,-10:X}|{1}|", a, Convert.ToString(a, 2).PadLeft(10, '0'));      
        Console.Write(b.ToString().IndexOf('.') > 0 ? string.Format("{0,10:F2}|", b) : string.Format("{0,10}|", b));
        Console.Write(c.ToString().IndexOf('.') > 0 ? string.Format("{0,-10:F3}|", c) : string.Format("{0,-10}|", c));

        Console.WriteLine();
    }
}

