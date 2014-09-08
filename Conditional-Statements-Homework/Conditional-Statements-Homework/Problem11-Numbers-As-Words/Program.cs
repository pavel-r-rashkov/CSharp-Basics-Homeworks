using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumbersAsWords
{
    static void Main(string[] args)
    {
        int number;
        while (int.TryParse(Console.ReadLine(), out number) == false || number < 0 || number > 999)
        {
            Console.WriteLine("enter number ");
        }

        int ones = number % 10;
        int tens = (number / 10) % 10;
        int hundreds = number / 100;

        PrintNumber(hundreds, tens, ones);
    }
    static void PrintNumber(int hundreds, int tens, int ones)
    {
        PrintHundreds(hundreds, tens, ones);
        PrintTens(tens, ones);
        if (tens != 1)
        {
            PrintOnes(hundreds, tens, ones);            
        }
        Console.WriteLine();
    }
    static void PrintOnes(int hundreds, int tens, int ones)
    {
        switch (ones)
        {
            case 0:
                if (tens == 0 && hundreds == 0)
                {
                    Console.WriteLine("zero");
                }
                break;
            case 1:
                Console.Write("one"); break;
            case 2:
                Console.Write("two"); break;
            case 3:
                Console.Write("three"); break;
            case 4:
                Console.Write("four"); break;
            case 5:
                Console.Write("five"); break;
            case 6:
                Console.Write("six"); break;
            case 7:
                Console.Write("seven"); break;
            case 8:
                Console.Write("eight"); break;
            case 9:
                Console.Write("nine"); break;       
        }    
    }
    static void PrintTens(int tens, int ones)
    {
        switch (tens)
        {
            case 1:
                switch (ones)
                {
                    case 0:
                        Console.Write("ten"); break;
                    case 1:
                        Console.Write("eleven"); break;
                    case 2:
                        Console.Write("twelve"); break;
                    case 3:
                        Console.Write("thirteen"); break;
                    case 4:
                        Console.Write("fourteen"); break;
                    case 5:
                        Console.Write("fifteen"); break;
                    case 6:
                        Console.Write("sixteen"); break;
                    case 7:
                        Console.Write("seventeen"); break;
                    case 8:
                        Console.Write("eighteen"); break;
                    case 9:
                        Console.Write("nineteen"); break;
                } break;
            case 2:
                Console.Write("twenty "); break;
            case 3:
                Console.Write("thirty "); break;
            case 4:
                Console.Write("forty "); break;
            case 5:
                Console.Write("fifty "); break;
            case 6:
                Console.Write("sixty "); break;
            case 7:
                Console.Write("seventy "); break;
            case 8:
                Console.Write("eighty "); break;
            case 9:
                Console.Write("ninety "); break;
        }     
    }
    static void PrintHundreds(int hundreds, int tens, int ones)
    {
        if (hundreds != 0)
        {
            PrintOnes(1, 1, hundreds);
            Console.Write(" hundred ");
        }
        if (!(tens == 0 && ones == 0) && hundreds != 0)
        {
            Console.Write("and ");
        }
    }
}

