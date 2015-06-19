using System;

class DigitAsWord
{
    static void Main()
    {
        Console.WriteLine("Enter a digit (0-9):");

        int digit;
        string result = string.Empty;
        if (int.TryParse(Console.ReadLine(), out digit))
        {
            switch (digit)
            {
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "tree";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eigth";
                    break;
                case 9:
                    result = "nine";
                    break;
                default:
                    result = "not a digit";
                    break;
            }

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("not a digit");
        }
    }
}