using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
  public class BasicTree
  {
    private TreeNode _root;

    private class TreeNode
    {
      public int data;
      public TreeNode left;
      public TreeNode right;
    }

    public BasicTree(int[] arr)
    {
      // TODO: use a custom sorting algo
      Array.Sort(arr);

      InsertBreadthFirst(arr, _root, 0);
    }

    private TreeNode InsertBreadthFirst(int[] arr, TreeNode node, int i)
    {
      if (i < arr.Length)
      {
        // create a new temp node and assign it to the root
        TreeNode temp = new TreeNode();
        temp.data = arr[i];
        _root = temp;

        // insert left child
        _root.left = InsertBreadthFirst(arr, _root.left, 2 * i + 1);

        // insert right child
        _root.right = InsertBreadthFirst(arr, _root.right, 2 * i + 2);
      }
      return _root;
    }
  }

  
}
