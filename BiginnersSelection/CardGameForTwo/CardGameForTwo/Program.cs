using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace CardGameForTwo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(ReadLine());
            var input = ReadLine().Split(' ').Select(int.Parse);
            WriteLine(Solve(n, input));
        }

        static int Solve(int n, IEnumerable<int> input)
        {
            var descend = input.OrderByDescending(x => x);
            var alice = descend.Where((_, i) => i % 2 == 0).Sum();
            var bob = descend.Where((_, i) => i % 2 != 0).Sum();
            return alice - bob;
        }
    }
}