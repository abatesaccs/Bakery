using System;

namespace products.pastry
{
  public class Pastry
  {
    public int _Stock;
    public static int _Price;
    public Pastry(int stock, int price)
    {
      _Stock = stock;
      _Price = price;
    }
    public int getStock()
    {
      return _Stock;
    }
    public static int getPrice()
    {
      return _Price;
    }
    public static void setPrice(int price)
    {
      _Price = price;
    }
    public static int buyPastry(int num)
    {
      int price = (num % 3) * _Price;
      price += (int)Math.Ceiling((double)num / 3);
      return price;
    }
  }
}