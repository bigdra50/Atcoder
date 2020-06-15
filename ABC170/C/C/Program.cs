using System;
using System.Linq;
using static System.Console;

namespace C
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var xn = ReadLine().Split(' ').Select(int.Parse);
            if (xn.Last() == 0)
            {
                WriteLine(xn.First());
                return;
            }

            var pList = ReadLine().Split(' ').Select(int.Parse).ToList();
            var target = xn.First();
            if (!pList.Contains(target))
            {
                WriteLine(target);
                return;
            }

            int CheckDecrement(int t)
            {
                t--;
                if (!pList.Contains(t)) return t;
                pList.Remove(t);
                return CheckDecrement(t);
            }
            int CheckIncrement(int t)
            {
                t++;
                if (!pList.Contains(t)) return t;
                pList.Remove(t);
                return CheckIncrement(t);
            }

            var lower =CheckDecrement(target);
            var higher =CheckIncrement(target);
            var lDist = Math.Abs(lower - target);
            var hDist = Math.Abs(higher - target);
            if (lDist == hDist)
            {
                WriteLine(lower);
            }
            else
            {
                WriteLine(lDist < hDist ? lower : higher);
            }
        }
    }
}