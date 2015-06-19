using System;

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("Input 5 ints separated by space:");
        string[] input = Console.ReadLine().Split();
        int[] ints = Array.ConvertAll(input, int.Parse);
        int subsets = 0;
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            if (ints[i] == 0)
            {
                Console.WriteLine("{0} = 0", ints[i]);
                subsets++;
            }
            for (int j = (i + 1); j < 5; j++)
            {
                sum = ints[i] + ints[j];
                if (CheckSum(sum))
                {
                    Console.WriteLine("{0} + {1} = 0", ints[i], ints[j]);
                    subsets++;
                }
                for (int k = (j + 1); k < 5; k++)
                {
                    sum = ints[i] + ints[j] + ints[k];
                    if (CheckSum(sum))
                    {
                        Console.WriteLine("{0} + {1} + {2} = 0", ints[i], ints[j], ints[k]);
                        subsets++;
                    }
                    for (int l = (k + 1); l < 5; l++)
                    {
                        sum = ints[i] + ints[j] + ints[k] + ints[l];
                        if (CheckSum(sum))
                        {
                            Console.WriteLine("{0} + {1} + {2} + {3} = 0", ints[i], ints[j], ints[k], ints[l]);
                            subsets++;
                        }
                        for (int m = (l + 1); m < 5; m++)
                        {
                            sum = ints[i] + ints[j] + ints[k] + ints[l] + ints[m];
                            if (CheckSum(sum))
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", ints[i], ints[j], ints[k], ints[l], ints[m]);
                                subsets++;
                            }
                            sum = 0;
                        }
                    }
                }
            }
        }
        if (subsets == 0)
        {
            Console.WriteLine("no zero subset");
        }
        else
        {
            Console.WriteLine("Total 0 subsets: {0}", subsets);
        }
    }

    private static bool CheckSum(int sum)
    {
        if (sum == 0)
        {
            return true;
        }
        return false;
    }
}