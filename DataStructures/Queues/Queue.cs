using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues
{
  public class Queue
  {
    private QueueItem _head;
    private QueueItem _rear;

    public void Enqueue(object value)
    {
      var newQueueItem = new QueueItem { data = value };

      // if the head and tail are empty, the queue is empty
      if (_head == null && _rear == null)
      {
        _head = newQueueItem;
        _rear = newQueueItem;
        return;
      }
      // otherwise, put the new item behind the rear and make the rear the new item
      else
      {
        _rear.previous = newQueueItem;
        _rear = newQueueItem;
      }
    }

    public QueueItem Dequeue()
    {
      // if the head and tail are empty, the queue is empty
      if (_head == null && _rear == null)
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

    public QueueItem Peek()
    {
      // if the head and tail are empty, the queue is empty
      if (_head == null && _rear == null)
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

  public class QueueItem
  {
    public object data;
    public QueueItem previous;
  }
}
