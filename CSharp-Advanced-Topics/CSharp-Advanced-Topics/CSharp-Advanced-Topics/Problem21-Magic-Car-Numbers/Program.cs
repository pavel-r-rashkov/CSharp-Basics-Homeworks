using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicCarNumbers
{
    public static int weight = int.Parse(Console.ReadLine());
    public static List<char> chars = new List<char> { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
    public static int[] weights = new int[] { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
    public static int count = 0;

    static void Main(string[] args)
    {

        for (int a = 0; a < 10; a++)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string carNumber1 = "" + a + a + a + a + chars[i] + chars[j];
                    IsMagicNumber(carNumber1);
                    for (int b = 0; b < 10; b++)
                    {
                        if (b == a)
                        {
                            continue;
                        }                     
                        string carNumber2 = "" + a + b + b + b + chars[i] + chars[j];
                        IsMagicNumber(carNumber2);
                        string carNumber3 = "" + a + a + a + b + chars[i] + chars[j];
                        IsMagicNumber(carNumber3);
                        string carNumber4 = "" + a + a + b + b + chars[i] + chars[j];
                        IsMagicNumber(carNumber4);
                        string carNumber5 = "" + a + b + a + b + chars[i] + chars[j];
                        IsMagicNumber(carNumber5);
                        string carNumber6 = "" + a + b + b + a + chars[i] + chars[j];
                        IsMagicNumber(carNumber6);
                    }
                }
            }       
        }
        Console.WriteLine(count);
    }

    public static void IsMagicNumber(string number)
    {
        int numberWeight = 40;
        for (int i = 0; i < 4; i++)
        {
            numberWeight += int.Parse(number[i].ToString());
        }
        for (int i = 4; i < 6; i++)
        {
            numberWeight += weights[chars.IndexOf(number[i])];
        }

        if (numberWeight == weight)
        {
            count++;
        }
    }
}

