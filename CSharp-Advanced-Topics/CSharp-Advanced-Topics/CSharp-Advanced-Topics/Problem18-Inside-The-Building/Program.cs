using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InsideTheBuilding
{
    static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine());
        List<int> coordinates = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            coordinates.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < 9; i += 2)
        {
            int x = coordinates[i];
            int y = coordinates[i + 1];
            if (((y <= 4 * h && y >= h) && (x >= h && x <= 2 * h)) || ((y <= h && y >= 0) && (x >= 0 && x <= 3 * h)))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}

