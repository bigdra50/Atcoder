// https://atcoder.jp/contests/abs/tasks/abc087_b
using static System.Console;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            var num500 = int.Parse(ReadLine());
            var num100 = int.Parse(ReadLine());
            var num50 = int.Parse(ReadLine());
            var x = int.Parse(ReadLine());
            var cnt = 0;

            for (var i = 0; i <= num500; i++)
            {
                for (var j = 0; j <= num100; j++)
                {
                    for (var k = 0; k <= num50; k++)
                    {
                        if (i * 500 + j * 100 + k * 50 == x)
                        {
                            cnt++;
                        }
                    }
                }
            }

            WriteLine(cnt);
        }
    }
}