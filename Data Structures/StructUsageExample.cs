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

    /////////////////////////////////////////////
    // Demonstrates the use a struct's indexer //
    /////////////////////////////////////////////

    /*
     * Asks user for food suggestions:
     */

    int foodSuggestions_size = 0;

    InOut<int> hello = new InOut<int>();

    foodSuggestions_size = hello.AskUserMore( "\nHow many food suggestions would you like to make? Press enter when complete." );

    string[] foodSuggestions = new string[ foodSuggestions_size ];

    Console.WriteLine("\nHit enter to complete each suggestion entry!\n");

    for( int q = 0; foodSuggestions_size > q; q++ )
    {
      Console.Write( "Suggestion #{0}? ", q + 1 );
      foodSuggestions[q] = Console.ReadLine();
    }

    // Loops to show all user's input:
    //
    // Console.WriteLine( "User's food suggestions: [ {0} ]" ,string.Join(", ", foodSuggestions ) );


    /*
     * End of Asks user for food suggestions:
     */

    // to create Random prices
    Random rnd = new Random();

    Menu menu = new Menu( foodSuggestions_size );

    // Increment Food price
    decimal cost_increment = 1.0m;

    //
    // add objects of the type Food (a struct )
    // into Menu's Food type array
    //
    for( int i = 0; menu.size > i; i++ )
    {
      // menu[i] = new Food( "Food " + i.ToString() , cost_increment );

      // Random Doubles https://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers
      //
      /////////////////////////////////////////////////////////////////////// * (max-min) + min
      menu[i] = new Food( foodSuggestions[i] ,  (decimal)(rnd.NextDouble() * (99.9-0.99) + 0.99) );

      // cost_increment++;
    }

    // Prints the the menu
    Console.WriteLine( "Printing the menu:\n");

    for( int j = 0; menu.size > j; j++ )
    {
      // ABOUT "N" in this line: https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
      Console.WriteLine( "{0}) {1} costs ${2:N2}", (j+1), menu[j].name, menu[j].cost );
    }

    Console.WriteLine("\nThis menu has {0} choices", menu.size);

    ////////////////////////////////////////////////////
    // End of Demonstrates the use a struct's indexer //
    ////////////////////////////////////////////////////


    // This uses the custom struct costructor:
    //
    Food f = new Food( "Yummy Jelly", 5.0m );
    Console.WriteLine( "{0} costs {1} dollars.", f.name, f.cost );

    // The Wheel struct is within a class:
    Car c = new Car(); //Instantiate the class
    Car.Wheel cW = new Car.Wheel("green");

    Car.Wheel cw1 = new Car.Wheel(); // default struct constructor

    cW.describeWheelColor();
    cw1.describeWheelColor();  // not set returns null

    Console.WriteLine( cw1.Color != "" ); // True


    // IMPROVEMENT
    //
    // Example on indexers !!!



  }
}
