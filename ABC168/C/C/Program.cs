using System;
using System.Linq;
using static System.Console;

namespace C
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = ReadLine().Split(' ').Select(double.Parse).ToList();
            var degA = input[2] * (360d / 12) + 30 * input[3] / 60; // H+M/60
            var degB = input[3] * (360d / 60);
            var diff = degA - degB;
            var length = Math.Sqrt(Math.Pow(input[0], 2) + Math.Pow(input[1], 2) - 2 * input[0] * input[1] * Math.Cos(Deg2Rad(diff)));
            WriteLine($"{length:F20}");
        }

        static double Deg2Rad(double degree)
        {
            return degree * Math.PI / 180;
        }
    }
}