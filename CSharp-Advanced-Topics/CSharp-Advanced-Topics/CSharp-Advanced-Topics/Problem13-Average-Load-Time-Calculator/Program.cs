using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class AverageLoadTimeCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of inputs: ");

        int numberOfInputs = int.Parse(Console.ReadLine());
        char[] separators = new char[] { ' ' };
        Dictionary<string, int> count = new Dictionary<string, int>();
        Dictionary<string, double> times = new Dictionary<string, double>();

        for (int i = 0; i < numberOfInputs; i++ )
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(separators);

            int occurrences;
            if (!count.TryGetValue(tokens[tokens.Length - 2], out occurrences))
            {
                occurrences = 0;
            }
            count[tokens[tokens.Length - 2]] = occurrences + 1;

            double time;
            if (!times.TryGetValue(tokens[tokens.Length - 2], out time))
            {
                time = 0;
            }
            times[tokens[tokens.Length - 2]] = time + double.Parse(tokens[tokens.Length - 1], CultureInfo.InvariantCulture);
        }

        Console.WriteLine("Average load time: ");

        foreach (var item in count)
        {
            Console.WriteLine("{0} -> {1}", item.Key, (times[item.Key] / item.Value));
        } 
    }
}

