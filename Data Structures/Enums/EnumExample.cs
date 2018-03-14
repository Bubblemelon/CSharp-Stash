using System;
using System.Collections; // for enum
using System.ComponentModel; // for Description
using System.Diagnostics; // for Debug e.g. Debug.WriteLine() - does not show on terminal
using System.Reflection; // for BindingFlags
using System.Linq; // for Single

namespace EnumExampleNamespace
{
  /*
   * Known as An enumeration type, enum or enumeration.
   *
   * To not be confused with IEnumerable and IEnumerator.
   * Better explaination: https://stackoverflow.com/questions/558304/can-anyone-explain-ienumerable-and-ienumerator-to-me
   * Summarized explaination: https://stackoverflow.com/questions/619564/what-is-the-difference-between-ienumerator-and-ienumerable
   *
   *
   * Creates a variable with a fixed set of possible values, .e.g day of the week.
   *
   * Each member of an enum has a name and a value.
   * The name is of type string and is defined in the braces, e.g. as Sun or Mon. (such as below in enum Day)
   *
   * By default, the value is an integer.
   * If this value is not specified for each member, the members are assigned
   * with incremental values starting with 0.
   *
   * e.g. Day.Sun is equal to 0 and Day.Mon is equal to 1.
   *
   * Best practice:
   * Define enum directly within a namespace (to organize many classes) so,
   * that all classes in that namespace will have access to it.
   *
   * How to use Namespaces: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/using-namespaces
   *
   * Otherwise defined: within the global scope or within a class scope !
   * - Cannot declare more than one enum within a class
   *
   * e.g. "using System" is declaring a namespace called System
   * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/
   *
   * Possible to nest enums within classes or structs.
   * Enum values start at 0 and each successive member is increased by a value of 1.
   *
   *
   */

   // enum is int by default:
   enum Day { Sat, Sun, Mon, Tue, Wed, Thu, Fri };

   // To specify another integral numeric type by using a colon:
   enum Month : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

   // Integral types ( different types of integers - also a subset of simple types )
   // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/integral-types-table


   // Intrinsic data types (types belonging to C#)
   // https://msdn.microsoft.com/en-us/library/windows/desktop/ms221332(v=vs.85).aspx
   //
   // List of possible intrinsic data types:
   // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum



   // The underlying type specifies how much storage will be allocated for each enumerator in the enum
   // During compile time, enum will be converted to numeric literals in your code

   // Numeric Literals:
   // https://stackoverflow.com/questions/166752/c-sharp-compiler-number-literals
   //
   // What is a numeric literal:
   // http://www.blackwasp.co.uk/CSharpNumericLiterals.aspx
   // https://www.ibm.com/support/knowledgecenter/en/SS6SGM_3.1.0/com.ibm.aix.cbl.doc/PGandLR/ref/rllannl.htm



   // No identifier in C# may begin with a number (for lexical/parsing reasons):
   // so, Add [Description] attribute to enum values
   //
   // Must use "using System.ComponentModel; "
   // https://stackoverflow.com/questions/3916914/c-sharp-using-numbers-in-an-enum
   // https://www.codementor.io/cerkit/giving-an-enum-a-string-value-using-the-description-attribute-6b4fwdle0
   //
   // Invalid:
   // enum Clockface { 12 = 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
   //
   // 12 is given the value 1 instead of the default of 0. Now 1 is 2, 2 is 3
   public enum Clockface
   {
    [Description("12")]
    twelve = 1,
    [Description("1")]
    one,
    [Description("2")]
    two,
    [Description("3")]
    three,
    [Description("4")]
    four,
    [Description("5")]
    five,
    [Description("6")]
    six,
    [Description("7")]
    seven,
    [Description("8")]
    eight,
    [Description("9")]
    nine,
    [Description("10")]
    ten,
    [Description("11")]
    eleven,
  };

  // Notes on Static:
  //
  // If the static keyword is applied to a class, all the members of the class must be static.
  //
  // Use the static modifier to declare a static member,
  // which belongs to the type itself rather than to a specific object(an instance)
  //
  //
  // While an instance of a class contains a separate copy of all instance fields
  // of the class, there is only one copy of each static field.
  //
  // static class info:
  // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
  //
  // general static info:
  // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static
  //
  // Accessibility: e.g. public static vs static
  // https://stackoverflow.com/questions/14212437/what-is-the-difference-between-public-static-public-and-static-method
  // https://stackoverflow.com/questions/2390063/what-does-public-static-void-mean-in-java


  public static class EnumExample
  {
    // An extension method is:
    //
    // Allows for the addition of methods to existing types without creating
    // a new derived type, recompiling, or otherwise modifying the original type.
    // Extension methods are a special kind of static method, but they are
    // called as if they were instance methods on the extended type.
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
    //
    // This extension function must be static and class must be static as well
    // Otherwise:
    // Extension methods must be defined in a non-generic static class
    //
    // The rest of the functions now also must be static
    // Otherwise:
    // Cannot declare instance members in a static class
    //
    // This extension function was taken from:
    // https://stackoverflow.com/questions/3916914/c-sharp-using-numbers-in-an-enum
    public static string GetDescription(this Enum value)
    {
     return ((DescriptionAttribute)Attribute.GetCustomAttribute(
         value.GetType().GetFields(BindingFlags.Public | BindingFlags.Static)
             .Single(x => x.GetValue(null).Equals(value)),
         typeof(DescriptionAttribute)))?.Description ?? value.ToString();
    }
    // Things to consider when creating an extension method:
    // https://stackoverflow.com/questions/6096299/extension-methods-must-be-defined-in-a-non-generic-static-class
    //
    // (1) The class which defines an extension method must be non-generic, static and non-nested
    // (2) Every extension method must be a static method
    // (3) The first parameter of the extension method should use the this keyword.

    // not the constructor
     public static void enumEx()
     {
       // I do not remember what I was going to use this for

     }// function



     public static void Main()
     {
       // compile this way:
       // mcs EnumExample.cs
       // run like this:
       // mono EnumExample.exe

       Console.WriteLine( Clockface.twelve.GetDescription() ); // output: 12
       Console.WriteLine( Clockface.eleven.GetDescription() ); // output: 11

       // Set an enum variable by name.
       Day myfavoriteDay = Day.Fri; // output: Fri

       Console.WriteLine( myfavoriteDay );

       // Set an enum variable by value.
       Day myfreeDay = (Day)4; // Wed

       Console.WriteLine( myfreeDay ); // output: Wed




     }



  } // class

} // namespace
