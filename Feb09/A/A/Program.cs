// https://atcoder.jp/contests/abc154/tasks/abc154_a
using System;
using System.IO;
using System.Linq;
using static System.Console;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new StreamWriter(OpenStandardOutput()){AutoFlush = false};
            SetOut(sw);
            var st = ReadLine().Split(' ');
            var ab = ReadLine().Split(' ').Select(int.Parse).ToArray();

            var u = ReadLine();
            if (u == st.First())
            {
                //ab.First()--;
                ab[0]--;
            }
            else
            {
                ab[1]--;
            }
            WriteLine($"{ab[0]} {ab[1]}");
            
            Out.Flush();
        }
    }
}