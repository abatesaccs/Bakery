using System;

namespace products.pastry
{
  public class Pastry
  {
    public int Stock {get; set;}
    public static int Price {get; set;}
    public static int DealPrice {get; set;}
    public static int OrderPrice {get; set;}
    public Pastry(int stock, int price, int dealPrice)
    {
      Stock = stock;
      Price = price;
      DealPrice = dealPrice;
    }
    public static int buyPastry(int num)
    {
      int totalPrice = (num % 3) * Price;
      num -= num % 3;
      totalPrice += (int)(Math.Ceiling((double)num / 3) * DealPrice);
      OrderPrice = totalPrice;
      return totalPrice;
    }
  }
}