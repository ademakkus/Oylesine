using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace FormattingNumericalData
{
  class Program
  {
    static void Main(string[] args)
    {
      int number = 99999;
      WriteLine("The value 99999 in various formats:");
      WriteLine("c format :{0:c}", number);
      WriteLine("d9 format :{0:d9}", number);
      WriteLine("f3 format :{0:f3}", number);
      WriteLine("n format :{0:n}", number);
      WriteLine("E format :{0:E}", number);
      WriteLine("e format :{0:e}", number);
      WriteLine("X format :{0:X}", number);// convert to hexa decimal format
      WriteLine("x format :{0:x}", number);// convert to hexa decimal format
      WriteLine("int min {0} and max {1} value", int.MaxValue, int.MaxValue);
      WriteLine("double min {0} and max {1} value", double.MaxValue, double.MaxValue);
      WriteLine("double.Epsion {0} ", double.Epsilon);
      WriteLine("double.PositiveInfinity : {0}", double.PositiveInfinity);
      WriteLine("double.NegativeInfinity : {0}", double.NegativeInfinity);
      WriteLine("bool.TrueString : {0}", bool.TrueString);
      WriteLine("bool.FalseString : {0}", bool.FalseString);
      ReadKey();
    }
  }
}
