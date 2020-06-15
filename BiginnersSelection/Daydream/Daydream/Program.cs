using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace Daydream
{
    internal class Program
    {
        private static Func<string, bool> judge;

        public static void Main(string[] args)
        {
            judge = target =>
            {
                var wip = Regex.Replace(target, "eraser", ".");
                wip = Regex.Replace(wip, "erase", ".");
                wip = Regex.Replace(wip, "dreamer", ".");
                wip = Regex.Replace(wip, "dream", ".");
                wip = Regex.Replace(wip, @"\.", "");
                return wip == "";
            };
            //judge = target => Regex.IsMatch(target, "(dream|dreamer|erase|eraser)*");
            WriteLine(judge(ReadLine()) ? "YES" : "NO");
        }
    }
}