using System;

class PrintSequence
{
    static void Main()
    {
        int membersCount = 10;
        for (int number = 2; number <= membersCount + 1; number++)
        {
            if (number % 2 == 0)
            {
                Console.Write(number);
            }
            else
            {
                Console.Write(number * (-1));
            }
            if (number != membersCount + 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

