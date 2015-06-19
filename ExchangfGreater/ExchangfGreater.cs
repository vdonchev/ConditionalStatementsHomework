using System;

class ExchangfGreater
{
    static void Main()
    {
        Console.WriteLine("Input two integer variables separated by a space:");
        string[] input = Console.ReadLine().Split();
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c;

        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }

        Console.WriteLine("{0} {1}", a, b);
    }
}