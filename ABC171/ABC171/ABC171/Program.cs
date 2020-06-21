using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace ABC171
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sw = new StreamWriter(OpenStandardOutput()) {AutoFlush = false};
            SetOut(sw);
            SolveD();
            Out.Flush();
        }

        static void SolveA()
        {
            WriteLine(char.IsUpper(ReadLine().ToCharArray()[0]) ? "A" : "a");
        }

        static void SolveB()
        {
            var nk = ReadLine().Split(' ').Select(int.Parse);
            var k = nk.Last();
            var prices = ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToList();
            var sum = 0;
            for (var i = 0; i < k; i++)
            {
                sum += prices[i];
            }

            WriteLine(sum);
        }

        static void SolveC()
        {
            // わからん
            var n = long.Parse(ReadLine());
            const long maxN = 1000000000000001;
            const int ascii = 96;
            var nameCode = n + ascii;
            var cnt = 0;
            var res = "";
            Func<long, long> check = x =>
            {
                if (x <= 26) return x;
                return x - 26;
            };
            while (nameCode >= 1)
            {
                if (nameCode <= 26)
                {
                    res += (char) nameCode;
                    nameCode -= 26;
                }
                else
                {
                    var b = nameCode - 26;
                }
            }

            WriteLine(res);
        }

        static void SolveD()
        {
            ReadLine();
            var aList = ReadLine().Split(' ').Select(long.Parse);
            long sum = 0;
            var aDic = new Dictionary<long, long>();
            foreach (var a in aList)
            {
                if (!aDic.ContainsKey(a))
                {
                    aDic.Add(a, 1);
                }
                else
                {
                    aDic[a]++;
                }

                sum += a;
            }

            var q = int.Parse(ReadLine());
            for (var i = 0; i < q; i++)
            {
                var bc = ReadLine().Split(' ').Select(int.Parse);
                if (aDic.ContainsKey(bc.First()))
                {
                    sum -= bc.First() * aDic[bc.First()];
                    sum += bc.Last() * aDic[bc.First()];
                    var tmp = aDic[bc.First()];
                    aDic.Remove(bc.First());
                    if (!aDic.ContainsKey(bc.Last()))
                    {
                        aDic.Add(bc.Last(), tmp);
                    }
                    else
                    {
                        aDic[bc.Last()] += tmp;
                    }
                }

                WriteLine(sum);
            }
        }
    }
}