using System;
using System.Collections;

public class InsertionSort
{

  /* A function that takes an array of unsorted numbers
   * sorts it in ascending order
   *
   * Starts with comparing the second index e.g. a[1] as the current element.
   * Compares this with its prev elements ( is the prev larger than current ? ) e.g a[3] compares with a[2], a[1] and a[0]
   * Keep doing until the current element reaches the end e.g. a[ a.Length -1 ]
   *
   * https://www.programiz.com/dsa/insertion-sort
   *
   *
   * Compile this way:
   * $ mcs InsertionSort.cs RandomNum.cs IO.cs
   *
   *
   * insertsort() is incomplete
   *
   * insertsort1() works and is the common implementation.
   */

  // Class variables:
  private InOut<int> inOut = new InOut<int>(); // private by default if not specified



  public void insertsort( int[] numbers )
  {
    bool bigger = false;

    // printing arrays https://stackoverflow.com/questions/3700448/how-to-print-contents-of-array-horizontally
    Console.WriteLine( "The unsorted array [ {0} ]" ,string.Join(", ", numbers) );

    // converting the numbers Array to an ArrayList
    ArrayList numbersList = new ArrayList();
    numbersList.AddRange( numbers );

    // prints the arraylist:
    inOut.arrayListPrint( numbersList );


    for( int i = 1; numbersList.Count > i; i++ )
    {

      int j = i;

      while( j > 0 )
      {
        Console.WriteLine("i = {0}", i);
        Console.WriteLine("Comparing {0} with {1}", numbersList[i], numbersList[j-1]);


        if( Convert.ToInt32( numbersList[j-1] ) > Convert.ToInt32( numbersList[i] ) )
        {
          numbersList.Insert( j, numbersList[i] );
          inOut.arrayListPrint( numbersList );

          numbersList.RemoveAt( i + 1 );
          Console.Write("First Element removed: ");
          inOut.arrayListPrint( numbersList );
          //continue;
        }



        // if( Convert.ToInt32( numbersList[j] ) > Convert.ToInt32( numbersList[i] ) )
        // {
        //   bigger = true;
        // }
        // else
        // {
        //   bigger = false;
        // }

        //
        // if( !bigger )
        // {
        //   numbersList.Insert( j + 1 ,numbersList[i] );
        //   numbersList.RemoveAt( i + 1 );
        //   inOut.arrayListPrint( numbersList );
        // }

        j--;
      } //while


    } //for

  } //insertsort()


  public void insertsort1( int[] array )
  {

  Console.WriteLine( "The unsorted array [ {0} ]" ,string.Join(", ", array ) );

  for( int i = 1; array.Length > i; i++ ) // starting at the second element so we can use its prev to compare
  {
    int j = i;

    int current = array[i]; // the current element to compare with its previous elements

    Console.WriteLine( "Comparing array[{0}] = {2} < array[{1}] = {3}" , i, (j-1), current, array[ j-1 ] );

    while( j > 0 && array[ j-1 ] > current )
    {
      array[ j ] = array[j-1]; // put larger value in current's position i.e. j = i so array[j] == array[i]

      j--; // move on to the prev's prev

      Console.WriteLine( "The changed array [ {0} ]" ,string.Join(", ", array ) );
    }

    // j is whatever index that when (prev) { array[ j-1 ] > current } is NOT TRUE
    // This below is unchanged if while loop is not satisfied, since j = i and array[j] == current
    Console.WriteLine( "j={0}",j );
    array[j] = current; // this is so that if the while loop does statisfy then need to replace
    Console.WriteLine( "This iteration's array [ {0} ]" ,string.Join(", ", array ) );
  }
    Console.WriteLine("*** *** *** *** *** ***");
    Console.WriteLine( "The Insertion Sorted array: [ {0} ]" ,string.Join(", ", array ) );

  }


 public static void Main()
 {
   InsertionSort insertS = new InsertionSort();

   RandomNum rNA = new RandomNum();

   // int[] array = new int[] { 3,1,4,6,7,5,2 };

   // random number generator for array (initialize & instantiate)
   int[] test = rNA.RandNumArrGen(10, 100);
   int[] test2 = rNA.RandNumArrGen(10, 50);
   int[] test3 = rNA.RandNumArrGen(10, 25);


   insertS.insertsort1( test );

   insertS.insertsort1( test2 );

   insertS.insertsort1( test3 );


 } //main

} //class


// for( int j = i - 1; j > 0; j-- )
// {
//   Console.WriteLine("i Index {0} has element {1}", i, numbers[i]);
//
//   Console.WriteLine("j Index {0} has element {1}", j, numbers[j]);
//
//   Console.WriteLine("Comparing {0} with {1}", numbers[i], numbers[j]);
//
// }//for
