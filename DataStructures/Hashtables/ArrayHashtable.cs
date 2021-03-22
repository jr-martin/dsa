using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Hashtables
{
  // this hashtable is implemented only using a jagged array (which is not the best solution)
  public class ArrayHashtable
  {
    private object[][] _buckets;
    private int _size;
    private int primeTableIndex = 0;

    // array of prime numbers to be used for the size of the hashtable
    private int[] primeTable = {
      19,
      37,
      73,
      163,
      367,
      557,
      823,
      1237,
      1861,
      2777,
      4177,
      6247,
      9371,
      14057,
      21089,
      31627,
      47431,
      71143,
      106721,
      160073,
      240101,
      360163,
      540217,
      810343,
      1215497,
      1823231,
      2734867,
      4102283,
      6153409,
      9230113,
      13845163
    };

    public ArrayHashtable()
    {
      // initialize the superArray with a size of the first prime and keep track of that value
      _size = primeTable[primeTableIndex];
      _buckets = new object[_size][];
    }

    public bool Add(int key, string value)
    {
      // get hashed value of key (bucket index)
      int bucketIndex = Hash(key);

      var bucket = _buckets[bucketIndex];

      // create a KVP tuple
      //var newKvp = Tuple.Create(key, value);
      var newKvp = new KeyValuePair<int, string>(key, value);

      //
      //
      //
      //
      //TODO: check if this table needs to be rehashed
      //
      //
      //
      //


      // if the current bucket is empty, initialize an array of tuples to store the KeyValuePairs
      if (bucket == null)
      {
        //TODO: determine what size this array should be (this is why we use linked lists for chaining)
        _buckets[bucketIndex] = new KeyValuePair<int, string>[_size];

        // add the KVP tuple to the first value in the array
        _buckets[bucketIndex][0] = newKvp;

        return true;
      }
      else
      {
        // search through the bucket and ensure that the key does not already exist
        foreach (KeyValuePair<int, string> keyValuePair in bucket)
        {
          if (keyValuePair.Key == key)
          {
            //duplicate key
            return false;
          }
        }

        // find the next available spot in the KeyValuePair array to add the new KVP
        var index = 0;
        while (_buckets[bucketIndex][index] != null)
        {
          index++;
        }

        // add the new KVP to the array
        _buckets[bucketIndex][index] = newKvp;

        return true;
      }
    }

    public bool Remove(int key)
    {
      // not worth implementing at this time due to arrays being immutable
      throw new NotImplementedException();
    }

    public string Get(int key)
    {
      int bucketIndex = Hash(key);

      var bucket = _buckets[bucketIndex];
      string storedValue = null;

      for (var i = 0; i < bucket.Length; i++)
      {
        var kvp = (KeyValuePair<int, string>)bucket[i];
        if (kvp.Key == key)
        {
          storedValue = kvp.Value;
          break;
        }
      }

      if (storedValue == null)
      {
        // null if object not found
        return null;
      }

      return storedValue;
    }

    public ArrayHashtable ReSize(int currentHashTable)
    {
      throw new NotImplementedException();
    }

    public int Hash(int key)
    {
      return key % _size;
    }
  }

  class KeyValuePair<K, V>
  {
    public K Key;
    public V Value;
    public KeyValuePair(K key, V value)
    {
      Key = key;
      Value = value;
    }
  }
}
