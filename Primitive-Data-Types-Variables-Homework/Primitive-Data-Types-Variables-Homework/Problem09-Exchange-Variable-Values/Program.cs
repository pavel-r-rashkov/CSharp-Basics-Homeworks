using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before exchange: a = {0}, b = {1}", a, b);
        int oldA = a;
        a = b;
        b = oldA;
        Console.WriteLine("After exchange: a = {0}, b = {1}", a, b);
    }
}

