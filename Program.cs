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
      Pastry PastryStock = new Pastry(30, 2, 5);
      Console.WriteLine("Menu:\n Bread: $" + Bread.getPrice() + "\n Pastries: $" + Pastry.getPrice());
      Console.WriteLine("\nEnter Order:");
      Console.WriteLine("\nHow many loaves of bread would you like?");
      string breadOrder = Console.ReadLine();
      bool isBreadInt = int.TryParse(breadOrder, out int numBread);
      Console.WriteLine("How many pastries would you like?");
      string pastryOrder = Console.ReadLine();
      bool isPastryInt = int.TryParse(pastryOrder, out int numPastry);

      if(!isBreadInt || !isPastryInt)
      {
        Console.WriteLine("\nPlease enter a number\n");
        Thread.Sleep(1000);
        Main();
        return;
      }

      if (numBread >= 1 && isBreadInt)
      {
        Console.WriteLine("Your order comes to,\n   Bread: $" + Bread.buyLoaves(numBread));
      }
      if (numPastry >= 1 && isPastryInt)
      {
        Console.WriteLine("   Pastry: $" + Pastry.buyPastry(numPastry));
      }
      Console.WriteLine(Bread.getOrderPrice() + Pastry.getOrderPrice());
      Console.WriteLine("\nPress any key to exit");
      Console.ReadKey();
      return;
    }
  }
}