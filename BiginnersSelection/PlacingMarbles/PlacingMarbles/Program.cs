using System.Linq;
using static System.Console;

namespace PlacingMarbles
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(ReadLine().Count(c => c == '1'));

        }
    }
}