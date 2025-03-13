using System;
using System.Linq;

public class Calculator
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica nie może być pusta");

        int suma = 0;
        foreach (int num in numbers)
        {
            suma += num;
        }
        return (double)suma / numbers.Length;
    }
}

