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
      bool isBreadInt = int.TryParse(breadOrder, out int numBread);
      Console.WriteLine("How many pastries would you like?");
      string pastryOrder = Console.ReadLine();
      bool isPastryInt = int.TryParse(pastryOrder, out int numPastry);

      if (numBread >= 1 && isInt)
      {
        Console.WriteLine("Your order comes to,\n   Bread: $" + Bread.buyLoaves(numBread));
      }
      else
      {
        Thread.Sleep(750);
        Console.WriteLine("\nPlease enter a number\n");
        Thread.Sleep(750);
        Main();
      }

      if (numPastry >= 1 && isInt)
      {
        Console.WriteLine("   Pastry: $" + Bread.buyPastry(numPastry));
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