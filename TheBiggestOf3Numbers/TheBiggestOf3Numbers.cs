using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Inset three numbers on next 3 lines:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("Biggest: {0}", a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("Biggest: {0}", b);
        }
        else
        {
            Console.WriteLine("Biggest: {0}", c);
        }
    }
}