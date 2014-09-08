using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class ExamSchedule
{
    static void Main(string[] args)
    {
        
        int hour = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        string ampm = Console.ReadLine();
        int examHours = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());
        
        string date = "1/1/2010 " + hour + ":" + minutes + ":00 " + ampm;
        DateTime startTime = Convert.ToDateTime(date, CultureInfo.InvariantCulture);

        DateTime endTime = startTime.AddHours(examHours);
        endTime = endTime.AddMinutes(examMinutes);

        Console.WriteLine(endTime.ToString("hh:mm:tt", CultureInfo.InvariantCulture));
    }
}

