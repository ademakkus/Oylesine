using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples2
{
  class Program
  {
    static void Main(string[] args)
    {
      (string adi, int no, char karakter) values = ("adem akuş", 10, 'c');
      //var values=("adem akuş", 10, 'c');
      //Console.WriteLine($"First Item : {values.Item1}");
      //Console.WriteLine($"Second Item : {values.Item2}");
      //Console.WriteLine($"ThirdItem : {values.Item3}");
      Console.WriteLine($"Adı : {values.adi}");
      Console.WriteLine($"Numara : {values.no}");
      Console.WriteLine($"Karakter : {values.karakter}");
      Console.ReadKey();
    }
  }
}
