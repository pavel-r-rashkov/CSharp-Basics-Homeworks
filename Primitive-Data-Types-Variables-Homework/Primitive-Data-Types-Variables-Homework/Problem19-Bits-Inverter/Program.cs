using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BitInverter
{
    static void Main()
    {
        // Reading input / declaring variables

        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        List<int> bytesList = new List<int>();
        List<int> positions = new List<int>();
 
        for (int q = 1; q <= n; q++)
        {
            bytesList.Add(int.Parse(Console.ReadLine()));
        }
        // Generating positions

        for (int pos = 1; pos < n * 8; pos += step)
        {
            positions.Add(pos);
        }
        // Changing bits at positions

        for (int i = 0; i < positions.Count; i++)
        {
            int bitsmoved;
            if (positions[i] % 8 == 0)
            {
                bitsmoved = 0;
            }
            else
            {
                bitsmoved = 8 - (positions[i] % 8);
            }
            int bitChange = 1 << bitsmoved;
            bytesList[(positions[i] - 1) / 8] = bytesList[(positions[i] - 1) / 8] ^ bitChange;
        }

        // Printing the results

        foreach (int v in bytesList)
        {
            Console.WriteLine(v);
        }
    }
}


