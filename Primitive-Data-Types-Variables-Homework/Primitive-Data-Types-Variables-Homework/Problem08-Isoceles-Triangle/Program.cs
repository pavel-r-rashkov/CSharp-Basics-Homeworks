using System;

class IsocelesTriangle
{
    static void Main()
    {
        // You should change the font of the console and then restart it
        char isocele = '\u00a9'; 
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("{0,4}", isocele);
        Console.WriteLine("{0,5}", isocele + " " + isocele);
        Console.WriteLine("{0,6}", isocele + "   " + isocele);
        Console.WriteLine("{0,7}", isocele + " " + isocele + " " + isocele + " " + isocele);      
    }
}

