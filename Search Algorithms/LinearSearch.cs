using System;
using System.Collections;


public class LinearSearch
{
  /* Takes an array (search source) and an int (query subject)
   *
   * Seqentially searches the array from index 0
   * up till the integer is found
   * (returns the index at the position where this integer matches the search query)
   * or
   * until the end of the Array i.e. array[ array.Length -1 ]
   * (returns -1 indicating that is was not found)
   *
   *
   * Compile this way:
   * mcs LinearSearch.cs RandomNum.cs
   *
   */

  public int linearsearch( int[] array, int query )
  {
    int result_index = -1;

    Console.WriteLine( "The linear searching this unsorted array: [ {0} ]" ,string.Join(", ", array ) );

    for( int i = 0; array.Length > i; i++ )
    {

      if( array[i] == query )
      {
        result_index = i;
        Console.WriteLine( "The query subject: {0} is at index [{1}] of {2}", query, result_index, string.Join(", ", array ));
        break;
      }

    } //for

    if( result_index == -1 )
    {
      Console.WriteLine( "The query subject: {0} was not found in: {1}", query, string.Join(", ", array ));
    }

    return result_index;
  }

  public static void Main()
  {
    LinearSearch lS = new LinearSearch();

    RandomNum rNA = new RandomNum();


    // ***** Tests for linearsearch() *****
    //
    //
    // int[] array = new int[] { 6,3,8,2,9 };
    //
    // random number generator for array RandNumArrGen( array_size, max_value);
    //
    int[] test = rNA.RandNumArrGen(30, 88);
    int[] test2 = rNA.RandNumArrGen(20, 101);
    // int[] test3 = rNA.RandNumArrGen(10, 25);


    // lS.linearsearch( array, 2 );


  } // Main

} // class
