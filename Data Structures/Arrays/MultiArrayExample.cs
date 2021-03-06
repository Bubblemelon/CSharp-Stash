using System;
using System.Collections;


// Note: EMPTY Array vs. NULL Array

/*
 *** An Empty Array will have Zeros (0) as elements.
 *
 * int[] array = new int[ 7 ];
 *
 * Console.WriteLine( array[0] == 0 ); // True
 *
 * Console.WriteLine( "Print: [{0}]", string.Join(", ", array) );
 *
 * Print: [0, 0, 0, 0, 0, 0, 0]
 *
 * NOT NULL Array:
 * Console.WriteLine( array == null ); // False
 *
 *
 *** A Null Array can be initialized two ways:
 *
 * static int[] null_array; <-- class instance
 *
 * int[] null_array2 = null;
 *
 * Console.WriteLine( null_array2 == null ); True
 *
 * Console.WriteLine( null_array == null ); True
 *
 * Cannot print a NULL Array!
 */

public class MultiArrayExample
{

  // Multidimensional Arrays:
  //
  // Can specify up to 32 dimensions, but you will rarely need more than three
  // e.g. two dimensions (a table) and three dimensions (a cube)
  //
  // The Rank of an array is the number of dimensions in the array.
  //
  // int[,] array2D = new int[,]  <--- [ row, column ]
  //
  // A Two-dimensional array:
  // int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
  // This has 4 rows and 2 columns
  //
  // Differences between two ways of Initializing an Array:
  //
  // Array array = Array.CreateInstance(typeof(int), 4)
  // vs.
  // int[] array = new int[4];
  //
  // https://stackoverflow.com/questions/43580956/difference-between-array-createinstance-and-using-the-new-operator-to-create-new
  //


  // counts the repeated numbers in an array and then stores in a 2D array.
  //
  // This method does not use any library functions to simplify the process !
  //
  public int[ , ] table( int[] array )
  {

    // col 0 for number(element) & col 1 for element's count
    int column_numbers = 2;

    // return multi-array
    int[,] result = new int[ array.Length, column_numbers ];

    // stores all checked elements ( empty array - all initial elements will be Zero '0')
    int[] checked_elements = new int[ array.Length ];

    bool is_1st_zero = false;  // remembers the pass for the first zero


    // to have current be the first element to the last
    for( int i = 0; array.Length > i; i++ )
    {
      bool element_checked = false;

      int count = 1; // set then reset count for next iteration

      // Console.WriteLine( "Starting count: {0}", count );

      int current = array[i];

      // Console.WriteLine( "i is: {0} & Current: {1}", i, current );

      if( current == 0 )
      {
        // Console.WriteLine( "current {0} is a zero!", current );

        if( !is_1st_zero ) // if is_1st_zero == false
        {
          // move on to counting -- ignores he else below
          is_1st_zero = true; // 1st zero is now recognized

          // Console.WriteLine( "1st zero is noted! {0}", is_1st_zero );
        }
        else // if is_1st_zero == true
        {
          // Console.WriteLine( "Not the 1st Zero" );
          // skip counting -- continue with the next current
          continue;
        }

      }
      else // any number other than zero ( current != 0 )
      {
        // Console.WriteLine( "Current {0} was not zero", current );

        // Console.WriteLine( "Comparing current {0} with checked_elements", current );

        // compare current with already checked elements
        for(int j = 0; checked_elements.Length > j; j++)
        {

          // Console.WriteLine( "Comparing current {0} with {1}", current, checked_elements[j] );

          if( current == checked_elements[j] ) // current number was already checked !
          {
            // Console.WriteLine( "Current element {0} already checked: [{1}]", current, string.Join(", ", checked_elements) );

            element_checked = true; // element already checked

            break; // exit this loop
          }

        }

        if( element_checked ) // skip count & move to the next current ( from the top )
        {
          continue;
        }

        // j loop finishes, meaning current has not been checked:
        //
        // Console.WriteLine( "Current element {0} is not within: [{1}]", current, string.Join(", ", checked_elements) );

        checked_elements[i] = current;

        // Console.WriteLine( "Add Current element {0} to checked_elements: [{1}]", current, string.Join(", ", checked_elements) );


      }// large else i

      //
      // Comparing and counting repeats:
      //
      // if code does not hit "continue" then all will fall here:

      for( int k = i+1; array.Length > k; k++)
      {
        if( current == array[k] )
        {
          // Console.WriteLine( "count Incremented" );
          count++;
        }
      }// for k

      // Console.WriteLine( "{0} current's count: {1}", current, count );

      // to store element and its count
      //
      // row's limit for each iteration:

      int row = i;
      int row_limit = row + 1;
      for( ; row_limit > row; row++ )
      {
        for( int column = 0; 2 > column; column++ )
        {
          if( column == 0 )
          {
            result[ row, column ] = current;

            // Console.WriteLine( "row {0} column {1} = {2}", row, column, result[ row, column ] );
          }
          else
          {
            result[ row, column ] = count;

            // Console.WriteLine( "row {0} column {1} = {2}", row, column, result[ row, column ] );
          }
        } // column
      } // row

      // When col and row loop finishes,
      // the print result above looks like this: [ 3,4,0,3,3,5,1,1 ]
      //
      // 3	3
      // 4	1
      // 0	1
      // 0	0 <-- need to be removed
      // 0	0 <-- need to be removed
      // 5	1
      // 1	2
      // 0	0 <-- need to be removed

    } // Large for i


    // This is Outside of the large i for loop !!!

    return result;

  } // funct

  // to solve the above problem with the zeros: look at the print output above!
  public int[ , ] zeroRemoval( int[ , ] result )
  {

  // Count the number of row and column elements that are zero:
  //
  // Remember how result was initialized:
  // int[,] result = new int[ array.Length, column_numbers ];

  int rowheight = result.GetLength(0); // Gets the first dimension size ( the row )

  int zeros = 0;

  for( int r = 0; rowheight > r; r++ )
  {
   for( int c = 0; 1 > c; c++)
   {
  	 if( result[ r , c ] == 0 && result[ r , (c + 1) ] == 0 )
  	 {
  		 zeros++;
  	 }
   }
  }

  // Console.WriteLine( "zeros {0}", zeros );

  int newRowHeight = rowheight - zeros; // new int[,] array without these zeros

  // Console.WriteLine( "newRowHeight {0}", newRowHeight );

  // to store the multi array that does not have the zeros problem:
  int[,] new_result = new int[ newRowHeight , 2 ];  // row , column

  int skips = 0;

  // putting the values from result into new_result
  for( int row = 0; (newRowHeight + skips) > row; row++ )
  {

  // Console.WriteLine( "row: {0}", row);

   for( int col = 0; 1 > col; col++)
   {
     // Console.WriteLine( "{0} & {1}", result[ row , col ], result[ (row ) , (col + 1) ] );

     if( result[ (row ) , col ] == 0 && result[ row  , (col + 1) ] == 0 )
     {
      // Console.WriteLine( "Double Zeros");

      skips++;

      break; // move on if its the section with just zeros
     }
     else
     {
       // Console.WriteLine( "row level: {0}", (row - skips) );

       new_result[ (row - skips) , col ] = result[ row , col ];  // at col 0

       new_result[ (row - skips) , ( col + 1 ) ] = result[ row  , (col + 1) ]; // at col 1

     }

   } // col
 } // row

  return new_result;

  }                                                                                                                                                                                                                                                                                          // zeroRemoval

  public static void Main()
  {

    RandomNum rN = new RandomNum();

    // random number sequence in an array:
    int[] test = rN.RandNumArrGen(10, 11); //array_size, max number ( not including )

    Console.WriteLine( "The numbers: [{0}] " , string.Join(", ", test) );

    // int[] test = { 9, 7, 2, 6, 6, 9, 9, 10, 4, 8 };
    // int[] test = { 3, 4, 0, 3, 3, 5, 1, 1 };


    MultiArrayExample aE = new MultiArrayExample();

    // to store return value:
    int[,] test_table = new int[ test.Length , 2 ];

    // test table function:
    test_table = aE.table( test );  //problem


    // to print return value:
     InOut<int> iO = new InOut<int>();

     Console.WriteLine( "Before zeros removal: ");
     iO.printMultiArray( test_table );

     // remove sections in the table that has zeros:
     test_table = aE.zeroRemoval( test_table );

     Console.WriteLine( "After just zeros removal: ");
     iO.printMultiArray( test_table );

  } // Main

} // class
