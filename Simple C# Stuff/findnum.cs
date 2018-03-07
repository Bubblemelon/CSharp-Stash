using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class findnum {

  /*
   *
   */
  static string findNumber(int[] arr, int k)
  {

    for( int i = 0; i < arr.Length; i++)
    {

      if( arr[i] == k )
        return "YES";

    }
        return "NO";
  }

  static void Main(String[] args)
  {

  }

  }
