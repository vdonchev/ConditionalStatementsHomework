using System;

class BitKiller
{
    static void Main()
    {
        int bytesNum = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int exportByte = 0;
        int filled = 8;
        int index = 0;

        for (int i = 0; i < bytesNum; i++)
        {
            int currentByte = int.Parse(Console.ReadLine());

            for (int j = 7; j >= 0; j--)
            {
                if (!((index % step == 1) || (step == 1 & index > 0)))
                {
                    int currentBit = currentByte >> j & 1;
                    exportByte <<= 1;
                    exportByte = exportByte | currentBit;
                    filled--;
                    if (filled == 0)
                    {
                        Console.WriteLine(exportByte);
                        exportByte = 0;
                        filled = 8;
                    }
                }

                index++;
            }
        }

        if (filled < 8)
        {
            exportByte <<= filled;
            Console.WriteLine(exportByte);
        }
    }
}