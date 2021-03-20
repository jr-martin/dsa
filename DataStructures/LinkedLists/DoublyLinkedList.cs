using System;

namespace DataStructures.LinkedLists
{
  public class DoublyLinkedList : ILinkedList
  {
    // first node
    private DoubleNode _head;
    private DoubleNode _tail;

    public void AddFirst(object data)
    {
      // create new node to be added to the LL
      DoubleNode nodeToAdd = new DoubleNode();
      nodeToAdd.data = data;

      // if the head is null, the LL is empty,
      // so this node will be both the head and the tail
      if (_head == null)
      {
        _tail = nodeToAdd;
      }

      // set the current head's previous value to the new node
      _head.previous = nodeToAdd;

      // set the new node's next value as the current head
      nodeToAdd.next = _head;

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
        _tail = nodeToAdd;
        _head.next = null;
        _head.previous = null;
      }
      // else, set the current tail's Next node to the new node,
      // set the new node's previous pointer to the current tail
      // update the tail to be the newly created node
      else
      {
        _tail.next = nodeToAdd;
        nodeToAdd.previous = _tail;
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
      //if head is the only value, set it to null
      if (_head.next == null)
      {
        _head = null;
        return true;
      }
      else
      {
        DoubleNode currentNode = _head;
        DoubleNode previousNode = null;

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
            // also assign the next node's previous node to the current node's previous node
            previousNode.next = currentNode.next;
            currentNode.next.previous = previousNode;
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

  public class DoubleNode
  {
    public object data;
    public DoubleNode next;
    public DoubleNode previous;
  }
}
