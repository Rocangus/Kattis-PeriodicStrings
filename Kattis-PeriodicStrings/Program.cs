using System;

namespace Kattis_PeriodicStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int period = FindPeriod(str);
            Console.WriteLine(period);
        }

        private static int FindPeriod(string str)
        {
            for (int k = 1; k < str.Length; k++)
            {
                int i = 0;
                string period = str.Substring(0, k);
                while (str.Substring(i).StartsWith(period))
                {
                    period = RotateStringRight(period);
                    i += period.Length;
                    if (i > str.Length) break;
                    if (i == str.Length) return k;
                }
            }
            return str.Length;
        }

        private static string RotateStringRight (string arg)
        {
            char[] newChars = new char[arg.Length];
            newChars[0] = arg[arg.Length - 1];
            for (int i = 0; i < arg.Length - 1; i++)
            {
                newChars[i + 1] = arg[i];
            }
            return new string(newChars);
        }
    }
}
