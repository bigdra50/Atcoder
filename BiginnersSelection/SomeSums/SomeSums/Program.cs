// https://atcoder.jp/contests/abs/tasks/abc083_b

using System.Linq;
using static System.Console;

namespace SomeSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sum = 0;

            for (var i = 1; i <= input[0]; i++)
            {
                var mod10000 = i % 10000;
                var mod1000 = mod10000 % 1000;
                var mod100 = mod1000 % 100;
                var checkValue = i / 10000 + mod10000/1000 + mod1000 / 100 + mod100 / 10 + mod100 % 10;
                sum += input[1] <= (checkValue) && (checkValue) <= input[2] ? i : 0;
            }

            WriteLine(sum);
        }
    }
}