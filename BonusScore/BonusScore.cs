using System;
using System.Runtime.InteropServices.ComTypes;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Input your score:");

        int score;

        if (int.TryParse(Console.ReadLine(), out score))
        {
            if (score < 4)
            {
                Console.WriteLine(score * 10);
            }
            else if (score < 7)
            {
                Console.WriteLine(score * 100);
            }
            else if(score < 10)
            {
                Console.WriteLine(score * 1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! (Must be Integer number.)");
        }
    }
}