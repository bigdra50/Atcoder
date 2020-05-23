// https://atcoder.jp/contests/abc154/tasks/abc154_d

using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            var nk = ReadLine().Split(' ').Select(int.Parse).ToArray();
            var p = ReadLine().Split(' ').Select(double.Parse).ToArray();
            var expectedValues = GetExpected(p);
            var expectedCumulative = new double[expectedValues.Length + 1];
            expectedCumulative[0] = 0d;
            for (var i = 1; i < expectedCumulative.Length; i++)
            {
                expectedCumulative[i] = expectedValues[i - 1] + expectedCumulative[i - 1];
            }

            var max = 0d;
            for (var i = nk[1]; i < expectedCumulative.Length; i++)
            {
                max = Math.Max(max, expectedCumulative[i] - expectedCumulative[i - nk[1]]);
            }
            WriteLine($"{max:F12}");
        }

        static double[] GetExpected(double[] array)
        {
            var expectedValue = new double[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                expectedValue[i] = (1d + array[i]) / 2d;
            }

            return expectedValue;
        }
    }
}