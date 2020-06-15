using System.Linq;
using static System.Console;

namespace Otoshidama
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = ReadLine().Split(' ').Select(int.Parse);
            var ans = Solve(input.First(), input.Last());
            WriteLine($"{ans.x} {ans.y} {ans.z}");
        }

        static (int x, int y, int z) Solve(int n, int total)
        {
            var ans = (-1, -1, -1);

            // n=x+y+z
            // z=n-x-y

            // total=10000*x+5000*y+1000*z
            // total = 10000*x+5000*y+1000*(n-x-y)
            //       = 9000*x+4000*y+1000*n
            // 4000*y=total - 1000*n-9000*x;
            // y = (total-1000*n-9000*x)/4000;
            for (var x = 0; x <= n; x++)
            {
                var y = (total - 1000 * n - 9000 * x) / 4000;
                var z = n - x - y;
                if (y < 0 || z < 0 || x + y + z > n||10000*x+5000*y+1000*z!=total)
                {
                    continue;
                }

                ans = (x, y, z);
            }

            return ans;
        }
    }
}