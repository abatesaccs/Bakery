using System;
using products.bread;
using products.pastry;
using System.Threading;

namespace Bakery
{
  public class Counter
  {
    public static void Main()
    {
      Bread breadStock = new Bread(30, 5);
      Console.WriteLine("enter number of breads");
      string breadOrder = Console.ReadLine();
      bool isInt = int.TryParse(breadOrder, out int n);
      if (n >= 1 && isInt)
      {
        Console.WriteLine("Your order comes to, Bread: $" + Bread.buyLoaves(n));
      }
      else
      {
        Thread.Sleep(750);
        Console.WriteLine("\nPlease enter a number\n");
        Thread.Sleep(750);
        Main();
      }
    }
  }
}