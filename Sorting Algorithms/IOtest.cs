/*
 * Main function to test IO.cs
 *
 */

public class IOtest
{

  public static void Main(string[] args)
  {

      InOut<int> hello = new InOut<int>();

      hello.AskUser<int>();

      hello.Ask4Double();

  }

}
