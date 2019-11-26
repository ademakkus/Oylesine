using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  static System.Console;
namespace DiziElemanlariArasinaTireIsareti
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <='Z'; i++)
            {
                Write(i+(i<'Z'?"-":""));
            }
            WriteLine();
            ReadKey();
        }
    }
}
