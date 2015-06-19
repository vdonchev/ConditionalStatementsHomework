using System;

class MagicDates
{
    static void Main()
    {
        int dateSum = 0;
        int found = 0;
        
        int year1 = int.Parse(Console.ReadLine());
        int year2 = int.Parse(Console.ReadLine());

        DateTime startDate = new DateTime(year1, 01, 01);
        DateTime endDate = new DateTime(year2, 12, 31);

        int magicSum = int.Parse(Console.ReadLine());

        for (DateTime d = startDate; d <= endDate; d = d.AddDays(1))
        {
            int[] dateNums = new int[8];

            dateNums[0] = (d.Day / 10) % 10;
            dateNums[1] = (d.Day / 1) % 10;
            dateNums[2] = (d.Month / 10) % 10;
            dateNums[3] = (d.Month / 1) % 10;
            dateNums[4] = (d.Year / 1000) % 10;
            dateNums[5] = (d.Year / 100) % 10;
            dateNums[6] = (d.Year / 10) % 10;
            dateNums[7] = (d.Year / 1) % 10;

            for (int i = 0; i < 8; i++)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    dateSum += dateNums[i] * dateNums[j];
                }
            }

            if (dateSum == magicSum)
            {
                found++;
                Console.WriteLine("{0:D2}-{1:D2}-{2:D2}", d.Day, d.Month, d.Year);
            }
            dateSum = 0;
        }

        if (found == 0)
        {
            Console.WriteLine("No");
        }
    }
}