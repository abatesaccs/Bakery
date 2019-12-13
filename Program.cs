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
      Console.WriteLine("Menu:\n Bread: $" + Bread.getPrice());
      Console.WriteLine("Enter Order:");
      Console.WriteLine("How many loaves of bread would you like?");
      string breadOrder = Console.ReadLine();
      bool isInt = int.TryParse(breadOrder, out int n);
      if (n >= 1 && isInt)
      {
        Console.WriteLine("Your order comes to,\n   Bread: $" + Bread.buyLoaves(n));
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