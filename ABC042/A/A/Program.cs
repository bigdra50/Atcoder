using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace A
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SolveB();
        }

        static void SolveA()
        {
            var input = ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x);
            var searchTarget = new List<int> {5, 5, 7}.OrderBy(x => x);
            WriteLine(input.SequenceEqual(searchTarget) ? "YES" : "NO");
        }

        static void SolveB()
        {
            var nl = ReadLine().Split(' ').Select(int.Parse);
            var s = new List<string>();
            for (var i = 0; i < nl.First(); i++)
            {
                s.Add(ReadLine());
            }

            var sorted = s.OrderBy(x => x).Aggregate((line, part) => line + part);
            WriteLine(sorted);
        }
    }
}