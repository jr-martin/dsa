using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks
{
  public class Stack
  {
    private StackItem _head;

    public void Push(object value)
    {
      var newStackItem = new StackItem { data = value };

      // if the head is empty, the stack is empty
      if (_head == null)
      {
        _head = newStackItem;
        return;
      }
      // otherwise, put the new item in front of the head and set the head to the new item
      else
      {
        newStackItem.previous = _head;
        _head = newStackItem;
      }
    }

    public StackItem Pop()
    {
      // if the head is empty, the stack is empty
      if (_head == null)
      {
        return null;
      }
      // otherwise, assign the head to a temp variable and replace it with the item behind it
      else
      {
        var itemToReturn = _head;
        _head = _head.previous;

        return itemToReturn;
      }
    }

    public StackItem Peek()
    {
      // if the head is empty, the stack is empty
      if (_head == null)
      {
        return null;
      }
      // otherwise, just return the head item
      else
      {
        return _head;
      }
    }
  }

  public class StackItem
  {
    public object data;
    public StackItem previous;
  }
}
