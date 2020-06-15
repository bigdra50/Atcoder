using System;
using System.Linq;
using static System.Console;

namespace A
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = ReadLine().Split(' ').Select(int.Parse).ToList();
            for (var i = 0; i < input.Count; i++)
            {
                if (input[i] != 0) continue;
                WriteLine(i + 1);
                break;
            }
        }
    }
}