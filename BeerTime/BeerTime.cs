using System;

class BeerTime
{
    static void Main()
    {
        DateTime currentTime = DateTime.Parse(Console.ReadLine());

        DateTime startBeerTime = DateTime.Parse("1:00 PM");
        DateTime endBeerTime = DateTime.Parse("3:00 PM");

        if (currentTime >= startBeerTime && currentTime <= endBeerTime )
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}