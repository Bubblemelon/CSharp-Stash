/*
 *
 * An Internal Struct:
 *
 * Internal: (Default if not specified) The type is available to any
 *           code within the same assembly only.
 *
 * Nested classes or structs default to private.
 * Regardless of whether the outer type is a class or a struct,
 * nested types default to private;
 * they are accessible only from their containing type i.e. From the Container Class.
 *
 *   class Container
 *   {
 *       class Nested
 *       {
 *           Nested() { }
 *       }
 *  }
 *
 *  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/nested-types
 */
struct Rectangle
{
  // Note on Properties:
  //
  // S property is a programming construct that enables client code
  // to get or set the value of private fields
  // within a struct or a class

  private int width;

  // Note on "Value":
  //
  // The set accessor uses a special local variable named value
  // to set the value of the private field.
  // The value variable contains the value provided by
  // the client code when it accessed the property.

  // Width is Rectangle's property
  public int Width
  {
    // get accessor
    get
    {
        return width;
    }
    // set accessor
    set
    {
        width = value;
    }
  }


  private int height;

  // Height is Rectangle's property
  public int Height
  {
    get
    {
        return height;
    }
    set
    {
        height = value;
    }
  }

  private string name;

  // This is an Auto-Implement Property
  //
  // It will look for a private string variable
  // Hence, it is invalid to use this syntax
  // if there's more than one private string variable
  public string Name{ get; set; }

}
