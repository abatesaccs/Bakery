using System;

namespace products.bread
{
  public class Bread
  {
    public int Loaves {get; set;}
    public static int Price {get; set;}
    public static int OrderPrice {get; set;}
    public Bread(int loaves, int price)
    {
      Loaves = loaves;
      Price = price;
    }
    public static int buyLoaves(int loaves)
    {
      int numSold = loaves;
      int totalPrice = 1;
      if(loaves == 1)
      {
        totalPrice *= Price;
        OrderPrice = totalPrice;
        return (int)totalPrice;
      }
      else
      {
      totalPrice = (int)Math.Ceiling((double)loaves / 3 * 2);
      totalPrice *= Price;
      OrderPrice = totalPrice;
      return totalPrice;
      }
    }
  }
}