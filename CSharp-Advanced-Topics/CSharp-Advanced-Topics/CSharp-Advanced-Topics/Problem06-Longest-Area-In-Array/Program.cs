using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestAreaInArray
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] elements = new string[n + 1];
        elements[n] = null;
        for (int i = 0; i < n; i++)
        {
            elements[i] = Console.ReadLine();
        }

        string element = elements[0];
        string maxElement = elements[0];
        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i] == element)
            {
                currentCount++;
            }
            else if(currentCount > maxCount)
            {
                maxCount = currentCount;
                maxElement = element;
                element = elements[i];
                currentCount = 1;
            }
            else
            {
                element = elements[i];
                currentCount = 1;
            }
        }
        Console.WriteLine(maxCount);
        for (int i = 0; i < maxCount; i++)
        {
            Console.WriteLine(maxElement);
        }
    }
}

