using System;
using System.Diagnostics;
using System.Threading;

class ExecutionTimer
{
    // instance variables:
    private Stopwatch stopWatch = new Stopwatch();

    // starts the timer
    public void startTimer()
    {
      stopWatch.Start();
    }

    // stops the timer
    public void stopTimer()
    {
      stopWatch.Stop();
    }

    // prints the elapse time
    public void elapsedTime()
    {
      TimeSpan ts = stopWatch.Elapsed;
      string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
          ts.Hours, ts.Minutes, ts.Seconds,
          ts.Milliseconds);
      Console.WriteLine("RunTime " + elapsedTime);
    }

    // This whole example is from:
    //
    // https://msdn.microsoft.com/en-us/library/system.diagnostics.stopwatch.aspx
    //
    // static void Main(string[] args)
    // {
    //
    //     Stopwatch stopWatch = new Stopwatch();
    //     stopWatch.Start();
    //     Thread.Sleep(10000);
    //     stopWatch.Stop();
    //     // Get the elapsed time as a TimeSpan value.
    //     TimeSpan ts = stopWatch.Elapsed;
    //
    //     // Format and display the TimeSpan value.
    //     string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
    //         ts.Hours, ts.Minutes, ts.Seconds,
    //         ts.Milliseconds / 10);
    //     Console.WriteLine("RunTime " + elapsedTime);
    //
    // Output:
    // RunTime 00:00:10.00
    //
    // }
    // End of example

} // class
