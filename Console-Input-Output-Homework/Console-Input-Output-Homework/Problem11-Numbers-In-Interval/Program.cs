using System;

class NumbersInInterval
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter start number ");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end number ");
        int end = int.Parse(Console.ReadLine());
        int p = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine(p);
    }
}

