using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class BeerTime
{
    static void Main(string[] args)
    {

        CultureInfo myCultureInfo = new CultureInfo("en-US");
        string inputDate = Console.ReadLine();
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");
        DateTime date;
        if (DateTime.TryParseExact(inputDate, "h:mm tt", myCultureInfo, DateTimeStyles.None, out date))
        {
            if (date < startTime && date >= endTime)
            {
                Console.WriteLine("non-beer time");
            }
            else
            {
                Console.WriteLine("beer time");
            }
        }
        else
        {
            Console.WriteLine( "invalid time");
        }       
    }
}

