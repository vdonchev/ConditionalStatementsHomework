using System;

class House
{
    static void Main()
    {
        // input
        int size = int.Parse(Console.ReadLine());

        int outter = (size / 2) - 1;
        int inner = 1;
        char innerChar = '.';

        Console.WriteLine("{0}*{0}", new string('.', size / 2));
        for (int i = 0; i < size / 2; i++)
        {
            if (i == (size / 2) - 1)
            {
                innerChar = '*';
            }

            Console.WriteLine("{0}*{1}*{0}", new string('.', outter), new string(innerChar, inner));
            outter--;
            inner += 2;
        }

        outter = size / 4;
        inner = size - (outter + outter) - 2;
        innerChar = '.';

        for (int i = 0; i < size / 2; i++)
        {
            if (i == ((size / 2) - 1))
            {
                innerChar = '*';
            }

            Console.WriteLine("{0}*{1}*{0}", new string('.', outter), new string(innerChar, inner));
        }
    }
}