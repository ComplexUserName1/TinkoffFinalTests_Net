using System;

namespace TinkoffFinalTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Increase = true;
            bool Decrease = true;

            string HumansHeights = Console.ReadLine();
            string[] ArrayHumansHeights = HumansHeights.Split(' ');

            Int32 PreviousHeight = Int32.Parse(ArrayHumansHeights[0]);
            Int32 Height = 0;

            for (Int32 i = 0; i < ArrayHumansHeights.Length; i++)
            {
                Height = Int32.Parse(ArrayHumansHeights[i]);

                if (PreviousHeight < Height)
                    Decrease = false;

                if (PreviousHeight > Height)
                    Increase = false;

                PreviousHeight = Height;
            }

            if (Increase || Decrease)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
