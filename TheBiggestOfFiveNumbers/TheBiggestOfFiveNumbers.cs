using System;
using System.Runtime.InteropServices.ComTypes;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("biggest: {0}", a);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine("biggest: {0}", b);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine("biggest: {0}", b);
        }
        else if (d > a && d > c && d > b && d > e)
        {
            Console.WriteLine("biggest: {0}", b);
        }
        else
        {
            Console.WriteLine("biggest: {0}", e);
        }
    }
}