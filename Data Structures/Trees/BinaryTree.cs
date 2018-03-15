/*
 * Relating to BinaryTree:
 *
 * A Generic class; the specified type for BinaryTree will be the type for BinaryTreeNode
 */

public class BinaryTree<T> : BinaryTreeNode<T> where T : Node<T>
{

  private BinaryTreeNode<T> root;

  //contructor
  public BinaryTree()
  {
    root = null;
  }

  public virtual void Clear()
  {
    root = null;
  }

  // BinaryTree<T> 's property
  //
  public BinaryTreeNode<T> Root
  {
    get{ return root; }
    set{ root = value; }
  }

} //class
