using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Rectangle's perimeter = " + 2 * (width + height));
        Console.WriteLine("Rectangle's area = " + width * height);
    }
}

