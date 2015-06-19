using System;

class Triangle
{
    static void Main()
    {
        // inputs
        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());

        // get the sides
        double sideA = Math.Sqrt(Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2));
        double sideB = Math.Sqrt(Math.Pow(cX - bX, 2) + Math.Pow(cY - bY, 2));
        double sideC = Math.Sqrt(Math.Pow(aX - cX, 2) + Math.Pow(aY - cY, 2));

        // check if a triangle can be formed and output
        if ((sideA + sideB) > sideC && (sideB + sideC) > sideA && (sideA + sideC) > sideB)
        {
            // calculate the perimeter
            double halfPerimeter = (sideA + sideB + sideC) / 2d;

            // calculate the area
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", sideA);
        }
    }
}