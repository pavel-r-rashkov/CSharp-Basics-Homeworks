using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitFlipper
{
    static void Main(string[] args)
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 61; i >= 0; i--)
        {
            if (counter > 0)
            {
                counter--;
                continue;
            }

            ulong threeBits = (number >> i) & 7;

            if (threeBits == 0 || threeBits == 7)
            {
                number = number ^ ((ulong)7 << i);
                counter = 2;
            }
        }

        Console.WriteLine(number);

        // Variant II
        
        //ulong number = ulong.Parse(Console.ReadLine());
        //StringBuilder num = new StringBuilder(Convert.ToString((long)number, 2)); 
        //int counter = 0;
        //int lenght = num.Length;

        //for (int i = 0; i < 64 - lenght; i++)
        //{
        //    num.Insert(0, '0');
        //}

        //for (int i = 0; i < 62; i++)
        //{
        //    if (counter > 0)
        //    {
        //        counter--;
        //        continue;
        //    }

        //    string threeBit = num.ToString(i, 3);
        //    if (threeBit == "000")
        //    {
        //        num[i] = '1';
        //        num[i + 1] = '1';
        //        num[i + 2] = '1';
        //        counter = 2;
        //    }
        //    else if (threeBit == "111")
        //    {
        //        num[i] = '0';
        //        num[i + 1] = '0';
        //        num[i + 2] = '0';
        //        counter = 2;
        //    }
        //}

        //Console.WriteLine(Convert.ToUInt64(num.ToString(), 2)); 
    }
}

