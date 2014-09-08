using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CatchTheBits
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
        for (int i = 0; i < positions.Count; i++)
        {
            int bitsMoved = 7 - (positions[i] % 8);
            result += ((bytesList[positions[i] / 8] >> bitsMoved) & 1);        
        }
        int zeros = 8 - result.Length % 8 ;
        if (zeros == 8)
        {
            zeros = 0;
        }
        for (int i = 0; i < zeros ; i++)
        {
            result += 0;
        }
        for (int startIndex = 0; startIndex < result.Length; startIndex += 8)
        {
            string num = result.Substring(startIndex, 8);
            Console.WriteLine(Convert.ToInt64(num, 2));
        }
    }
}


