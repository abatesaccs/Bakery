using System;

namespace products.bread
{
  public class Bread
  {
    private int _Loaves;
    private int _Price;
    public Bread(int loaves, int price)
    {
      _Loaves = loaves;
      _Price = price;
    }
    public int getLoaves()
    {
      return _Loaves;
    }
    public int buyLoaves(int loaves)
    {

    }
  }
}