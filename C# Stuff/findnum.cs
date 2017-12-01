using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class findnum {

  /*
   * Complete the function below.
   */
      static string findNumber(int[] arr, int k) {

        for( int i = 0; i < arr.Length; i++)
        {

          if( arr[i] == k )
            return "YES";

        }
            return "NO";
      }

      static void Main(String[] args) {
            //  string fileName = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
            //  TextWriter tw = new StreamWriter(@fileName, true);
            //  string res;
             //
            //  int _arr_size = 0;
            //  _arr_size = Convert.ToInt32(Console.ReadLine());
            //  int[] _arr = new int [_arr_size];
            //  int _arr_item;
            //  for(int _arr_i = 0; _arr_i < _arr_size; _arr_i++) {
            //      _arr_item = Convert.ToInt32(Console.ReadLine());
            //      _arr[_arr_i] = _arr_item;
            //  }
             //
            //  int _k;
            //  _k = Convert.ToInt32(Console.ReadLine());
             //
            //  res = findNumber(_arr, _k);
            //  tw.WriteLine(res);
             //
            //  tw.Flush();
            //  tw.Close();
         }

  }
