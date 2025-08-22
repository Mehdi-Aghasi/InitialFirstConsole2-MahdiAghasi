using System;
class Statistics
{
    public static void Main()
    {
        int num1, num2, num3;
        Console.Write("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Initial numbers: num1={num1}, num2={num2}");
        AnalyzeNumbers(num1, ref num2, out num3);
        Console.WriteLine($"After AnalyzeNumbers: num1={num1}, num2={num2}, num3={num3}");

    }
    public static void AnalyzeNumbers(int a, ref int b, out int c)
    {
        c = a + b;
        b *= b;
        Console.WriteLine($"Number a is {a}");
    }
}

