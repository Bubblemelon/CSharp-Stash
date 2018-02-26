using System;
using System.Collections;


public class SelectionSort
{
  /*
   * A function that takes an array of unsorted numbers.
   * Returns the array sorted in ascending order.
   *
   * Starts by finding the minimum
   * element (the smallest) in the unsorted portion of the array.
   *
   * Places the minimum at the end of the sorted portion.
   *
   * Iteration ends when it reaches the last element in the unsorted array.
   */

  public void selectionsort( int[] numbers )
  {
    int current = 0; //current element

    int j = 0; // inner loop limiter

    int temp = 0; // temporary element value store

    int minvalue_index = 0; // saves the minimum value's index position

    Console.WriteLine( "The unsorted array: [ {0} ]" ,string.Join(", ", numbers ) );

    for( int i = 0; numbers.Length - 1 > i; i++ )
    {
      current = numbers[i];

      // Console.WriteLine( "Current: {0}", current );

      j = 1 + i;

      for( ; numbers.Length > j; j++ )
      {

        // Console.WriteLine( "Comparing: {0} > {1}", current, numbers[j] );

        if( numbers[j] < current )
        {
          current = numbers[j];
          minvalue_index = j;

          // Console.WriteLine( "New current {0}", current );
          // Console.WriteLine( "minvalue_index {0}", minvalue_index );
        }

      }

      // Console.WriteLine( "The array again: [ {0} ]" ,string.Join(", ", numbers ) );

      temp = numbers[i];

      // Console.WriteLine( "Putting min value at the end of sorted portion:" );
      numbers[i] = current;
      // Console.WriteLine( "What this looks like: [ {0} ]" ,string.Join(", ", numbers ) );

      // Console.WriteLine( "Putting old current value at the minimum postion:" );
      numbers[ minvalue_index ] = temp;

      // Console.WriteLine( "The partially sorted array: [ {0} ]" ,string.Join(", ", numbers ) );
    }

    Console.WriteLine( "The Selection Sorted array: [ {0} ]" ,string.Join(", ", numbers) );

  }

  public static void Main()
  {
    SelectionSort selectS = new SelectionSort();

     RandomNum rNA = new RandomNum();

     ExecutionTimer eT = new ExecutionTimer(); // to test execution time


    // int[] array = new int[] { 3,1,4,6,7,5,2 };

    // random number generator for array (initialize & instantiate)
    //int[] test = rNA.RandNumArrGen(5, 100);
    int[] test2 = rNA.RandNumArrGen(10, 100);
    // int[] test3 = rNA.RandNumArrGen(10, 25);

    // ***** Tests for selectionsort() *****
    //

    eT.startTimer();

    selectS.selectionsort( test2 );

    eT.stopTimer();
    eT.elapsedTime();

  } //main

}// class
