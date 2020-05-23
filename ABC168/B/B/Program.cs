using System;
using static System.Console;

namespace B
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var k = int.Parse(ReadLine());
            var line = ReadLine();
            var result = "";
            if (line.Length <= k) result = line;
            else
            {
                result = $"{line.Substring(0, k)}...";
            }

            WriteLine(result);
        }
    }
}