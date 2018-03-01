using System;

using System.Collections.Generic; // for enumerable return value
using System.Linq; // https://msdn.microsoft.com/en-us/library/system.linq.enumerable.range(v=vs.110).aspx

public class RandomNum
{

  // Public Variables

  IEnumerable<int> ranged;

  /*
   * Generates random numbers in an array of specified size "arrSize"
   *
   * and requires a value less than the maximum that each index will receive
   * " maxiValuePerIndex "
   *
   *
   * maxiValuePerIndex is exclusive!!!!
   */
  public int[] RandNumArrGen( int arrSize, int maxiValuePerIndex)
  {

    int[] array = new int[ arrSize ];

    // initialize and instantiate Random Class object
    Random rnd = new Random();

    // The random generator
    // is seeded from the system clock
    // https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number-in-c

    for( int i = 0 ; i < array.Length; i++ )
    {
      // Next(MAX) Returns a non-negative random integer
      // that is less than the specified maximum
      array[i] = rnd.Next( maxiValuePerIndex );

    }

    return array;

  }
  /*
   * Sequence Generator
   *
   * min = minimum range value
   * max = maximum range value
   * op  = operator
   * opnd = operand
   *
   */

  public IEnumerable<int> sequenceIEnumGen( int min, int max )
  {
    /* Notes on IEnumerable:
    // It is similar to a LIST - like the following array:
    // string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

    // string last = fruits.Last(); == "grape"

    try
    {
        int numberOfFruits = fruits.Count();
        Console.WriteLine(
            "There are {0} fruits in the collection.",
            numberOfFruits);

            // total 6 fruits
    }
    catch (OverflowException)
    {
        Console.WriteLine("The count is too large to store as an Int32.");
        Console.WriteLine("Try using the LongCount() method instead.");
    }

    // MORE notes on IEnumerable:

    char[] apple = { 'a', 'p', 'p', 'l', 'e' };

    char[] reversed = apple.Reverse().ToArray();

    foreach (char chr in reversed)
    {
        Console.Write(chr + " ");  ==      e l p p a
    }
    Console.WriteLine();


    */

    // Sequential range from min to max
    IEnumerable<int> range = Enumerable.Range(min, max);
    //Return Value
    //Type: System.Collections.Generic.IEnumerable<Int32>


    // Sequential range from min to max
    // and then select their squares.
    // IEnumerable<int> squares = Enumerable.Range(min, max).Select(x => x * x);


    return range;

  }

  /*
   * Improvement implementation for Sequence Generator
   *
   */

  public void newSeqArrGen()
  {

  }



  /*
   * Sequence Generator -- returns an ARRAY
   *
   * min = minimum range value
   * max = maximum range value
   *
   * op  = operator or condition e.g. X * X (squares)
   *
   * must work with this function: operationSeqGen()
   *
   * IMPROVEMENT - make sequenceArrGen() a whole function with operationSeqGen()
   *             - instead of one calling the other !
   *             - this improvement is being implemented in newSeqArrGen()
   */

   public int[] sequenceArrGen( int min, int max, Func<int,bool> op)
   {
     // Sequential range from min to max
     ranged = Enumerable.Range(min, max);
     //Return Value
     //Type: System.Collections.Generic.IEnumerable<Int32>

     int[] array = ranged.Where(op).ToArray();


     // returning a generic type:
     //
     // https://stackoverflow.com/questions/9808035/how-do-i-make-the-return-type-of-a-method-generic
     // return (T) Convert.ChangeType(array, typeof(T));

     return array;
   }


/*
 * function to complement sequenceArrGen
 *
 * odds
 *
 * squares Func<int,int> ( DOES NOT WORK )
 *
 * evens
 *
 * user input
 */
public Func<int,bool> operationSeqGen()
{
  // string s; === string s = null;

  string userInput = "";
  string lambdaInput = "";
  int i = 0;

  do
  {
    if( i > 0 )
      Console.WriteLine("Your input was empty!");

    userInput = "";
    // ask user for type of input prompt

    Console.WriteLine("\nWhat's the pattern of the sequence?\n");

    Console.WriteLine("Here are your options");
    Console.WriteLine("For odd numbers type: odd");
    Console.WriteLine("For even numbers type: even");
    Console.WriteLine("For squared numbers type: square");
    Console.WriteLine("For your own lambda function type: mine" );
    Console.WriteLine("NOTE - For mine option: must be of type Func<int,bool>" );

    userInput = Console.ReadLine();

    i++;

  } while( userInput == "");


  switch( userInput )
  {
    case "odd":
      Console.WriteLine("Your input = ODD ");
      Func<int, bool> odd = x => x %2 == 1;
      return odd;
      break;

    case "even":
      Console.WriteLine("Your input = EVEN ");
      Func<int, bool> even = x => x%2 == 0;
      return even;
      break;

    case "square":  /// problem here - may need to pass in enumerable instead of lambda functions !!!
      Console.WriteLine("Your input = SQUARE ");
      Func<int, bool> square = x => x*x == x*x; // this does not manipulate the elements in IEnumerable
      // cont.. it only returns the ones that satisfies the condition
      return square;
      break;

    // case "mine":
    //   Console.WriteLine("Your input = MINE ");
    //   Console.WriteLine("Please type the lambda function of the type Func<int,bool>");
    //   lambdaInput = Console.ReadLine();
    //
    //

    /*
     * Issues default: look at comments below
     *
     */

    default:
      Console.WriteLine("Invalid input !!!");
      operationSeqGen(); // The following code below runs right after correct userInput ( as the first return )
      //& ( the second return does not happen ! - from the second prompt input )
      Func<int, bool> someFunc = x => x == x; // dummy function to statisfy return type
      return someFunc;
      break;
  }



} //main

  /* To Test functions in this class
   *
   *
   */

  // public static void Main()
  // {
  //
  //   RandomNum RN = new RandomNum();
  //
  //   //rNA.showArrayValues( rNA.RandNumArrGen(10, 100) );
  //
  //   IEnumerable<int> sample = RN.sequenceIEnumGen(1,10);
  //   RN.showEnumSeq( sample );
  //
  //   int[] someArray = RN.sequenceArrGen( 1,9, RN.operationSeqGen() );
  //   RN.showArrayValues( someArray );
  //
  //
  //
  // }


} //class
