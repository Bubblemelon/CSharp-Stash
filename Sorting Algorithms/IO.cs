using System;
using System.Text;
using System.IO;

/* Generic class with generic functions & NON-generic functions :
 *
 * Some simple stdin and stdout functions
 */

public class InOut<T>
{
  // ONLY TAKES ONE keyboard INPUT - DOESN'T NEED to use ENTER key
  //  e.g. cannot take input "10" ; this is valid "9" ( one digit input )
  // keyboard input e.g. Numbers 1,2,3,... -> ascii int -> char -> int
  //
  public int AskUser<U>()
  {
    string message = "Your input is '{0}' and in hexadecimal (ascii) is 0x{1:x4}.";

    int something = Console.Read();  //user inputs are in ascii
    // Type: System.Int32
    // The next character from the input stream,
    // or negative one (-1) if there are currently no more characters to be read.

    char ch = Convert.ToChar(something); // ascii int -> char

    int val = (int)Char.GetNumericValue(ch); // char -> double -> casted to int
    // int casting the double from GetNumericValue
    // Type: System.Double
    // The numeric value of char if that character represents a number; otherwise, -1.0.

    Console.WriteLine(); // dont need to add System, since there's "using System"

    Console.WriteLine( message, val, something );

    something = val;

    return something; // or simply return val

  }
  //
  // keyboard input -> string -> int
  // NON-generic function !
  // THIS functions will ask for more than one digit input e.g. 10
  //
  public int AskUserMore()
  {
    string userInput = Console.ReadLine();
    // Type: System.String
    // The next line of characters from the input stream, or null if no more lines are available.
    // NEEDS TO PRESS "ENTER" to complete user input.

    int numPut; // keeps userInput string as an int

    bool result = Int32.TryParse(userInput, out numPut);
        if (result)
        {
           Console.WriteLine("Converted '{0}' to {1}.", userInput, numPut);
/*
 Int32.TryParse(s, result);

s
 Type: System.String
 A string containing a number to convert.

result
 Type: System.Int32
 When this method returns, contains the 32-bit signed integer
 value equivalent of the number contained in s, if the conversion succeeded,
 or zero if the conversion failed.

 The conversion fails if the s parameter is null or String.Empty,
 is not of the correct format, or represents a number less than MinValue
 or greater than MaxValue.

 This parameter is passed uninitialized;
 any value originally supplied in result will be overwritten.

Return Value
 Type: System.Boolean
 true if s was converted successfully; otherwise, false.

*/

          return numPut;

        }
        else
        {
//
        Console.WriteLine("Attempted conversion of '{0}' failed.",
                              userInput == null ? "<null>" : userInput);

        return -1;

        }


    //return -1; <-- not reachable

  }


  public void Ask4File()
  {
    if (! Console.IsInputRedirected)
    {
       Console.WriteLine("This function requires that input be redirected from a file.");
       Console.WriteLine("For example: program.exe < file.txt");
       return;
    }
  }

  public void Ask4Double()
  {
    Console.WriteLine("Input a decimal number e.g. 1.00: ");
    double e = double.Parse(Console.ReadLine(),System.Globalization.NumberStyles.AllowDecimalPoint); //this second parameter may not do anything

    Console.WriteLine("Your output will be in one decimal places e.g. 1.0:");
    Console.WriteLine("{0:0.0}", e );

  }

}// class bracket
