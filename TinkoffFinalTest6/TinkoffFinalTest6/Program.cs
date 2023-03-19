using System;
using System.Collections.Generic;

namespace TinkoffFinalTest6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Conditions = Console.ReadLine();

            Int32 NumOfStudents = Int32.Parse(Conditions.Split(' ')[0]);
            Int32 TotalScore = Int32.Parse(Conditions.Split(' ')[1]);

            List<Int32> MinScoresOfStudents = new List<Int32>();
            List<Int32> MaxScoresOfStudents = new List<Int32>();

            Int32 Res = 0;

            for (Int32 i = 0; i < NumOfStudents; i++)
            {
                Int32 MinTemp = Int32.Parse(Console.ReadLine());
                Int32 MaxTemp = Int32.Parse(Console.ReadLine());
                MinScoresOfStudents.Add(MinTemp);
                MaxScoresOfStudents.Add(MaxTemp);
                Res += MinTemp;
            }

            Int32 Ost = TotalScore - Res;

            MinScoresOfStudents.Sort();

            Int32 Con = Ost / (NumOfStudents / 2 + 1);

            for (int i = NumOfStudents / 2 + 1; i < NumOfStudents; i++)
            {
                if (MinScoresOfStudents[i] < MaxScoresOfStudents[i] && MaxScoresOfStudents[i] + Con < MaxScoresOfStudents[i])
                {
                    MinScoresOfStudents[i] =  MinScoresOfStudents[i] + Con;
                }
            }

            Console.WriteLine(MinScoresOfStudents[NumOfStudents / 2 + 1] + 1);
        }
    }
}
