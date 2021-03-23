using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
  public class CircularLinkedList : ILinkedList
  {
    // first node
    private CircleNode _head;
    private CircleNode _tail;

    private class CircleNode
    {
      public object data;
      public CircleNode next;
    }

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
      throw new NotImplementedException();
    }
    public void Print()
    {
      throw new NotImplementedException();
    }
  }
}
