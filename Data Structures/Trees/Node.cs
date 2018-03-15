/*
 *
 * Relating to Node Class:
 *
 * (1) Represents a node in a general tree (adequate for any generic tree)
 * (2) Nodes can have an arbitrary number of children
 * (3) Contains a NodeList instance, represents the node's children
 * (4) A Generic class, allows during develop-time the type of data to store in the node
 *
 * https://msdn.microsoft.com/en-us/library/ms379572(v=vs.80).aspx
 *
 *
 * Uses for this class: [Reasons for being Generic]
 * (1) Classes that need nodes, don't have create its own specific node class.
 * (2) So other classes can inherit or borrow the functionality of
 * this Node class and extend this Node class to meet its particular needs.
 */

 public class Node<T>
 {
   //class variables:

   private T data; // to store a type of data in the node
   private NodeList<T> children = null; // a node's children

   // Default Constructor
   public Node()
   {
   }

   // Overriden Constructors:

   // Explains the use of colon ":" and "this" :
   // https://stackoverflow.com/questions/10852905/use-of-colon-in-c-sharp-constructor-header
   //
   // (Constructor Chaining) If this contructor is called, it will refer to the constructor below it i.e. public Node(T data, NodeList<T> children)
   public Node(T data): this(data, null)
   {
   }

   public Node(T data, NodeList<T> children)
   {
     // Explains the use of "this" within this scope and context
     //
     // Qualifies the private fields (in other words add value to), data and children
     this.data = data;
     this.children = children;
   }

   // Node's property
   // get and set accessors
   public T Data
   {
     get{ return data; }
     set{ data = value; }

   }

   // this property is limited to the containing class (i.e. Node<T>) or types derived (as in classes inheriting Node<T>) from the containing class.
   // https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance

   // Node's property
   // get and set accessors
   protected T Children
   {
     get{ return children; }
     set{ children = value; }
   }

 } // Node
