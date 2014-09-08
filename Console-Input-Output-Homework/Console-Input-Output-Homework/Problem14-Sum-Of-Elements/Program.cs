using System;

class SumOfElements
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char token = ' ';
        string[] numbers = input.Split(token);
        long minimumDifference = long.MaxValue;
        long sum = 0;
        bool result = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            long number = long.Parse(numbers[i]);
            for (int n = 0; n < i; n++)
            {
                sum += long.Parse(numbers[n]);
            }
            for (int m = i + 1; m < numbers.Length ; m++)
            {
                sum += long.Parse(numbers[m]);
            }
            if (sum == number)
            {
                Console.WriteLine("Yes, sum=" + sum);
                result = true;
                break;
            }
            else if (Math.Abs(sum - number) < minimumDifference)
            {
                minimumDifference = Math.Abs(sum - number);
            }
            sum = 0;
        }
        if (result == false)
        {
            Console.WriteLine("No, diff=" + minimumDifference);
        }
    }
}

