using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class ExtractURLs
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        Regex linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        foreach (Match url in linkParser.Matches(text))
        {
            Console.WriteLine(url);
        }
    }
}

