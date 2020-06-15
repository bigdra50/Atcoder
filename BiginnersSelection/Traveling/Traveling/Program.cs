using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Traveling
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(ReadLine());
            var plan = new List<(int t, int x, int y)>(n + 1);
            plan.Add((0, 0, 0));
            for (var i = 0; i < plan.Capacity-1; i++)
            {
                var line = ReadLine().Split(' ').Select(int.Parse).ToList();
                plan.Add((line[0], line[1], line[2]));
            }

            Func<List<(int t, int x, int y)>, bool> judge = p =>
            {
                for (var i = 1; i < p.Count; i++)
                {
                    if (!CanArrive(p[i - 1], p[i])) return false;
                }

                return true;
            };

            WriteLine(judge(plan) ? "Yes" : "No");
        }

        static bool CanArrive((int t, int x, int y) currentState, (int t, int x, int y) nextState)
        {
            // timeの間にcurrentからnextへ移動できるか
            var time = nextState.t - currentState.t;
            var currentPos = (currentState.x, currentState.y);
            var nextPos = (nextState.x, nextState.y);
            var manhattanDist = ManhattanDistance(nextPos, currentPos);
            if (manhattanDist > time) return false;
            return (time - manhattanDist) % 2 == 0;
        }

        private static int ManhattanDistance((int x, int y) p1, (int x, int y) p2)
        {
            return Math.Abs(p1.x - p2.x) + Math.Abs(p1.y - p2.y);
        }
    }
}