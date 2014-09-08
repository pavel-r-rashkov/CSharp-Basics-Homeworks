using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgrammerDNA
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string startingChar = Console.ReadLine();
        char ch = startingChar[0];
        List<char> chars = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G'};
        int indexChar = chars.IndexOf(ch);

        for (int i = 0; i < n; i++)
        {
            if (i % 7 == 0 || i % 7 == 6)
            {
                Console.WriteLine(new string('.', 3) + chars[indexChar] + new string('.', 3));
                indexChar = (indexChar + 1) % 7;
            }
            else if (i % 7 == 1 || i % 7 == 5)
            {
                Console.WriteLine(new string('.', 2) + chars[indexChar] + chars[(indexChar + 1) % 7] + chars[(indexChar + 2) % 7] + new string('.', 2));
                indexChar = (indexChar + 3) % 7;
            }
            else if (i % 7 == 2 || i % 7 == 4)
            {
                Console.WriteLine("." + chars[indexChar] + chars[(indexChar + 1) % 7] + chars[(indexChar + 2) % 7] + chars[(indexChar + 3) % 7] + chars[(indexChar + 4) % 7] + ".");
                indexChar = (indexChar + 5) % 7;
            }
            else if (i % 7 == 3)
            {
                Console.WriteLine("" + chars[indexChar] + chars[(indexChar + 1) % 7] + chars[(indexChar + 2) % 7] + chars[(indexChar + 3) % 7] + chars[(indexChar + 4) % 7] + chars[(indexChar + 5) % 7] + chars[(indexChar + 6) % 7]);
                indexChar = (indexChar + 7) % 7;
            }
        }
    }
}

