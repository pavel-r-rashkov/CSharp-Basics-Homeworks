using System;

class ComparingFloats
{
    static void Main()
    {
        //float eps = 0.000001f;
        //bool equal = false;
        //Console.WriteLine("Enter number A: ");
        //double numberA = double.Parse(Console.ReadLine());
        //Console.WriteLine("Enter number B: ");
        //double numberB = double.Parse(Console.ReadLine());
        //if (Math.Abs(numberA - numberB) < eps)
        //{
        //    equal = true;
        //}
        //Console.WriteLine("A and B are equal? : " + equal);
        decimal test = 0.1m;
        decimal a = 0.2m;
        decimal b = 0.3m;
        Console.WriteLine("{0}", b - a == test);
    }
}

