using System;

class PrintLongSequence
{
    static void Main()
    {
        int membersCount = 1000;
        for (int number = 2; number <= membersCount + 1; number++)
        {
            if (number % 2 == 0)
            {
                Console.Write("{0, 6}", number);
            }
            else
            {
                Console.Write("{0, 6}", number * (-1));
            }
            Console.Write(", ");
        }
    }
}

