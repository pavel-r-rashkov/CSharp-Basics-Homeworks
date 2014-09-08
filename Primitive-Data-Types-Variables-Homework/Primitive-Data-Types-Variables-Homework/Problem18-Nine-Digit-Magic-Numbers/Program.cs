using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MagicNumbers
{
    static int sum = int.Parse(Console.ReadLine());
    static int diff = int.Parse(Console.ReadLine());
    static void Main()
    {
        List<string> magicNumbers = new List<string>();
        for (int abc = 111 ; abc <= 777; abc++)
        {
            int def = abc + diff;
            int ghi = def + diff;
            if (AreAllowedDigits(abc) && AreAllowedDigits(def) && AreAllowedDigits(ghi) && IsMagicNumber(abc, def, ghi))
            {
                string magicNum = abc.ToString() + def.ToString() + ghi.ToString();
                magicNumbers.Add(magicNum);
            }   
        }

        if (magicNumbers.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            foreach (string number in magicNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
    static bool IsMagicNumber(int a, int b, int c)
    {
        if (c - b == diff && b - a == diff && a <= b && b <= c && SumOfDigits(a, b, c) == sum)
        {
            return true;
        }
        return false;
    }
    static int SumOfDigits(int a, int b, int c)
    {
        int sumDigits = 0;
        sumDigits += (a % 10) + ((a % 100) / 10) + (a / 100);
        sumDigits += (b % 10) + ((b % 100) / 10) + (b / 100);
        sumDigits += (c % 10) + ((c % 100) / 10) + (c / 100);
        return sumDigits;
    }
    static bool AreAllowedDigits(int number)
    {
        string str = number.ToString();
        if (str.Contains('0') || str.Contains('8') || str.Contains('9'))
        {
            return false;
        }
        return true;
    }
}

