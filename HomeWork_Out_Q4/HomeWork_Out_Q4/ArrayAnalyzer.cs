using System;
using System.Runtime.InteropServices;
using System.Xml.Schema;

class ArrayAnalyzer
{

    public static void Main()
    {
        int Max = 0;
        double average;

        Console.Write("Please Enter Number: ");
        int[] numbers = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Please Enter Number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        AnalyzeArray(numbers, ref Max, out average);
        Console.WriteLine($"average is {average} \t Max is {Max}");
    }

    public static void AnalyzeArray(int[] array, ref int max, out double average)
    {
        average = 0.0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            average += (double)array[i] / array.Length;
        }
    }
}


