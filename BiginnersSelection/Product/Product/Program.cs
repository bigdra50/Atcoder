using System.IO;
using System.Linq;
using static System.Console;

namespace Product
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            WriteLine(ReadLine().Split(' ').Select(int.Parse).Aggregate((now, next) => now * next) % 2 == 0 ? "Even" : "Odd");
        }
    }
}