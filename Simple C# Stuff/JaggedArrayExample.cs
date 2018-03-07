using System;
using System.Collections;


public class JaggedArrayExample
{
  /* Array of array(s).
  */

  // Longer way of Declaring and Initializing:
  // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays
  //
  // int[][] jaggedArray = new int[3][];
  //
  // jaggedArray[0] = new int[5];
  // jaggedArray[1] = new int[4];
  // jaggedArray[2] = new int[2];
  //
  // jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
  // jaggedArray[1] = new int[] { 0, 2, 4, 6 };
  // jaggedArray[2] = new int[] { 11, 22 };



  public void jArrayEx()
  {

    // Description of jaggedArrayInt:
    //
    // A single-dimensional array that has three elements,
    // each are single-dimensional array of integers.
    int[][] jaggedArrayInt = new int[][]
    {
    new int[] { 1,3,5,7,9 },
    new int[] { 0,2,4,6 },
    new int[] { 11,22 }
    };

    string[][] jaggedArrayStr = new string[][]
    {
      new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" },
      new string[] { "Saturday", "Sunday" }
    };

    string[][] jaggedArrayStr2 = new string[4][];

    // each jaggedArrayStr2[n] element can hold up to a string array of one element:
    jaggedArrayStr2[0] = new string[1];
    jaggedArrayStr2[1] = new string[1];
    jaggedArrayStr2[2] = new string[1];
    jaggedArrayStr2[3] = new string[1];

    // adding value to jaggedArrayStr2 elements:
    jaggedArrayStr2[0][0] = "Apple";
    jaggedArrayStr2[1][0] = "Banana";
    jaggedArrayStr2[2][0] = "Corn";
    jaggedArrayStr2[3][0] = "Durian";

    // Prints jaggedArrayInt elements:
    Console.WriteLine("\nPrinting jaggedArrayInt: ");
    jArrayPrint( jaggedArrayInt );

    // Prints jaggedArrayStr elements:
    // Console.WriteLine("\nPrinting jaggedArrayStr: ");
    // jArrayPrint<string[][]>( jaggedArrayStr );

    // Prints jaggedArrayStr2 elements:
    // Console.WriteLine("\nPrinting jaggedArrayStr2: ");

  } //function

  // jagged array print function:

  public void jArrayPrint( int[][] jArray )
  {

    // sample output:
    // Element(0): 1 3 5 7 9
    // Element(1): 0 2 4 6
    // Element(2): 11 22

    for (int i = 0; i < jArray.Length; i++)
    {
        Console.Write("Element({0}): ", i);

        for (int j = 0; j < jArray[i].Length; j++)
        {
            Console.Write("{0}{1}", jArray[i][j], j == ( jArray[i].Length - 1 ) ? "" : " ");
            // if J is not the last element then put a "space"
        }
        Console.WriteLine(); // next line !
    }


  }


  static void Main()
  {
    JaggedArrayExample jAE = new JaggedArrayExample();

    jAE.jArrayEx();

    // IMPROVEMENT:
    //
    // (1) jArrayEx needs to be a generic function
    // (2) after the completion of jArrayEx, it should be placed in IO.cs


  }
}
