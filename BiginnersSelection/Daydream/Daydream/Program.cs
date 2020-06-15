using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace Daydream
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Func<string, bool> judge = target =>
            {
                var wip = Regex.Replace(target, "eraser","");
                wip = Regex.Replace(wip, "erase", "");
                wip = Regex.Replace(wip, "dreamer", "");
                wip = Regex.Replace(wip, "dream", "");
                return wip == "";
            };
            WriteLine(judge(ReadLine()) ? "YES" : "NO");
        }
    }
}