using System; // for ArgumentException
using System.ComponentModel;
using EnumExampleNamespace;


public static class EnumExtensions
{
  // Different ways to get the description of an enum elment:
  //
  // http://wmwood.net/2015/12/18/quick-tip-enum-to-description-in-csharp/
  // https://www.codementor.io/cerkit/giving-an-enum-a-string-value-using-the-description-attribute-6b4fwdle0
  // https://social.msdn.microsoft.com/Forums/vstudio/en-US/562c4b8c-2960-4983-85ea-dcd7c06b6dce/getting-the-description-of-the-enum-value?forum=csharpgeneral


  // Explains "where" :
  // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-generic-type-constraint

  public static string GetDescription<T>(this T enumerationValue) where T : struct
  {
    var type = enumerationValue.GetType();
    if(!type.IsEnum)
    {
      throw new ArgumentException($"{nameof(enumerationValue)} must be of Enum type", nameof(enumerationValue));
    }
    var memberInfo = type.GetMember(enumerationValue.ToString());
    if(memberInfo.Length > 0)
    {
      var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

      if(attrs.Length > 0)
      {
        return ((DescriptionAttribute)attrs[0]).Description;
      }
    }
    return enumerationValue.ToString();
  }

  public static void Main()
  {
    // IMPROVEMENT:
    //
    //

    // ERROR: (solved)
    // EnumExtensions.cs(17,24): error CS1106: `EnumExtensions<T>.GetDescription(this T)': Extension methods must be defined in a non-generic static class
    // Solved by adding "where T : struct" to GetDescription<T>() function
    // because the class cannot be generic

    // This is invalid (The Error):
    // `EnumExampleNamespace.Clockface' does not contain a definition for `EnumExtensions'
    // and no extension method `EnumExtensions' of type `EnumExampleNamespace.Clockface' could be found
    //
    // (REASON) This is saying that `EnumExtensions' is within the `EnumExampleNamespace` namespace !
    // Console.WriteLine( Clockface.four.EnumExtensions.GetDescription() ); // output: 4

    Console.WriteLine( Clockface.four.GetDescription() ); // output: 4
    // compile this way:
    // mcs EnumExtensions.cs EnumExample.cs <-- so that EnumExampleNamespace can be found !
    // run like this:
    // mono EnumExtensions.exe

  } //main

}
