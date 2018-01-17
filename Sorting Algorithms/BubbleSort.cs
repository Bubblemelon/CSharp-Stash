using System;
//using RandomNum; [ only do this when classes are in difference namespaces ]

/*
 * Sorts smallest number to the largest ( ascending order )
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

} while ( swapped );

}




  public static void Main()
  {
    RandomNum rNA = new RandomNum();

    BubbleSort bs = new BubbleSort();

    InOut<int> hello = new InOut<int>(); // generic class

    Console.WriteLine( "Input the quanity or amount of numbers to sort: " );

    int size = hello.AskUserMore(); // NON-generic function

    Console.WriteLine( "Input the upper limit of the range that the generator can randomize: " );

    int max = hello.AskUserMore(); // NON-generic function

    // random number generator for array (initialize & instantiate)
    int[] test = rNA.RandNumArrGen(size, max);

    rNA.showArrayValues( test );

    bs.bubblesorting( test );

    System.Console.WriteLine("After sorting: ");

    rNA.showArrayValues( test );


  }



}
