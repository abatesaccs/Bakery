using System;

namespace products.bread
{
  public class Bread
  {
    private int _Loaves;
    private static int _Price;
    public Bread(int loaves, int price)
    {
      _Loaves = loaves;
      _Price = price;
    }
    public int getLoaves()
    {
      return _Loaves;
    }
    public static int getPrice()
    {
      return _Price;
    }
    public void setLoaves(int loaves)
    {
      _Loaves = loaves;
    }
    public static int buyLoaves(int loaves)
    {
      int numSold = loaves;
      int price = 1;
      if(loaves == 1)
      {
        price *= _Price;
        return (int)price;
      }
      else
      {
      price = (int)Math.Ceiling((double)loaves / 3 * 2);
      price *= _Price;
      return price;
      }
    }
  }
}