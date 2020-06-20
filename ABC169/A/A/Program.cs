using System.Linq;
using static System.Console;
namespace A
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var line = ReadLine().Split(' ').Select(int.Parse).ToArray();
            WriteLine(line[0]*line[1]);
        }
    }
}