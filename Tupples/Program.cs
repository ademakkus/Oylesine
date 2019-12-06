using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupples
{
  class Program
  {
    static void Main(string[] args)
    {
      //(string, int, char) values = ("adem akuş", 10, 'c');//give the errror
      (string, int, char) values = ("adem akuş", 10, 'c');
      //var values=("adem akuş", 10, 'c');
      Console.WriteLine($"First Item : {values.Item1}");
      Console.WriteLine($"Second Item : {values.Item2}");
      Console.WriteLine($"ThirdItem : {values.Item3}");
      Console.ReadKey();
    }
  }
}
