using System;
using System.Collections.Generic;

namespace TinkoffFinalTest4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 ArraySize = Int32.Parse(Console.ReadLine());

            string[] ArrayNumbers = Console.ReadLine().Split(' ');

            Int32[] ArrayOfNumbers = new Int32[ArraySize];
            for (Int32 i = 0; i < ArrayNumbers.Length; i ++)
            {
                ArrayOfNumbers[i] = Int32.Parse(ArrayNumbers[i]);
            }

            Int32[] Frequency = new Int32[100000];

            Int32 MaxPrefLength = 0;

            for (Int32 i = 0; i < ArrayOfNumbers.Length; i++)
            {

                Frequency[ArrayOfNumbers[i]] += 1;

                List<Int32> SortedPosValues = new List<Int32>();
                foreach (Int32 index in Frequency)
                    if (index != 0)
                        SortedPosValues.Add(index);

                SortedPosValues.Sort();

                if (SortedPosValues.Count == 1 || (SortedPosValues[0] == SortedPosValues[SortedPosValues.Count - 2] &&
                    SortedPosValues[SortedPosValues.Count - 1] - SortedPosValues[SortedPosValues.Count - 2] == 1) ||
                   (SortedPosValues[0] == 1 && SortedPosValues[1] == SortedPosValues[SortedPosValues.Count - 1]))
                    MaxPrefLength = i;
            }

            Console.WriteLine(MaxPrefLength + 1);
        }
    }
}
