using System;
using System.Collections;


public class BinarySearch
{

  /* Takes an array (search source) and an int (query subject)
   *
   * IMPORTANT: The list must be sorted before the binary search can work
   *
   * *** *** ***
   *
   * Steps:
   *
   * (1) This search starts at the mid point of the list, compares it with the query subject (or search term).
   *
   * (2a) If the search term is less than the middle value in the list:
   * the second half (latter half) of the list is discarded for the next search
   *
   * (2b) Otherwise (if query is larger than middle value), discard the first half (former half) for the next search and use the second half to search.
   *
   * [ The total number of values to search is now reduced by half ]
   *
   * (3) This compare and divide process continues until the value is found or, until the list is completely discarded (meaning no value found).
   *
   * *** *** ***
   *
   * IF THE ARRAY LENGTH IS EVEN :
   *
   * Say, an array's length = 4
   *
   *  0 1 2 3  <-- indices
   *
   * So ( 0 + 3 ) / 2 = 1
   * Hence, index 1 is the mid point.
   *
   *
   * Compile this way:
   * mcs BinarySearch.cs RandomNum.cs
   *
   */

  public int binarysearch( int[] array, int query )
  {

    int R; int L; // Right & Left index (limit) holders

    int M; // Midpoint holder

    int result_index = -1;

    bool notfound = false;

    // Search the whole array first from beginning to end
    L = 0;
    R = array.Length - 1;

    Console.WriteLine( "Searching this array: [{0}]", string.Join(", ", array) );

    while( !notfound ) // !false = true ; !true = false
    {
      Console.WriteLine( "L:{0} & R:{1}", L, R );

      M = (L + R)/2;

      Console.WriteLine( "M = {0}", M );

      if( query == array[M] ) // FOUND Query Subject !
      {
        Console.WriteLine( "Binary Search Found {0} and index {1}", query, M );

        result_index = M;

        break;
      }
      else if( query != array[M] && (R == L || R < L) ) // if FOUND did not work ( problem resolved here )
      {
        Console.WriteLine( "Binary Search COULD NOT FIND Query {0} in [{1}]", query, string.Join(", ", array) );

        notfound = true;
      }
      else if( query > array[M] )
      {
        Console.WriteLine( "{0} > {1}", query, array[M] );

        L = M + 1;
      }
      else // query < array[M]
      {
        Console.WriteLine( "{0} < {1}", query, array[M] );

        R = M - 1;
      }


    } // while

    return result_index;

  } // function

  public static void Main()
  {

    BinarySearch bS = new BinarySearch();

    RandomNum rNA = new RandomNum();


    // ***** Tests for binarysearch() *****
    //
    //
    // int[] array = new int[] { 3,4,6,8,9,10,12,13,15 }; // length 9 & total digits 8

    // All searchable queries:
    //
    // bS.binarysearch( array, 3 );
    // bS.binarysearch( array, 4 );
    // bS.binarysearch( array, 6 );
    // bS.binarysearch( array, 8 );
    // bS.binarysearch( array, 9 );
    // bS.binarysearch( array, 10 );
    // bS.binarysearch( array, 12 );
    // bS.binarysearch( array, 13 );
    // bS.binarysearch( array, 15 );

    // Un searchable queries:
    //
    // bS.binarysearch( array, 2 );
    // bS.binarysearch( array, 5 ); // <--- problem resolved: Looping when L=2 & R=1
    // bS.binarysearch( array, 7 );
    // bS.binarysearch( array, 11 );
    // bS.binarysearch( array, 14 );
    // bS.binarysearch( array, 16 );

    // SORTED ARRAYS BUT WITH REPEATS: ( More Likely to Have Unsearchable Queries )
    //
    // COMPILE this Test like so: mcs BinarySearch.cs ../Complementing\ Classes/RandomNum.cs ../Sorting\ Algorithms/InsertionSort.cs ../Complementing\ Classes/IO.cs
    //
    // Random Class - System Namespace
    //
    // https://msdn.microsoft.com/en-us/library/system.random(v=vs.110).aspx
    //
    Random r = new Random();

    // Info on Random.Next(int max)
    //
    // https://msdn.microsoft.com/en-us/library/zd1bc8e5(v=vs.110).aspx
    int test_size = r.Next(11);

    // random number generator for array RandNumArrGen( array_size, max_value);
    //
    int[] test = rNA.RandNumArrGen( test_size, r.Next(101) );

    int[] sorted_test = new int[ test_size ]; // sorted array holder

    // Using Insertion sort, but could use either Bubble or Selection sort:
    //
    InsertionSort insertS = new InsertionSort();

    sorted_test = insertS.insertsort( test ); // storing the sorted array

    bS.binarysearch( sorted_test, r.Next(101) );

 } // main

}// class
