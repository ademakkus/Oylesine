using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace TupleUsingAtMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      var samples = FillForm(); 
      ForegroundColor = DarkCyan;
      WriteLine($"Your name : {samples.name}");
      ForegroundColor = DarkYellow;
      WriteLine($"Your surname : {samples.surname}");
      ForegroundColor = DarkBlue;
      WriteLine($"Your salary : {samples.salary}");
      ReadKey();
    }
    static(string name,string surname,int salary,bool married) FillForm()
    {
      return ("adem", "akkuş", 4000, true);
    }
  }
}
