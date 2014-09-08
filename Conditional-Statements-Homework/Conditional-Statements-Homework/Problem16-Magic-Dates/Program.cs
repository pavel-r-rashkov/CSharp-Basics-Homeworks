using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicDates
{
    static void Main(string[] args)
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());
        DateTime startDate = new DateTime(startYear, 1, 1);
        DateTime endDate = new DateTime(endYear, 12, 31);
        DateTime currentDate = startDate;
        bool noMagicDates = true;

        while (currentDate <= endDate)
        {
            if (CalculateWeight(currentDate.Year, currentDate.Month, currentDate.Day) == magicWeight)
            {
                noMagicDates = false;
                Console.WriteLine("{0:00}-{1:00}-{2}", currentDate.Day, currentDate.Month, currentDate.Year);
            }
            currentDate = currentDate.AddDays(1);
        }
        if (noMagicDates)
        {
            Console.WriteLine("No");
        } 
    }
    static int CalculateWeight(int year, int month, int day)
    {
        List<int> digits = new List<int>();
        for (int i = 0; i < 4; i++)
        {
            digits.Add(year % 10);
            year /= 10;
        }
        for (int i = 0; i < 2; i++)
        {
            digits.Add(month % 10);
            month /= 10;
        }
        for (int i = 0; i < 2; i++)
        {
            digits.Add(day % 10);
            day /= 10;
        }
        int weight = 0;
        for (int i = 0; i < digits.Count; i++)
        {
            for (int j = i + 1; j < digits.Count; j++)
            {
                weight += digits[i] * digits[j];
            }
        }
        return weight;
    }
}

