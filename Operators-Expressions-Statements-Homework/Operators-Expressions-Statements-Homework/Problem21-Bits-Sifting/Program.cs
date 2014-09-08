using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitsSifting
{
    static void Main(string[] args)
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int numberOfSieves = int.Parse(Console.ReadLine());
        ulong[] sieves = new ulong[numberOfSieves];

        for (int i = 0; i < numberOfSieves; i++)
        {
            sieves[i] = ulong.Parse(Console.ReadLine());
        }

        int numberLenght = (int)Math.Log(number, 2) + 1;
        int countOfBits = 0;

        for (int index = 0; index < numberLenght; index++)
        {
            bool falling = true;
            ulong bitValue = (number >> index) & 1;
            if (bitValue == 1)
            {
                foreach (var sieve in sieves)
                {
                    if (((sieve >> index) & 1) == 1)
                    {
                        falling = false;
                        break;
                    }
                }
                if (falling)
                {
                    countOfBits++;
                }
            }
        }
        Console.WriteLine(countOfBits);
    }
}

