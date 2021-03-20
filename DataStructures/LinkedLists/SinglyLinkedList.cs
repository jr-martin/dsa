using System;

namespace DataStructures.LinkedLists
{
  public class SinglyLinkedList : ILinkedList
  {
    // first node
    private Node _head;
    private Node _tail;

    public void AddFirst(object data)
    {
      // create new node to be added to the LL
      Node nodeToAdd = new Node();
      nodeToAdd.data = data;

      // if the head is null, the LL is empty,
      // so this node will be both the head and the tail
      if (_head == null)
      {
        _tail = nodeToAdd;
      }

      // assign the next node as the head
      nodeToAdd.next = _head;

      // assign the head as the node just created
      _head = nodeToAdd;
    }

    public void Add(object data)
    {
      // create a new node to be added to the end of the LL
      Node nodeToAdd = new Node();
      nodeToAdd.data = data;

      // if head does not exist, the LL is empty
      // set the head and tail to the new Node
      // for clarity, explicitly set the next property to null, as there are no other nodes
      if (_head == null)
      {
        _head = nodeToAdd;
        _tail = nodeToAdd;
        _head.next = null;
      }
      // else, set the current tail's Next node to the new node,
      // and update the tail to be the newly created node
      else
      {
        _tail.next = nodeToAdd;
        _tail = nodeToAdd;
      }
    }

    public bool Delete(object value)
    {
      // if the head is null, the list is empty therefore value doesn't exist 
      if (_head == null)
      {
        return false;
      }
      //if head is the only value, set it and the tail to null
      if (_head.next == null) 
      {
        _head = null;
        _tail = null;
        return true;
      }
      else
      {
        Node currentNode = _head;
        Node previousNode = null;

        while (currentNode != null)
        {
          if (currentNode.data == value)
          {
            // first check if we are removing the last node
            if (currentNode.next == null)
            {
              previousNode.next = null;
              _tail = previousNode;
              return true;
            }
            // "delete" by re-assiging the previous node to be the current node
            previousNode.next = currentNode.next;
            return true;
          }
          previousNode = currentNode;
          currentNode = currentNode.next;
        }
        return false;
      }
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

  public class Node
  {
    public object data;
    public Node next;
  }
}
