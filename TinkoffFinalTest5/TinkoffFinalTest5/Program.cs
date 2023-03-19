using System;
using System.Collections.Generic;

namespace TinkoffFinalTest5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 NumOfDays = Int32.Parse(Console.ReadLine());

            string[] BalanceChange = Console.ReadLine().Split(' ');
            Int32[] ArrayBalanceChange = new Int32[NumOfDays];

            for (Int32 i = 0; i < NumOfDays; i ++)
            {
                ArrayBalanceChange[i] = Int32.Parse(BalanceChange[i]);
            }

            HashSet<Int32[]> ReasonableSegments = new HashSet<Int32[]>();

            int Sum = 0;
            for (int i = 0; i < NumOfDays; i++)
            {
                Sum = 0;
                for (int j = i; j < NumOfDays; j++)
                {
                    Sum += ArrayBalanceChange[j];
                    if (Sum == 0)
                    {
                        ReasonableSegments.Add(new int[] { i, j });
                    }
                }
            }

            Sum = 0;
            for (int i = 0; i < NumOfDays; i++)
            {
                for (int j = i; j < NumOfDays; j++)
                {
                    foreach(int[] ReasonableSegment in ReasonableSegments)
                    {
                        if (i <= ReasonableSegment[0] && j >= ReasonableSegment[1])
                        {
                            Sum++;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(Sum);
        }
    }
}
