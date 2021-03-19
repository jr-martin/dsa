using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
  public class SinglyLinkedList : ILinkedList
  {
    private Node head;

    public void AddFirst(object data)
    {
      //create new node
      Node nodeToAdd = new Node();

      //assign the data and assign the next node as the current head
      nodeToAdd.data = data;
      nodeToAdd.next = head;

      //assign the head (first node) as the node just created
      head = nodeToAdd;
    }

    public void AddLast(object data)
    {

    }

    public void Delete()
    {

    }

    public void Search()
    {

    }
  }

  internal class Node
  {
    public object data;
    public Node next;
  }
}
