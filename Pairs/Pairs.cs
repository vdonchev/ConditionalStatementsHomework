using System;

class Pairs
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();

        int sum = int.Parse(inputs[0]) + int.Parse(inputs[1]);
        int maxDiff = 0;
        bool allEqual = true;

        for (int i = 2; i < inputs.Length; i += 2)
        {
            int currentSum = int.Parse(inputs[i]) + int.Parse(inputs[i + 1]);
            if (currentSum != sum)
            {
                allEqual = false;
                maxDiff = Math.Max(maxDiff, Math.Abs(currentSum - sum));
            }
            sum = currentSum;
        }

        if (allEqual)
        {
            Console.WriteLine("Yes, value={0}", sum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}