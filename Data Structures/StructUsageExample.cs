using System;
using StructExample;

public class StructUsageExample
{


  /// <summary>
  ///   The main entry point for StructExample
  /// </summary>
  [STAThread]
  public static void Main(string[] args)
  {

    // {
    //
    // Demonstrates a feature that is unique to structs:
    // It creates a Person object without using the new operator.
    // Program will not compile, Person object was created using a Class.
    //
    // Declare the object:
    Person p;
    //
    // Initialize:
    p.age = 12;
    p.initial = 'J';
    //
    // Print these values:
    Console.WriteLine("This person {0} is age {1}.", p.initial, p.age );
    //
    // }

    // This uses the custom struct costructor:
    //
    Food f = new Food( "Yummy Jelly", 5.0m );
    Console.WriteLine( "{0} costs {1} dollars.", f.name, f.cost );


    Car c = new Car(); //Instantiate the class
    Car.Wheel cW = new Car.Wheel("green");

    Car.Wheel cw1 = new Car.Wheel(); // default struct constructor

    cW.describeWheelColor();
    cw1.describeWheelColor();  // not set returns null

    Console.WriteLine( cw1.Color != "" ); // True



  }
}
