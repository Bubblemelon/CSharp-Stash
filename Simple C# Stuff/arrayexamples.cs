using System;
using System.Collections;

// Examples of:
//
// (1) Multidimensional Arrays:
//
// (2) Jagged Arrays

public static void Main()
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
  //
  // Differences between two ways of Initializing an Array:
  //
  // Array array = Array.CreateInstance(typeof(int), 4)
  // vs.
  // int[] array = new int[4];
  //
  // https://stackoverflow.com/questions/43580956/difference-between-array-createinstance-and-using-the-new-operator-to-create-new

  RandomNum rN = new RandomNum();

  int[] test = rN.RandNumArrGen( test_size, r.Next(101) ); //array_size, max number ( not including )

  //
  // Jagged Arrays

} // Main
