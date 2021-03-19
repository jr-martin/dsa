using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{

  /*
  Linked lists can be thought of from a high level perspective as being a series of nodes.
  Each node has at least a single pointer to the next node, and in the last node’s case a null pointer 
  representing that there are no more nodes in the linked list. In DSA our implementations of linked lists 
  always maintain head and tailpointers so that insertion at either the head or tail of the list is a constanttime operation. 
  Random insertion is excluded from this and will be a linear operation. 

  As such, linked lists in DSA have the following characteristics:
  1. Insertion* is O(1)
  2. Deletion is O(n)
  3. Searching is O(n)
  
    *Random Insertion is O(n).

  Linked lists have a few key points which at times make them very attractive:
  1. the list is dynamically resized, thus it incurs no copy penalty like an array would eventually incur
  2. insertion isO(1)
  */


  public interface ILinkedList
  {
    void AddFirst(object data);
    void AddLast(object data);
    void Delete();
    void Search();


  }
}
