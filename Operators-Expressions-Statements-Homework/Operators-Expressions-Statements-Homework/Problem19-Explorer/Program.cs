using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Explorer
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char diamond = '*';
        Console.WriteLine(new string('-', n / 2) + diamond + new string('-', n / 2));
        for (int outer = n / 2 - 1, inner = 1; outer >= 0; outer--, inner += 2)
        {
            Console.WriteLine(new string('-', outer) + diamond + new string('-', inner) + diamond + new string('-', outer));
        }
        for (int outer = 1, inner = n - 4; outer <= n / 2 - 1; outer++, inner -= 2)
        {
            Console.WriteLine(new string('-', outer) + diamond + new string('-', inner) + diamond + new string('-', outer));
        }
        Console.WriteLine(new string('-', n / 2) + diamond + new string('-', n / 2));
    }
}

