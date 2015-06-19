using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Insert three numbers on next 3 lines:");
        double[] nums = new double[3];
        nums[0] = double.Parse(Console.ReadLine());
        nums[1] = double.Parse(Console.ReadLine());
        nums[2] = double.Parse(Console.ReadLine());

        if (nums[0] == 0 || nums[1] == 0 || nums[2] == 0)
        {
            Console.WriteLine(0);
            return;
        }

        int minus = 0;
        foreach (var num in nums)
        {
            if (num < 0)
            {
                minus++;
            }
        }


        if (minus == 0 || minus == 2)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }

    }
}