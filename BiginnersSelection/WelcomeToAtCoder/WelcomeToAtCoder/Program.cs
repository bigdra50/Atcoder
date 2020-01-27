using System.IO;
using System.Linq;
using static System.Console;

namespace WelcomeToAtCoder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sw = new StreamWriter(OpenStandardOutput()){AutoFlush = false};
            SetOut(sw);
            var a = int.Parse(ReadLine());
            var bc = ReadLine().Split(' ').Select(int.Parse);
            
            WriteLine($"{a+bc.First() + bc.Last()} {ReadLine()}");
            
            Out.Flush();
        }
    }
}