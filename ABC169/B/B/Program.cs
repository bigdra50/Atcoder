using System;
using System.Linq;
using static System.Console;

namespace B
{
    internal class Program
    {
        private static readonly long MaxValue = 1000000000000000000;

        public static void Main(string[] args)
        {
            var n = ReadLine();
            var input = ReadLine().Split(' ').Select(long.Parse);
            if (input.Contains(0))
            {
                WriteLine(0);
                return;
            }

            // r*c <= MaxValue がオーバーフローしないかチェックしたいが, 
            // そのままだとオーバーフローした結果を比較してしまうのでc<=MaxValue/cでチェック
            var result = input.Aggregate((r, c) => c <= MaxValue / r ? r * c : -1);
            WriteLine(result > 0 ? result : -1);
        }
    }
}