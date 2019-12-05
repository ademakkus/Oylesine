using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
  struct Point
  {

    public int X;
    public int Y;
    public void Increment()
    {
      X++;
      Y++;

    }
    public void Decreement()
    {
      X--;
      Y--;


    }
    public void Display()
    {
      Console.WriteLine("X= {0}, Y = {1}",X,Y);
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(" *** Struct **** ");
      Point mypoint;
      mypoint.X = 349;
      mypoint.Y = 255;
      mypoint.Display();
      mypoint.Increment();
      Console.WriteLine("\nAfter Increement ");
      mypoint.Display();
      mypoint.Decreement();
      Console.WriteLine("\nAfter decreement");
      mypoint.Display();
      Console.ReadKey();
    }
  }
}
