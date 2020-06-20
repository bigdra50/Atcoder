using System.Linq;
using static System.Console;

namespace B
{
    internal class Program
    {
        private static (int a, int b) Initial;
        private static (int c, int d) Target;

        public static void Main(string[] args)
        {
            var input = ReadLine().Split(' ').Select(int.Parse).ToArray();

            Initial = (input[0], input[1]);
            Target = (input[2], input[3]);
            WriteLine(Solve());
        }

        static int Solve()
        {
            var mat = Initial;
        }

        static (int a, int b) AddColumn((int a, int b) mat)
        {
            return ()
        }

        static (int a, int b) AddRow((int a, int b) mat)
        {
            
        }
    }
}