// Some notes about Lists:
//
// List - [remove at index](https://msdn.microsoft.com/en-us/library/5cw9x18z(v=vs.110).aspx)

using System;
using System.Collections.Generic;

public class Fruit
{
    public string name { get; set; }
    public string color { get; set; }
    public double price { get; set; }

    public override string ToString()
    {
        return "Name: " + name + " Price: RM" + price + " Color:" + color;
    }



    public static void Main()
    {
      // Create a list of fruits
      List<Fruit> fruitlist = new List<Fruit>();

      // Add fruits to the list.
        fruitlist.Add(new Fruit() { name="Banana", color="yellow", price=10.0});
        fruitlist.Add(new Fruit() { name = "Water Apple", color = "pink", price=5.6});
        fruitlist.Add(new Fruit() { name = "Mangosteen", color = "purple", price=20.5});
        fruitlist.Add(new Fruit() { name = "Durian", color = "green", price=15.7 });
        fruitlist.Add(new Fruit() { name = "Rambutan", color = "red", price=10.5 });



      // Write out the attributes in the list. This will call the overridden ToString method
      // in the fruit class.
      Console.WriteLine();

      foreach (Fruit aFruit in fruitlist)
      {
          Console.WriteLine(aFruit);
      }

      /* Note on RemoveAt() , Remove(), Contains() and Insert()
       *
       * https://msdn.microsoft.com/en-us/library/5cw9x18z(v=vs.110).aspx
       /


    } // main




}
