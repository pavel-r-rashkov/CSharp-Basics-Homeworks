using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitsUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        List<int> bytesList = new List<int>();
        List<int> positions = new List<int>();
            
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
            int bitsmoved = 7 - (positions[i]%8);
            int bitChange = 1 << bitsmoved;
            bytesList[positions[i] / 8] = bytesList[positions[i] / 8] | bitChange; 
        }
        foreach (int v in bytesList)
        {
            Console.WriteLine(v);
        }
    }
}


