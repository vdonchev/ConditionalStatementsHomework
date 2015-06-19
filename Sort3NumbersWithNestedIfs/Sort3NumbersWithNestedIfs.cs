using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.Write("{0} ", a);
                if (b > c)
                {
                    Console.WriteLine("{0} {1}", b, c);
                }
                else
                {

                    Console.WriteLine("{0} {1}", c, b);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c , a, b);
            }
        }
        else
        {
            if (b > c)
            {
                Console.Write("{0} ", b);
                if (c > a)
                {
                    Console.WriteLine("{0} {1}", c, a);
                }
                else
                {
                    Console.WriteLine("{0} {1}", a, c);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}