using System;

public class SimpleExample
{

  public void powerExample()
  {
    int value = 2;
    for (int power = 0; power <= 32; power++)
       Console.WriteLine("{0}^{1} = {2:N0} (0x{2:X})",
                         value, power, (long)Math.Pow(value, power));
  }

  public int powerFunc(int baseNum, int exponent)
  {
    int result = 1;

    while(exponent > 0)
    {
      result *= baseNum;
      exponent--;
    }

    return result;

  }

  public double cylinderVolume(double radius, double height)
  {
    double radius2 = Math.Pow(radius,2);

    double volume = radius2 * height * Math.PI;

    return volume;

  }


   public static void Main()
   {
     SimpleExample eg = new SimpleExample();
     // eg.powerExample();

     int twoPower8 = eg.powerFunc(2,8);
     Console.WriteLine($"The Result of twoPower8 is {twoPower8}");

     double exampleBottleVolume = eg.cylinderVolume( 5, 10.5 );
     Console.WriteLine($"The Result of exampleBottleVolume is {exampleBottleVolume}");

   }
}
