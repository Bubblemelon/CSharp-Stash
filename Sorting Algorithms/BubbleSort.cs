using System;
//using RandomNum; [ only do this when classes are in difference namespaces ]

/*
 * Sorts smallest number to the largest ( ascending order )
 *
 * Compares two elements at a time until the very end of the array
 * Keep doing this iteration until there are no swaps!
 *
 * http://www.algolist.net/img/sorts/bubble-sort-3.png
 *
 *
 * Compile this way:
 * $ mcs BubbleSort.cs RandomNum.cs IO.cs executiontimer.cs
 *
 */
public class BubbleSort
{

// function that takes an array of unsorted numbers
public void bubblesorting( int[] numbers )
{
  bool swapped;

do {

  swapped = false;

  for( int i = 0; i < numbers.Length - 1; i++ )
  {

    //compare left index value with right index value
    if( numbers[i] > numbers[i+1] )
    {
      // save the larger value
      int movingValue = numbers[i];

      // place smaller value to the left
      numbers[i] = numbers[i+1];

      // place lager value to the right
      numbers[i+1] = movingValue;

      // swapped completed
      swapped = true;
    }

  }

} while ( swapped ); // stops when this becomes false

}




  public static void Main()
  {
    RandomNum rNA = new RandomNum();

    BubbleSort bs = new BubbleSort();

    InOut<int> hello = new InOut<int>(); // generic class

    ExecutionTimer eT = new ExecutionTimer(); // to test execution time

    // Requires User's Interaction *** *** ***
    //
    // Console.WriteLine( "Input the quanity or amount of numbers to sort: " );
    //
    // int size = hello.AskUserMore(); // NON-generic function
    //
    // Console.WriteLine( "Input the upper limit (not inclusive) of the range that the generator can randomize e.g. 0 to ? : " );
    //
    // int max = hello.AskUserMore(); // NON-generic function
    //
    // // random number generator for array (initialize & instantiate)
    // int[] test = rNA.RandNumArrGen(size, max);
    //
    // rNA.showArrayValues( test );
    //
    // bs.bubblesorting( test );
    //
    // System.Console.WriteLine("After sorting: ");
    //
    // rNA.showArrayValues( test );
    //
    // End of Requires User's Interaction *** *** ***


    int[] test2 = rNA.RandNumArrGen(100, 100);
    rNA.showArrayValues( test2 );

    eT.startTimer();

    bs.bubblesorting( test2 );

    eT.stopTimer();
    eT.elapsedTime();

    rNA.showArrayValues( test2 );

    ////////////////////////////////
    // Time execution conclusion: //
    ////////////////////////////////
    //
    // RunTime 00:00:00.0000  ( for almost all tests with 100 elements )
    // Output:
    // 0 0 4 4 5 6 7 8 10 12 13 14 15 17 17 18 18 18 19 19 20 20 22 22 22 24 25 26 26 26 27 27 28 28 28 29 31 31 31 32 34 34 34 40 41 41 43 43 43 45 46 46 46 47 47 48 51 51 52 52 53 53 57 58 65 65 66 67 67 70 71 71 71 71 72 72 72 74 75 75 75 78 80 81 81 81 84 87 87 89 89 91 93 96 96 98 98 98 99 99
    //
  }



}
