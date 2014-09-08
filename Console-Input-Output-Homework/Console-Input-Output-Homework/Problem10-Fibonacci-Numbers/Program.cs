using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        if (n == 1)
        {
            Console.WriteLine(a);
        }
        else if (n == 2)
        {
            Console.WriteLine(a + " " + b);
        }
        else
        {
            Console.Write(a + " " + b);
            for (int i = 3; i <= n; i++)
            {
                int oldA = a;
                a = b;
                b = oldA + b;
                Console.Write(" " + b);
            }
            Console.WriteLine();
        }
    }
}

