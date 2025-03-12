using System;

public class Zadanie4
{
    public static int FindMaxValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica nie może być pusta");

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
                max = num;
        }
        return max;
    }
}

