using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicStrings
{
    static void Main(string[] args)
    {
        int diff = int.Parse(Console.ReadLine());
        if (diff > 16)
        {
            Console.WriteLine("No");
            return;
        }
        List<string> magicStrings = new List<string>();
        List<int> weights = new List<int>();

        for (int a = 1; a <= 4; a++)
        {
            for (int b = 1; b <= 4; b++)
            {
                for (int c = 1; c <= 4; c++)
                {
                    for (int d = 1; d <= 4; d++)
                    {
                        weights.Add(CalculateWeight(a, b, c, d));
                        magicStrings.Add(a.ToString() + b.ToString() + c.ToString() + d.ToString());
                    }
                }
            }
        }
        for (int i = 0; i < 256; i++)
        {
            for (int j = 0; j < 256; j++)
            {
                if (Math.Abs(weights[i] - weights[j]) == diff)
                {
                    string result = magicStrings[i] + magicStrings[j];
                    result = result.Replace('1', 'k');
                    result = result.Replace('2', 'n');
                    result = result.Replace('3', 'p');
                    result = result.Replace('4', 's');
                    Console.WriteLine(result);
                }             
            }
        }
    }
    static int CalculateWeight(int a, int b, int c, int d)
    {
        int sum = 0;
        switch (a)
        {
            case 1:
                sum += 1; break;
            case 2:
                sum += 4; break;
            case 3:
                sum += 5; break;
            case 4:
                sum += 3; break;
        }
        switch (b)
        {
            case 1:
                sum += 1; break;
            case 2:
                sum += 4; break;
            case 3:
                sum += 5; break;
            case 4:
                sum += 3; break;
        }
        switch (c)
        {
            case 1:
                sum += 1; break;
            case 2:
                sum += 4; break;
            case 3:
                sum += 5; break;
            case 4:
                sum += 3; break;
        }
        switch (d)
        {
            case 1:
                sum += 1; break;
            case 2:
                sum += 4; break;
            case 3:
                sum += 5; break;
            case 4:
                sum += 3; break;
        }
        return sum;
    }
}

