using System;

class NullValues
{
    static void Main()
    {
        int? testInt = null;
        double? testDouble = null;
        Console.WriteLine("Null integer = {0} ",testInt);
        Console.WriteLine("Null double = {0} ", testDouble);
        Console.WriteLine("Null integer + some number = {0}",testInt + 5);
        Console.WriteLine("Null double + some number = {0}", testDouble + 5);
        Console.WriteLine("Null integer + null = {0}", testInt + null);
        Console.WriteLine("Null double + null = {0}", testDouble + null);
    }
}

