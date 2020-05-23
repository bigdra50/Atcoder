using System;

namespace A
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var value = int.Parse(Console.ReadLine());
            switch (value%10)
            {
                case 2:
                case 4:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("hon");
                    break;
                case 0:
                case 1:
                case 6:
                case 8:
                    Console.WriteLine("pon");
                    break;
                case 3:
                    Console.WriteLine("bon");
                    break;
            }
        }
    }
}