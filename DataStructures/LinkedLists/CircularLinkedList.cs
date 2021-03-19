using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
  public class CircularLinkedList : ILinkedList
  {
    // first node
    private Node _head;
    private Node _tail;

    public void AddFirst(object data)
    {
      throw new NotImplementedException();
    }

    public void Add(object data)
    {
      throw new NotImplementedException();
    }

    public bool Delete(object value)
    {
      throw new NotImplementedException();
    }

    public bool Search(object value)
    {
      // if the head is null, the list is empty therefore value doesn't exist 
      if (_head == null)
      {
        return false;
      }

      // iterate through and check if each data is equal to input. immediately return true if so
      Node currentNode = _head;
      while (currentNode != null)
      {
        if (currentNode.data == value)
        {
          return true;
        }
        currentNode = currentNode.next;
      }
      return false;
    }
    public void Print()
    {
      // iterate through the nodes
      Node currentNode = _head;
      while (currentNode != null)
      {
        Console.WriteLine(currentNode.data.ToString());
        currentNode = currentNode.next;
      }
    }
  }
}
