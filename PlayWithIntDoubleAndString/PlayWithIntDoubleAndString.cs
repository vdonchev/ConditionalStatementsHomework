using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter a int: ");
                int theInt = int.Parse(Console.ReadLine());
                Console.WriteLine(++theInt);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double theDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(++theDouble);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string theString = Console.ReadLine();
                Console.WriteLine(theString + "*");
                break;
        }
    }
}