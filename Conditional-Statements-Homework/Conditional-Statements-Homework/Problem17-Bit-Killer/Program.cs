using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitKiller
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        List<int> bytesList = new List<int>();
        List<int> positions = new List<int>();
        string result = string.Empty;

        for (int q = 1; q <= n; q++)
        {
            bytesList.Add(int.Parse(Console.ReadLine()));
        }

        for (int pos = 1; pos < n * 8; pos += step)
        {
            positions.Add(pos);
        }

        foreach (var number in bytesList)
        {            
            string num = Convert.ToString(number, 2);
            int zeros = 8 - num.Length % 8;
            if (zeros == 8)
            {
                zeros = 0;
            }
            for (int i = 0; i < zeros; i++)
            {
                num = num.Insert(0, "0");
            }
            result += num;
        }

        for (int i = 0; i < positions.Count; i++)
        {
            result = result.Remove(positions[i], 1);
            for (int j = 0; j < positions.Count; j++)
            {
                positions[j] -= 1;
            }
        }

        int zerosResult = 8 - (result.Length % 8);
        if (zerosResult == 8)
        {
            zerosResult = 0;
        }
        for (int i = 0; i < zerosResult; i++)
        {
            result += "0";
        }
        for (int startIndex = 0; startIndex < result.Length; startIndex += 8)
        {
            Console.WriteLine(Convert.ToInt64(result.Substring(startIndex, 8), 2));
        }
    }
}

