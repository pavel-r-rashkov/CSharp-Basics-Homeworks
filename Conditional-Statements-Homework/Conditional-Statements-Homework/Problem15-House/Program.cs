using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class House
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char dot = '.';
        char asterisk = '*';
        Console.WriteLine(new string(dot, n / 2) + asterisk + new string(dot, n / 2));
        for (int outDots = n / 2 - 1, innerDots = 1 ; outDots >= 1; outDots--, innerDots += 2)
        {
            Console.WriteLine(new string(dot, outDots) + asterisk + new string(dot, innerDots) + asterisk + new string(dot, outDots));
        }
        Console.WriteLine(new string(asterisk, n));
        for (int i = 0; i < n / 2 - 1; i++)
		{
			 Console.WriteLine(new string(dot, n / 4) + asterisk + new string(dot, n - n / 4 - n / 4 - 2) + asterisk + new string(dot, n / 4));
		}
        Console.WriteLine(new string(dot, n / 4) + new string(asterisk, n -(n / 4 + n / 4)) + new string(dot, n / 4));
    }
}

