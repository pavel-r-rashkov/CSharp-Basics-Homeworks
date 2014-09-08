using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestWordInText
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        char[] separators = new char[] {' ', '\t', ',', '!', '?', '.', '-', '"', '/'};
        string[] tokens = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int longestWord = 0;
        List<string> answer = new List<string>();

        foreach (var word in tokens)
        {
            if (word.Length > longestWord)
            {
                answer.Clear();
                answer.Add(word);
                longestWord = word.Length;
            }
            else if (word.Length == longestWord && !answer.Contains(word))
            {
                answer.Add(word);
            }
        }

        foreach (var word in answer)
        {
            Console.WriteLine(word);
        }
    }
}

