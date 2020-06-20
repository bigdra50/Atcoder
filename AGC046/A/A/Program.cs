using System;
using static System.Console;

namespace A
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var angle = int.Parse(ReadLine());
            WriteLine(Solve(angle));
        }

        private static double Eps = .000001;

        static int Solve(int rot)
        {
            (double, double y, double currentDegree) pos = (0, 0, rot);
            var p = Move(pos, rot);
            var k = 1;

            while (!(Math.Abs(p.x) <= Eps && Math.Abs(p.y) <= Eps))
            {
                p = Move(p, rot);
                k++;
            }

            return k;
        }

        static (double x, double y, double currentDegree) Move((double x, double y, double currentDegree) p, int rot)
        {
            var movedPos = (p.x, p.y, p.currentDegree);
            var rad = Math.PI * p.currentDegree / 180.0;
            movedPos.x += Math.Cos(rad);
            movedPos.y += Math.Sin(rad);
            movedPos.currentDegree += rot;
            return movedPos;
        }
    }
}