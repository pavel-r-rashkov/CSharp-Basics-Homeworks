using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JoinLists
{
    static void Main(string[] args)
    {
        char[] separators = new char[] { ' ' };
        string firstNumbers = Console.ReadLine();
        List<string> firstList = new List<string>(firstNumbers.Split(separators));
        string secondNumbers = Console.ReadLine();
        List<string> secondList = new List<string>(secondNumbers.Split(separators));

        List<string> joinedList = new List<string>();
        joinedList.AddRange(firstList);
        joinedList.AddRange(secondList);

        List<string> removedDuplicates = new List<string>(joinedList.Distinct());

        List<int> numbers = new List<int>();
        foreach (var number in removedDuplicates)
        {
            numbers.Add(int.Parse(number));
        }
        numbers.Sort();

        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}

