using System;
using System.Collections;

// Examples of:
//
// (1) Multidimensional Arrays:
//
// (2) Jagged Arrays

public class ArrayExamples
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
  public int[ , ] table( int[] array )
  {
    int element = 0;
    int column_numbers = 2;

    int[,] result = new int[ array.Length, column_numbers ];
    int count = 1;

    int[] checked_elements = new int[ array.Length ];

    // to have current be the first element to the last
    for( int i = 0; array.Length > i; i++ )
    {
      int current = array[i];

      if( i > 1 ) // starting form the second element
      {

        // to go through all checked_elements
        for(int j = 0; checked_elements.Length > j; j++)
        {

          // seeing if an element has already been checked
          if( checked_elements[j] != current )
          {

            // going through the comparison with current
            for( int k = i+1; array.Length + 1 > k; k++ )
            {

              // looking for repeats
              if( current == array[k] )
              {
                count++;

              } // if

              for( int row = 0; array.Length > row; row++ )
              {
                for( int column = 0; 2 > column_numbers; column++ )
                {
                  if( column == 0 )
                  {
                    result[ row, column ] = current;
                  }
                  else
                  {
                    result[ row, column ] = count;
                  }
                } // for

              } // for


            } // for

          } // if

        } // for

      } // if


    } //for

    return result;

  } // funct

  public static void Main()
  {

    RandomNum rN = new RandomNum();

    int[] test = rN.RandNumArrGen(10, 11); //array_size, max number ( not including )

    Console.WriteLine( "The numbers: {0} " , string.Join(", ", test) );


    //
    // Multidimensional Arrays
    //
    ArrayExamples aE = new ArrayExamples();

    int[,] test_table = new int[ test.Length , 2 ];

    // test_table = aE.table( test ); <--- problem 


    InOut<int> iO = new InOut<int>();

    iO.printMultiArray( test_table );
    //
    // Jagged Arrays
    //

  } // Main

} // class
