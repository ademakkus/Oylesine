using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace DigitSeperator
{
  class Program
  {
    static void Main(string[] args)
    {
      ForegroundColor = DarkMagenta;
      WriteLine("\n---Use Digit Seperator -----\n");
      WriteLine("Integer : {0}", 123_456_789);
      WriteLine("Long : {0}", 123_456_789L);
      WriteLine("Float : {0}", 123_456_789.1234F);
      WriteLine("Double : {0}", 123_456_789.123);
      WriteLine("Decimal : {0}", 123_456_789.120M);
      WriteLine("\n---Binary Seperator -----\n");
      WriteLine("binary 00001_0000 aquals decimal Sixteen: {0}", 0b0001_0000);
      WriteLine("binary 00010_0000  aquals decimal Thirty two: {0}", 0b0010_0000);
      WriteLine("binary  00010_0000 aquals decimal Sixty four: {0}", 0b0100_000);
     
      ReadKey();
    }
  }
}
