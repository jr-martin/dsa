using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
  public class BinarySearchTree
  {
    public BstNode root {get;set;}


    #region Add

    public BstNode Add(int value)
    {
      // create new node
      BstNode nodeToAdd = new BstNode { data = value };

      root =  Add(root, nodeToAdd);

      return root;
    }

    // recursive (logN) - the other Add function is the public driver that can be called
    private BstNode Add(BstNode currentNode, BstNode nodeToAdd)
    {
      // if currentNode is empty simply set the currentNode to the node to be added
      if (currentNode == null)
      {
        currentNode = nodeToAdd;
        return currentNode;
      }

      // otherwise, navigate down the tree by recursively calling this method on the child nodes
      if (nodeToAdd.data < currentNode.data)
      {
        currentNode.left = Add(currentNode.left, nodeToAdd);
      }
      else if (nodeToAdd.data > currentNode.data)
      {
        currentNode.right = Add(currentNode.right, nodeToAdd);
      }
      // this tree does not allow duplicates
      else if (nodeToAdd.data == currentNode.data)
      {
        throw new ArgumentOutOfRangeException("Duplicate values not allowed in this BST implementation");
      }
      return currentNode;
    }

    #endregion


    #region Search

    public BstNode Search(int value)
    {
      return Search(root, value);
    }

    private BstNode Search(BstNode currentNode, int value)
    {
      BstNode node = null;

      // tree is empty if root is null
      if (currentNode == null)
      {
        return node;
      }

      // if smaller, go left
      if (value < currentNode.data)
      {
        return Search(currentNode.left, value);
      }

      // if larger, go right
      if (value > currentNode.data)
      {
        return Search(currentNode.right, value);
      }

      // if equal, return
      else if (value == currentNode.data)
      {
        node = currentNode;
      }

      return node;
    }

    #endregion


    #region Remove

    public void Remove(int value)
    {
      Remove(root, value);
    }

    private BstNode Remove(BstNode currentNode, int value)
    {
      throw new NotImplementedException(); //wip

      // tree is empty if root is null
      if (currentNode == null)
      {
        return currentNode;
      }

      // if smaller, go left
      if (value < currentNode.data)
      {
        return Remove(currentNode.left, value);
      }
      // if larger, go right
      if (value > currentNode.data)
      {
        return Remove(currentNode.right, value);
      }
      // if equal
      else if (value == currentNode.data)
      {
        // is a leaf node, set the current node to null
        if (currentNode.left == null && currentNode.right == null)
        {
          currentNode = null;
        }

        // if two children
        else if (currentNode.left != null && currentNode.right != null)
        {
          // get the rightmost current node and shift it up
          currentNode.data = GetMinValue(currentNode.right);

          // "remove" the right node (by shifting it up the tree)
          currentNode.right = Remove(currentNode.right, currentNode.data);
        }
        else
        {
          // if only one child - move the child up
          if (currentNode.right == null)
          {
            currentNode = currentNode.left;
          }
          if (currentNode.left == null)
          {
            currentNode = currentNode.right;
          }
        }
        
      }

      return currentNode;
    }

    private int GetMinValue(BstNode currentNode)
    {
      int smallChildValue = currentNode.data;

      while (currentNode.left != null)
      {
        smallChildValue = currentNode.left.data;
        currentNode = currentNode.left;
      }

      return smallChildValue;
    }

    #endregion
  }

  public class BstNode
  {
    public int data;
    public BstNode left;
    public BstNode right;
  }
}
