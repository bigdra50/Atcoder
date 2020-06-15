using System.Linq;
using static System.Console;

namespace B
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = ReadLine().Split(' ').Select(double.Parse);
            var x = input.First();
            var y = input.Last();
            var a = 2.0 * x - y * .5;
            var b = -x + y * .5;
            if (a - (int) a > .0 || b - (int) b > .0)
            {
                WriteLine("No");
                return;
            }

            if (x >= y)
            {
                WriteLine("No");
                return;
            }

            if (a < 0 || b < 0)
            {
                WriteLine("No");
                return;
            }

            if (!((int) (a + b) == (int) x && (int) (2 * a) + (int) (4 * b) == (int) y))
            {
                WriteLine("No");
                return;
            }


            WriteLine("Yes");
        }
    }
}