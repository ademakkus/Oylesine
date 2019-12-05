using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace CharFunctionality
{
  class Program
  {
    static void Main(string[] args)
    {
      char myChar = 'a';
      ForegroundColor = DarkGreen;
      WriteLine("*** char funtionaliy *******");
      ForegroundColor = DarkYellow;
      WriteLine("char.IsDigit('a') :{0}", char.IsDigit(myChar));
      WriteLine("char.IsWhiteSpace('a') :{0}", char.IsWhiteSpace(myChar));
      WriteLine("char.IsPuncuation('a') :{0}", char.IsPunctuation(myChar));
      WriteLine("char.IsUpper('a') :{0}", char.IsUpper(myChar));
      WriteLine("char.IsLower('a') :{0}", char.IsLower(myChar));
      WriteLine("char.IsControl('a') :{0}", char.IsControl(myChar));
      WriteLine("char.IsNumber('a') :{0}", char.IsNumber(myChar));
      WriteLine("char.IsSeperator('a') :{0}", char.IsSeparator(myChar));
      WriteLine("char.IsSurrogate('a') :{0}", char.IsSurrogate(myChar));
      WriteLine("char.IsSymbol('a') :{0}", char.IsSymbol(myChar));
      ////
      
      ForegroundColor = DarkRed;
      WriteLine("*** char funtionaliy *******");
      ForegroundColor = DarkYellow;
      WriteLine("char.IsDigit('3') :{0}", char.IsDigit('3'));
      WriteLine("char.IsWhiteSpace(' ') :{0}", char.IsWhiteSpace(' '));
      WriteLine("char.IsPuncuation(',') :{0}", char.IsPunctuation(','));
      WriteLine("char.IsUpper('A') :{0}", char.IsUpper('A'));
      WriteLine("char.IsLower('a') :{0}", char.IsLower('a'));
      WriteLine("char.IsControl('-') :{0}", char.IsControl('-'));
      WriteLine("char.IsNumber('6') :{0}", char.IsNumber('6'));
      WriteLine("char.IsSeperator('|') :{0}", char.IsSeparator('|'));
      WriteLine("char.IsSurrogate(' ') :{0}", char.IsSurrogate(myChar));
      WriteLine("char.IsSymbol('*') :{0}", char.IsSymbol('*'));

      ConsoleKeyInfo consoleKeyInfo = ReadKey();
      WriteLine(consoleKeyInfo.KeyChar);
      ConsoleKeyInfo consoleKeyInfo2 = ReadKey();
    }
  }
}
