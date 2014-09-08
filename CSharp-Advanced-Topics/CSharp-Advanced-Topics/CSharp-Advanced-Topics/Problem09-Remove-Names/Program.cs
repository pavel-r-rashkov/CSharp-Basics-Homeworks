using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemoveNames
{
    static void Main(string[] args)
    {
        char[] separators = new char[]{' '};
        string firstNames = Console.ReadLine();
        List<string> firstList = new List<string>(firstNames.Split(separators));
        string secondNames = Console.ReadLine();
        List<string> secondList = new List<string>(secondNames.Split(separators));

        foreach (var name in secondList)
        {
            while (firstList.Contains(name))
            {
                firstList.Remove(name);
            }
        }

        foreach (var name in firstList)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}

