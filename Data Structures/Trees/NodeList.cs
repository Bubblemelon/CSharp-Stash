/*
 * Relating to NodeList Class:
 *
 * (1) Represents the node's children
 * (2) Derived from the (inherits) Collection<T> class
 * (3) Contains a strongly-typed collection of Node<T> instances
 */
using System.Collections.ObjectModel;
// using System.Collections.Generic; // Collection<T>
// using System.Collections;

public class NodeList<T> : Collection<T> where T : Node<T>
{
  // Constructors:

  // Explains the use of the keyword "base":
  // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/base
  //

  // This constructor will call Collection<Node<T>>.Node()
  public NodeList() : base()
  {
  }

  // Creates a specified number of nodes in the collection
  public NodeList(int startSize)
  {
      // Add the specified number of items
      for (int i = 0; i < startSize; i++)
      {

        base.Items.Add( default(Node<T>) );
      }

    } //funct

    // Searches the collection for an element of a particular data value
    public Node<T> FindData(T value)
    {
       // Search the list for the value
       // Items: https://msdn.microsoft.com/en-us/library/ms132435(v=vs.110).aspx
       foreach (Node<T> node in Items)
       {
         if (node.Data.Equals(value)) // refering to Data Property in Node Class
         {
          return node;
         }

       }
       // If none found then return null
       return null;

     } //funct




} // class
