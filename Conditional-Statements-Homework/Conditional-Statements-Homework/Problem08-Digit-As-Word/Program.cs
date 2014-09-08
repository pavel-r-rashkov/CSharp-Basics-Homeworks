using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DigitAsWord
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string word;
        switch (input)
        {
            case "1":
                word = "one"; break;
            case "2":
                word = "two"; break;
            case "3":
                word = "three"; break;
            case "4":
                word = "four"; break;
            case "5":
                word = "five"; break;
            case "6":
                word = "six"; break;
            case "7":
                word = "seven"; break;
            case "8":
                word = "eight"; break;
            case "9":
                word = "nine"; break;
            default:
                word = "not a digit"; break;
        }
        Console.WriteLine(word);
    }
}

