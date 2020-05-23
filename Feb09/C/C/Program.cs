// https://atcoder.jp/contests/abc154/tasks/abc154_c
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(ReadLine());
            var input = ReadLine().Split(' ').Select(int.Parse);
            if (input.Count() != input.Distinct().Count())
            {
                WriteLine("NO");
            }
            else
            {
                WriteLine("YES");
            }
            
        }
    }
}