using System;
using Algorithms;
using DataStructures;
using DataStructures.LinkedLists;

namespace dsa
{
  public class Program
  {
    static void Main(string[] args)
    {
      DoSinglyLinkedList();
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
    }
  }
}
