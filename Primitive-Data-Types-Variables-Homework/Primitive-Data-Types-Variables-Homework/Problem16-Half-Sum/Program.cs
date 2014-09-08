using System;

class HalfSum
{
    static void Main()
    {
        int firstHalf = 0;
        int secondHalf = 0;
        int n = int.Parse(Console.ReadLine());
        for (int c = 1; c <= n; c++)
        {
            firstHalf += int.Parse(Console.ReadLine());
        }
        for (int c = 1; c <= n; c++)
        {
            secondHalf += int.Parse(Console.ReadLine());
        }
        if (firstHalf == secondHalf)
        {
            Console.WriteLine("Yes, sum={0}", firstHalf);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(firstHalf - secondHalf));
        }
    }
}

