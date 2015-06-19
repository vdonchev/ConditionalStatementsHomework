using System;

class NumberAsWords
{
    private static void Main()
    {
        int digit = int.Parse(Console.ReadLine());

        if (digit < 10)
        {
            Console.WriteLine(OneTwelve(digit));
        }
        else if (digit < 100)
        {
            double decimals = (digit / 10) % 10;
            double ones = (digit / 1) % 10;
            if (decimals >= 2)
            {
                if (ones == 0)
                {
                    Console.WriteLine("{0}", Twenty((int) decimals));
                }
                else
                {
                    Console.WriteLine("{0} {1}", Twenty((int) decimals), OneTwelve((int) ones).ToLower());
                }
            }
            else
            {
                Console.WriteLine("{0}", OneTwelve(digit % 100));
            }
        }
        else
        {
            double hundreds = (digit / 100) % 10;
            double decimals = (digit / 10) % 10;
            double ones = (digit / 1) % 10;
            if (decimals >= 2)
            {
                if (ones == 0)
                {
                    Console.WriteLine("{0} hundred and {1}", OneTwelve((int) hundreds), Twenty((int) decimals).ToLower());
                }
                else
                {
                    Console.WriteLine("{0} hundred and {1} {2}", OneTwelve((int) hundreds),
                        Twenty((int) decimals).ToLower(), OneTwelve((int) ones).ToLower());
                }
            }
            else
            {
                if (decimals == 0 && ones == 0)
                {
                    Console.WriteLine("{0} hundred", OneTwelve((int) hundreds));
                }
                else
                {
                    Console.WriteLine("{0} hundred and {1}", OneTwelve((int) hundreds),
                        OneTwelve((int) (digit % 100)).ToLower());
                }
            }
        }
    }

    private static string OneTwelve(int digit)
    {
        string output = string.Empty;
        switch (digit)
        {
            case 0: output = "Zero"; break;
            case 1: output = "One"; break;
            case 2: output = "Two"; break;
            case 3: output = "Three"; break;
            case 4: output = "Four"; break;
            case 5: output = "Five"; break;
            case 6: output = "Six"; break;
            case 7: output = "Seven"; break;
            case 8: output = "Eight"; break;
            case 9: output = "Nine"; break;
            case 10: output = "Ten"; break;
            case 11: output = "Eleven"; break;
            case 12: output = "Twelve"; break;
            case 13: output = "Thirteen"; break;
            case 14: output = "Forteen"; break;
            case 15: output = "Fifteen"; break;
            case 16: output = "Sixteen"; break;
            case 17: output = "Seventeen"; break;
            case 18: output = "Eighteen"; break;
            case 19: output = "Nineteen"; break;
        }

        return output;
    }

    private static string Twenty(int digit)
    {
        string output = string.Empty;
        switch (digit)
        {
            case 2: output = "Twenty"; break;
            case 3: output = "Thirty"; break;
            case 4: output = "Forty"; break;
            case 5: output = "Fifty"; break;
            case 6: output = "Sixty"; break;
            case 7: output = "Seventy"; break;
            case 8: output = "Eighty"; break;
            case 9: output = "Ninety"; break;
        }

        return output;
    }
}