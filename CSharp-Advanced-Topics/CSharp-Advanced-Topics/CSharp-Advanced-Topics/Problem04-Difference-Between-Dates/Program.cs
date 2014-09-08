using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main(string[] args)
    {
        string format = "d.MM.yyyy";
        CultureInfo provider = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter start date: ");
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), format, provider);
        Console.WriteLine("Enter end date: ");
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), format, provider);
        double days = (endDate - startDate).TotalDays;
        Console.WriteLine(days);
    }
}

