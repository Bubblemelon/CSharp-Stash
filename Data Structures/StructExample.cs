using System;



namespace StructExample
{
  /* What are Stucts:
   *
   * A programming construct to define custom types. (behave like built-in types)
   *
   * A lightweight data structure that represent related pieces of
   * information as a single item.
   *
   * Structs can contain a variety of members including constructors, fields,
   * constants, properties, indexers, methods, operators, events, and even nested types.
   *
   * Remember to keep it lightweight, otherwise create a Class instead.
   *
   * Reason for being lightweight:
   * New instances of a class is placed on the heap. (reference in memory to classes)
   * Instantiated structs are placed on the stack. (directly refers to stuct instance)
   *
   * Most of the built-in types in Visual C#, such as int, bool, char,
   * are defined by structs.
   *
   * A Struct is preceded with a access modifier:
   *
   * Public: The type is available to code running in any assembly
   * Internal: (Default if not specified) The type is available to any
   *           code within the same assembly only.
   * Private: The type is only available to code within the struct that contains it.
   *          Only use the private access modifier with nested structs.
   *
   * It is possible to have many structs in one file:
   *
   * (1) When all structs are encapsulated by a namespace,
   *     remember to do "using namespace_name;" on the file with main funct.
   *
   * (2) When all struct are encapsulated by a class,
   *     need to make accessor for the struct.
   *     https://social.msdn.microsoft.com/Forums/en-US/985e8679-ac03-4299-8afb-ae36a997b83b/using-struct-inside-the-class?forum=csharplanguage
   *
   * Inheritance:
   *
   * (1) Class cannot inherit from other structs nor can structs inherit other classes.
   * (2) A struct can inherit the object class, meaning "a struct within a class" e.g. Wheel will inherit Car
   * (3) Structs can implement custom interfaces
   *
   * A property:
   * Is a programming construct that enables client code
   * to get or set the value of private fields within a struct or a class.
   * The property behaves like a public field
   *
   * An Auto-Implement property:
   * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
   * public string FirstName { get; set; }
   *
   * Accessors:
   * (1) A get accessor to provide read access to a field.
   *
   * Possible to initilize like so:
   * public string FirstName { get; set; } = "Jane";  <-- can't do that within structs
   *
   *
   * FIELDS --- Fields:
   * Are variables of a struct !
   *
   * Refer to StructUsageExample file to demonstrate usage of this struct !
   */

   // a struct inside the namespace
   public struct Person
   {
     // These statements declare the struct fields and set the default values.
     public int age;
     public char initial;
   } // Person

   // public struct Pet
   // {
   //   // This is the custom constructor.
   //   public Pet(int playfulness, string breed)
   //   {}
   //
   //
   //   public int Strength;
   //   public string Bean;
   // }

   // a struct inside the namespace with a custom constructor
   public struct Food
   {
     // these are struct fields:
     public string name;
     public decimal cost;

     // This is a custom constructor
     public Food(string n, decimal c)
     {
       name = n;
       cost = c;
     }

   }// Food

   // Demonstrate the creation of an indexer
   public struct Menu
   {
     // Menu struct field
     private Food[] item;

     private int length;

     // A custom constructor:
     public Menu(int x)
     {
       this.length = x;

       this.item = new Food[] {}
     }

     // This is an indexer:
     public Food this[ int index ]
     {
       get{ return this.item[index]; }
       set{ this.item[index] = value; }
     }

     // Menu property:
     public int size
     {
       get{ return item.Length; }
     }

   }

   //

   // a struct nested in a class that's also inside the namespace
   public class Car
   {
     // classinstance variable
     public string modelName;

     // Was initially a private struct ( not specifed within a class - defaults to private)
     // Nested class/struct default to private
     //
     // [ I do not know how to access a private struct ]
     // https://stackoverflow.com/questions/4908481/define-private-public-type-of-struct
     //
     // Refer to InternalStructExample.cs for usage on Internal Structs
     //
     // Set to public so that it can be accessed outside of the Car Class
     public struct Wheel
     {
       // belongs to the struct
       // These variables can ONLY declare
       // meaning (can declare but can't initialize as well), this is invalid: private string color = "Blue";
       private string color;

       // string name; (defaults to private if not specified)
       // https://stackoverflow.com/questions/4908481/define-private-public-type-of-struct

       // private int strength;

       // Custom Constructor
       // All struct constructors have to take at least one parameter!
       public Wheel( string c )
       {
         // "color == parameter's color" && "this.color == private string color; " that was declared earlier
         this.color = c;

         // also possible with this:
         // color = c;
       }

       // To set and get the wheel's color
       //
       // IMPORTANT !!!
       // Otherwise it's not accessible from outside this class!
       // Unless (this `Car.Wheel cW = new Car.Wheel("green");` was inside)
       // the main funct that was within the Car Class.
       //
       // This name "Color" must be different from "private string color;"
       public string Color
       {
         get{ return color; }
         set{ color = "none"; }
       }

       // this will automatically get and set a private string variable
       // so you cannot use this syntax if there is more than one private string variable
       // public string Color { get; set; }

       public void describeWheelColor()
       {
         Console.WriteLine("This wheel's color is {0}.", Color);
       }


     } // wheel


     // To demonstrate line 106 IMPORTANT !!!
     //
     // public static void Main(string[] args)
     // {
     //   Car c = new Car(); //Instantiate the class
     //   Car.Wheel cW = new Car.Wheel("green");
     //
     //   cW.describeWheelColor();
     // }


   } // car


} // namespace
