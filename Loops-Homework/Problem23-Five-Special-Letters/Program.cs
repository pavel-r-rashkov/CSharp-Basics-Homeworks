using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FiveSpecialLetters
{
    public static List<char> chars = new List<char> { 'a', 'b', 'c', 'd', 'e' };
    public static List<int> weights = new List<int> { 5, -12, 47, 7, -32 };
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        bool answer = false;

        for (char a = 'a'; a <= 'e'; a++)
        {
            for (char b = 'a'; b <= 'e'; b++)
            {
                for (char c = 'a'; c <= 'e'; c++)
                {
                    for (char d = 'a'; d <= 'e'; d++)
                    {
                        for (char e = 'a'; e <= 'e'; e++)
                        {
                            string specialLetters = a.ToString() + b.ToString() + c.ToString() + d.ToString() + e.ToString();
                            if (IsAnswer(CalculateWeight(specialLetters), start, end))
                            {
                                answer = true;
                                Console.Write(specialLetters + " ");
                            }
                        }
                    }
                }
            }
        }

        if (!answer)
        {
            Console.WriteLine("No");
        }
    }
    static int CalculateWeight(string str)
    {
        int weight = 0;
        List<char> letters = new List<char>();
        foreach (var letter in str)
        {
		    if (!letters.Contains(letter))
	        {
		        letters.Add(letter);
	        }
        }
        for (int i = 0; i < letters.Count; i++)
		{
            weight += (i + 1) * weights[chars.IndexOf(letters[i])];
		}
        return weight;
    }
    static bool IsAnswer(int weight, int start, int end)
    {
        bool answer = weight >= start && weight <= end;
        return answer;
    }
}

