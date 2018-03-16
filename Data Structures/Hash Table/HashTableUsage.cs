/*
 * Hash table: implements an associative array abstract data type, a structure that can map keys to values.
 *
 *
 */
using System;
using System.Collections; // Hashtable class (.NET Framework Base Class Library)

public class HashTableUsage
{
  // this belongs to HashTableUsage type/class
  private static Hashtable dictionary = new Hashtable();

  /// <summary>
  ///   The main entry point for the application
  /// </summary>
  public static void Main()
  {
    // Adding contenct to the hashtable, indexed by a string key
    dictionary.Add( "Arduous", "Involving or requiring strenuous effort." );
    dictionary.Add( "Beamish", "Beaming with happiness, optimism, or anticipation." );
    dictionary.Add( "Chicanery", "The use of deception or suberfuge to achieve one's purpose." );

    Console.WriteLine("What is the word you would like to learn about?");

    string query = Console.ReadLine();
    // Accessing a particular key
    if( dictionary.ContainsKey( (string)query ) ) // query does not need to be casted as a string
    {
      Console.WriteLine("Query found: {0} ", query);
      string definition = (string)dictionary[query];
      Console.WriteLine("The definition of {0} is: {1}", query, definition);
      // this does not take care of lower and upcase word queries !
    }
    else
    {
      Console.WriteLine("Your query \"{0}\" is not in the dictionary.", query);
    }

    // Stepping through all items in the Hashtable
    //
    // The Keys property: returns a collection of keys stored in the Hashtable
    Console.WriteLine("\nPrinting the dictionary:\n");

    foreach( string key in dictionary.Keys )
    {
      Console.WriteLine( "The definition of {0} is {1}\n", (string)key, dictionary[key].ToString() );
    }



    // Notice the following OUTPUT:
    //
    // Printing the dictionary:
    //
    // The definition of Beamish is Beaming with happiness, optimism, or anticipation.
    //
    // The definition of Arduous is Involving or requiring strenuous effort.
    //
    // The definition of Chicanery is The use of deception or suberfuge to achieve one's purpose.
    //
    //  Explaination:
    //
    // Even though the data was inserted into the Hashtable
    // in the order "Arduous," "Beamish," "Chicanery",
    //
    // The Hashtable Class's [Hash Function] has caused a different order
    // when retrieving the values.
    // i.e. GetHashCode(), which is defined in the System.Object class
    //


  } // main
}
