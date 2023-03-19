using System;
using System.Linq;
using System.Text;

namespace TinkoffFinalTest3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 StringLength = Int32.Parse(Console.ReadLine());

            string s = Console.ReadLine();

            char[] ValidChars = new char[4] {'a','b','c','d'};

            if (!(s.Contains(ValidChars[0]) && s.Contains(ValidChars[1]) &&
                s.Contains(ValidChars[2]) && s.Contains(ValidChars[3])) || s.Length < 4)
            {
                Console.WriteLine("-1");
                return;
            }

            Int32 minLength = s.Length;

            for (Int32 i = 0; i < s.Length - 3; i++)
            {
                StringBuilder subStr = new StringBuilder();
                for (Int32 j = i; j < s.Length; j++)
                {
                    subStr.Append(s[j]);
                    if (subStr.ToString().Contains("a") && subStr.ToString().Contains("b") &&
                            subStr.ToString().Contains("c") && subStr.ToString().Contains("d"))
                    {

                        if (minLength > subStr.Length)
                            minLength = subStr.Length;
                        break;

                    }
                }
            }

            Console.WriteLine(minLength);
        }
    }
}
