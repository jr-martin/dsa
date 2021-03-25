using System;
using DataStructures.LinkedLists;
using DataStructures.Hashtables;
using DataStructures.Trees;

namespace dsa
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Linked Lists");
      Console.WriteLine("-------------");
      DoSinglyLinkedList();
      DoDoublyLinkedList();

      Console.WriteLine("ArrayHashMap");
      Console.WriteLine("-------------");
      DoArrayHashtable();

      DoBasicTree();

      DoBst();
    }

    public static void DoSinglyLinkedList()
    {
      var singlyLinkedList = new SinglyLinkedList();
      singlyLinkedList.Add("1");
      singlyLinkedList.Add("2");
      singlyLinkedList.Add("3");
      singlyLinkedList.Add("4");
      singlyLinkedList.Add("5");
      singlyLinkedList.Add("6");
      singlyLinkedList.Add("7");
      singlyLinkedList.Add("8");
      singlyLinkedList.Add("9");
      singlyLinkedList.AddFirst("0");

      singlyLinkedList.Print();

      var foundSix = singlyLinkedList.Search("6");
      Console.WriteLine(foundSix);

      var foundZ = singlyLinkedList.Search("Z");
      Console.WriteLine(foundZ);

      Console.WriteLine("-------------");

      var deletedThree = singlyLinkedList.Delete("3");
      Console.WriteLine(deletedThree);
      singlyLinkedList.Print();

      Console.WriteLine("-------------");

      var deletedNine = singlyLinkedList.Delete("9");
      Console.WriteLine(deletedNine);
      singlyLinkedList.Print();

      Console.WriteLine("-------------");

      var singlyLinkedListTwo = new SinglyLinkedList();
      var deletedX = singlyLinkedListTwo.Delete("X");
      Console.WriteLine(deletedX);

      singlyLinkedListTwo.Add("Y");
      singlyLinkedListTwo.Print();
      var deletedY = singlyLinkedListTwo.Delete("Y");
      Console.WriteLine(deletedY);

      Console.WriteLine("-------------");
    }

    public static void DoDoublyLinkedList()
    {
      var doublyLinkedList = new DoublyLinkedList();
      doublyLinkedList.Add("1");
      doublyLinkedList.Add("2");
      doublyLinkedList.Add("3");
      doublyLinkedList.Add("4");
      doublyLinkedList.Add("5");
      doublyLinkedList.Add("6");
      doublyLinkedList.Add("7");
      doublyLinkedList.Add("8");
      doublyLinkedList.Add("9");
      doublyLinkedList.AddFirst("0");
      doublyLinkedList.Print();

      Console.WriteLine("-------------");

      var deletedThree = doublyLinkedList.Delete("3");
      Console.WriteLine(deletedThree);
      doublyLinkedList.Print();

      Console.WriteLine("-------------");
    }

    public static void DoArrayHashtable()
    {
      var hashtable = new ArrayHashtable();
      Console.WriteLine(hashtable.Hash(7));
      Console.WriteLine(hashtable.Hash(13));
      Console.WriteLine(hashtable.Hash(100));

      Console.WriteLine(hashtable.Add(74, "hello"));
      Console.WriteLine(hashtable.Add(74, "hi"));
      Console.WriteLine(hashtable.Add(11, "hi"));
      Console.WriteLine(hashtable.Add(23, "goodbye"));

      Console.WriteLine(hashtable.Get(74));
      Console.WriteLine(hashtable.Get(23));
      Console.WriteLine(hashtable.Get(11));

      Console.WriteLine("-------------");
    }

    public static void DoBasicTree()
    {
      var root = new TreeNode
      {
        data = "root"
      };

      var childOne = new TreeNode
      {
        data = "childOne"
      };

      var childTwo = new TreeNode
      {
        data = "childTwo"
      };

      var grandChildOne = new TreeNode
      {
        data = "grandChildOne"
      };

      var grandChildTwo = new TreeNode
      {
        data = "grandChildTwo"
      };

      var grandChildThree = new TreeNode
      {
        data = "grandChildThree"
      };

      var grandChildFour = new TreeNode
      {
        data = "grandChildFour"
      };

      var childrenArray = new TreeNode[]
      {
        childOne,
        childTwo
      };

      var grandChildrenArrayOne = new TreeNode[]
      {
        grandChildOne,
        grandChildTwo
      };

      var grandChildrenArrayTwo = new TreeNode[]
      {
        grandChildThree,
        grandChildFour
      };

      root.children = childrenArray;
      childOne.children = grandChildrenArrayOne;
      childTwo.children = grandChildrenArrayTwo;
    }

    public static void DoBst()
    {
      var bst = new BinarySearchTree();
      bst.Add(9);
      bst.Add(4);
      bst.Add(10);
      bst.Add(11);
      bst.Add(2);
      bst.Add(3);
      bst.Add(8);
      bst.Add(6);

      var foundNode = bst.Search(3);

      bst.Remove(4);

    }
  }
}
