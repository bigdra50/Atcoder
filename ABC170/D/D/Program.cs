using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace D
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(ReadLine());
            var input = ReadLine().Split(' ').Select(int.Parse);

            WriteLine(Solve(n, input.ToList()));
        }

        static int Solve(int n, List<int> input)
        {
            Func<int, int, bool> condition = (a, b) => a % b != 0;
            var cnt = 0;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (i == j) continue;
                    if (!condition(input[i], input[j])) break;
                    if (j == n - 1 && condition(input[i], input[j])) cnt++;
                }
            }

            return cnt;
        }
    }
}