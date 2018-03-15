/*
 * Relating to BinaryTreeNode:
 *
 * (1) A binary tree's nodes have [at most] two children, referred to as left(1st) and right(2nd)
 * (2) Extend the Node class (inherits)
 * (3) Exposes two properties —Left and Right—; this operates on the base class's Children property
 */


public class BinaryTreeNode<T> : Node<T>
{

  //contructors:

  // this refers to node's default constructor
  // calls Node<T>.Node()
  //
  public BinaryTreeNode() : base()
  {
  }

  // calls Node<T>.Node(T data, NodeList<T> children)
  //
  public BinaryTreeNode(T data) : base(data, null)
  {
  }

  // parent node (stores data)
  //
  public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
  {
      base.Data = data; // Node's property

      NodeList<T> children = new NodeList<T>(2); // has two children - starting size (currently null or 0)

      // left and right are nodes (formed from Node class) each with a data value

      children[0] = left;
      children[1] = right;

      // Node Class 's lowercase children saves BinaryTreeNode's lowercase children
      base.Children = children;
  }

  // BinaryTreeNode's Left property
  //
  public BinaryTreeNode<T> Left
  {
      get
      {
         // ensures that the base class's i.e. Node Class Children NodeList has been created
          if (base.Children == null) // no children to get
              return null;
          else
              return (BinaryTreeNode<T>) base.Children[0]; // stored by Node Class 's lowercase children (retrive 1st node)
      }
      set
      {
          if (base.Children == null) // no children yet so make some
              base.Children = new NodeList<T>(2);

          base.Children[0] = value; // sets the Left Node as the 1st node
      }
  }

  // BinaryTreeNode's Right property
  //
  public BinaryTreeNode<T> Right
  {
      get
      {
          // ensures that the base class's i.e. Node Class Children NodeList has been created
          if (base.Children == null) // no children to get
              return null;
          else
              return (BinaryTreeNode<T>) base.Children[1]; // stored by Node Class 's lowercase children (retrive 2nd node)
      }
      set
      {
          if (base.Children == null) // no children yet so make some
              base.Children = new NodeList<T>(2);

          base.Children[1] = value; // sets the Left Node as the 2nd node
      }
  }

} //class
