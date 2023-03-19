using System;

namespace TinkoffFinalTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Conditions = Console.ReadLine();

            double n = double.Parse(Conditions.Split(' ')[0]);
            double m = double.Parse(Conditions.Split(' ')[1]);
            double k = double.Parse(Conditions.Split(' ')[2]);

            Console.WriteLine(Convert.ToInt32(Math.Ceiling((n*k) / m)));
        }
    }
}
