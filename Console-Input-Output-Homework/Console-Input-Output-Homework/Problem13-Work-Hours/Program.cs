using System;

class WorkHours
{
    static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int efficientHours = (int)(0.9 * d * 12 * (p / 100.0));
        int difference = efficientHours - h;
        Console.WriteLine(difference >= 0 ? "Yes" : "No");
        Console.WriteLine(difference);
    }
}