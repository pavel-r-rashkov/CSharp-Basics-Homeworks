using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpiralMatrix
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        if (n % 2 == 1)
        {
            matrix[n / 2, n / 2] = n * n;
        }
        int number = 1;

        for (int i = 0, j = 0, max = n; i < n / 2 ; i++, j++, max -= 2)
        {
            int startIndexX = i;
            int startIndexY = j;
            for (int index = 0; index < max; index++)
            {
                matrix[startIndexY, startIndexX + index] = number;
                number++;                          
            }
            startIndexX += max - 1;

            for (int index = 1; index < max; index++)
            {
                matrix[startIndexY + index, startIndexX] = number;
                number++;
            }
            startIndexY += max - 1;

            for (int index = 1; index < max; index++)
            {
                matrix[startIndexY, startIndexX - index] = number;
                number++;
            }
            startIndexX -= max - 1;

            for (int index = 1; index < max - 1; index++)
            {
                matrix[startIndexY - index, startIndexX] = number;
                number++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }
}

