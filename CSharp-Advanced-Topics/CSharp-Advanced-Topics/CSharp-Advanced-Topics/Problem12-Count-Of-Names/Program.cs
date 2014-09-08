using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountOfNames
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] separators = new char[] { ' ' };
        string[] names = input.Split(separators);
        SortedDictionary<string, int> namesCount = new SortedDictionary<string, int>();

        foreach (var name in names)
        {
            int count;
            if (!namesCount.TryGetValue(name, out count))
            {
                count = 0;
            }
            namesCount[name] = count + 1;
        }

        foreach (var item in namesCount)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}

