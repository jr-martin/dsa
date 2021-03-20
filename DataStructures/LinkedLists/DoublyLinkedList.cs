using System;

namespace DataStructures.LinkedLists
{
  public class DoublyLinkedList : ILinkedList
  {
    // first node
    private DoubleNode _head;

    public void AddFirst(object data)
    {
      // create new node to be added to the LL
      DoubleNode nodeToAdd = new DoubleNode();

      // assign the data and assign the next node as the head
      // explicitly assigning a null value as the previous node because it is the first
      nodeToAdd.data = data;
      nodeToAdd.next = _head;
      nodeToAdd.previous = null;

      // assign the head as the node just created
      _head = nodeToAdd;
    }

    public void Add(object data)
    {
      // create a new node to be added to the end of the LL
      DoubleNode nodeToAdd = new DoubleNode();
      nodeToAdd.data = data;

      // if head does not exist, the LL is empty
      // create a new head Node and assign data
      // set the next and previous properties to null, as there are no other nodes
      if (_head == null)
      {
        _head = nodeToAdd;
        _head.next = null;
        _head.previous = null;
      }
      else
      {
        // start at the first node and iterate through until the last node is reached
        // (i.e. when the value of next is null, the end of the LL has been reached)
        DoubleNode currentNode = _head;
        while (currentNode.next != null)
        {
          currentNode = currentNode.next;
        }

        // when the last node has been reached, assign the new node to the next property of the current node
        currentNode.next = nodeToAdd;
        nodeToAdd.previous = currentNode;
      }
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
      DoubleNode currentNode = _head;
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
      DoubleNode currentNode = _head;
      while (currentNode != null)
      {
        Console.WriteLine(currentNode.data.ToString());
        currentNode = currentNode.next;
      }
    }
  }

  internal class DoubleNode
  {
    public object data;
    public DoubleNode next;
    public DoubleNode previous;
  }
}
