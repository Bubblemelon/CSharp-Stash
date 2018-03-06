/*
 * Main function to test IO.cs
 *
 */

using System.Collections.Generic; // for IEnumerable<int>

public class IOtest
{

  public static void Main(string[] args)
  {

      InOut<int> hello = new InOut<int>();

      // hello.AskUser<int>();
      //
      // hello.Ask4Double();
      //
      // hello.LineCountLoop();


      RandomNum rN = new RandomNum();

      //rNA.showArrayValues( rNA.RandNumArrGen(10, 100) );

      IEnumerable<int> sample = rN.sequenceIEnumGen(1,10);
      hello.showEnumSeq( sample );

      int[] someArray = rN.sequenceArrGen( 1,9, rN.operationSeqGen() );
      hello.showArrayValues( someArray );

  }

}
