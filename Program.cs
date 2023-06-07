using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int number = 73824658;

        Console.WriteLine("Исходное число: " + number);

        int[] digits = GetDigits(number);
        Array.Sort(digits);

        int result = GetNumber(digits);

        Console.WriteLine("Минимальное число: " + result);

        Console.ReadLine();
    }

    static int[] GetDigits(int number)
    {
        List<int> digits = new List<int>();//чтоб не париться с размерностью массива

        while (number > 0)
        {
            int digit = number % 10;
            digits.Add(digit);
            number /= 10;
        }

        return digits.ToArray();
    }

    static int GetNumber(int[] digits)
    {
        int result = 0;
        int mult = 1;

        for (int i = 0; i < digits.Length; i++)
        {
            result += digits[i] * mult;
            mult *= 10;
        }

        return -1 * result;
    }
}