using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace KagamiMochi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = GetInput();
            WriteLine(Solve(input));
        }

        static List<int> GetInput()
        {
            var n = int.Parse(ReadLine());
            var input = new List<int>(n);
            for (var i = 0; i < input.Capacity; i++)
            {
                input.Add(int.Parse(ReadLine()));
            }

            return input;
        }

        static int Solve(List<int> rads)
        {
            return rads.Distinct().Count();
        }
    }
}