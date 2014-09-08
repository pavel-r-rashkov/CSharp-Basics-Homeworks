using System;
using System.Globalization;

class AgeAfterYears
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday: ");
        DateTime myBirthDay = DateTime.Parse(Console.ReadLine());
        DateTime currentDate = DateTime.Today;
        int age = currentDate.Year - myBirthDay.Year;
        if (currentDate < myBirthDay.AddYears(age)) age--;
        Console.WriteLine("You are {0} years old", age);
        Console.WriteLine("After 10 years you will be {0} years old. ", age + 10);
    }
}

