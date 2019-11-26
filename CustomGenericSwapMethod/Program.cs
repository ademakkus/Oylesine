using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static  System.Console;
using static System.ConsoleColor;
namespace CustomGenericSwapMethod
{
    internal class Program
    {
        private static void Swap<T>(ref T a,ref  T b)
        {
            WriteLine("You sent the Swap() method : a {0} type",typeof(T));
            var temp = a;
            a = b;
            b = temp;

        }

        private static void Main(string[] args)
        {
            ForegroundColor = DarkYellow;
            WriteLine("---- Custom Generic Swap Method -----");
            var str1 = "AKKUŞ";
            var str2 = "Adem";
            ForegroundColor = DarkGreen;
            WriteLine($"{str1} and {str2} before Swap");
            Swap<string>(ref str1,ref  str2);
            ForegroundColor = DarkRed;
            WriteLine($"{str1} and {str2} AFTER Swap");
            double db1 = 123;
            double dbl2 = 987;
            ForegroundColor = DarkGreen;
            WriteLine($"{db1} and {dbl2} before Swap");
            Swap<double>(ref db1,ref dbl2);
            ForegroundColor = DarkRed;
            WriteLine($"{db1} and {dbl2} AFTER Swap");
            ReadKey();
        }
    }
}
