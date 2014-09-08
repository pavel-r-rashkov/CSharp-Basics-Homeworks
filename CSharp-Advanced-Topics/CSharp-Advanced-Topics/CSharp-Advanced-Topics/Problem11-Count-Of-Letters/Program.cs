using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountOfLetters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] separators = new char[] {' '};
        string[] letters = input.Split(separators);
        IDictionary<string, int> lettersCount = new SortedDictionary<string, int>();

        foreach (var letter in letters)
        {
            int count;
            if (!lettersCount.TryGetValue(letter, out count))
            {
                count = 0;
            }
            lettersCount[letter] = count + 1;
        }

        foreach (var item in lettersCount)
        {
            Console.WriteLine("{0} -> {1}",item.Key, item.Value); 
        }
    }
}

