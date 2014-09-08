using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StudentCables
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());       
        List<int> centimeters = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int lenght = int.Parse(Console.ReadLine());
            string unit = Console.ReadLine();

            if (unit == "meters")
            {
                lenght *= 100;
            }
            if (lenght >= 20)
            {
                centimeters.Add(lenght);
            }
        }

        int trim = (centimeters.Count - 1) * 3;
        int totalLenght = 0;

        foreach (var cable in centimeters)
        {
            totalLenght += cable;
        }

        totalLenght -= trim;

        Console.WriteLine(totalLenght / 504);
        Console.WriteLine(totalLenght % 504);
    }
}

