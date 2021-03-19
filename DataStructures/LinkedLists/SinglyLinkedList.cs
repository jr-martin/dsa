using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
  public class SinglyLinkedList : ILinkedList
  {
    // first node
    private Node _head;

    public void AddFirst(object data)
    {
      // create new node to be added to the LL
      Node nodeToAdd = new Node();

      // assign the data and assign the next node as the head
      nodeToAdd.data = data;
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
      // create a new head Node and assign data
      // set the next property to null, as there are no other nodes
      if (_head == null)
      {
        _head = nodeToAdd;
        _head.next = null;
      }
      else
      {
        // start at the first node and iterate through until the last node is reached
        // (i.e. when the value of next is null, the end of the LL has been reached
        Node currentNode = _head;
        while (currentNode.next != null)
        {
          currentNode = currentNode.next;
        }

        // when the last node has been reached, assign the new node to the next property of the current node
        currentNode.next = nodeToAdd;
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
        Node currentNode = _head;
        Node previousNode = null;

        while (currentNode != null)
        {
          if (currentNode.data == value)
          {
            // first check if we are removing the last node
            if (currentNode.next == null)
            {
              currentNode = null;
              previousNode.next = currentNode;
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
}
