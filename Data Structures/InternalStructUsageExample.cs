using System;

/*
 * Instantiating an Internal Struct:
 *
 * Compile like so:
 * mcs InternalStructUsageExample.cs InternalStructExample.cs
 *
 * Use like so:
 * mono InternalStructUsageExample.exe
 *
 * Reference:
 * http://csharp-station.com/Tutorial/CSharp/Lesson12
 * http://csharp.net-tutorials.com/advanced/structs/
 * https://social.msdn.microsoft.com/Forums/en-US/985e8679-ac03-4299-8afb-ae36a997b83b/using-struct-inside-the-class?forum=csharplanguage
 *
 */
class StructExample
{
  static void Main()
  {
    // Instantiates a new Rectangle Type defined by an internal struct
    Rectangle rectangle = new Rectangle();

    // Using the public properties of Rectangle !
    rectangle.Name = "Bungle";
    rectangle.Width = 1;
    rectangle.Height = 8;

    string unit_w = rectangle.Width > 1 ? "units" : "unit";
    string unit_h = rectangle.Height > 1 ? "units" : "unit";

    Console.WriteLine("This {0} rectangle is {1} {2} wide {3} {4} long.", rectangle.Name, rectangle.Width, unit_w, rectangle.Height, unit_h);

  }
}
