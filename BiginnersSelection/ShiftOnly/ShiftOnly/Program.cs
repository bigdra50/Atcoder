// https://atcoder.jp/contests/abs/tasks/abc081_b

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ShiftOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(ReadLine());
            var arr = ReadLine().Split(' ').Select(int.Parse);

            var cnt = 0;
            while (arr.All(i => i % 2 == 0))
            {
                arr = arr.Select(a => a / 2);
                cnt++;
            }

            WriteLine(cnt);
        }
    }
}