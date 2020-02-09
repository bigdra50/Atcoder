// https://atcoder.jp/contests/abc154/tasks/abc154_b
using System.Text.RegularExpressions;
using static System.Console;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Regex.Replace(ReadLine(), ".", "x"));
        }
    }
}