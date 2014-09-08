using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class CountingWordInText
{
    static void Main(string[] args)
    {
        int count = 0;
        string word = Console.ReadLine();
        string text = Console.ReadLine();
        char[] separators = new char[] {' ', '.', '/', '"', '!', '?', '\t', '-', ',' };
        string[] tokens = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (string item in tokens)
        {
            if (item.Equals(word, StringComparison.CurrentCultureIgnoreCase))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

