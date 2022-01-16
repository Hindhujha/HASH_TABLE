using System;
using System.Collections.Generic;


namespace HashTable
{
    internal class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        public LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {

            LinkedList<KeyValue<K, V>> linkedlist = items[position];

            if (linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedlist;
            }

            return linkedlist;
        }
        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;//formula for hash code of particular key value
            return Math.Abs(position);
        }
        public V Get(K Key)
        {
            int position = GetArrayPosition(Key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.key.Equals(Key))
                {
                    return item.value;
                }
            }
            return default(V);
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>()
            {
                key = key,
                value = value
            };
            linkedlist.AddLast(item);
        }

      /*  public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            bool itemfound = false;
            KeyValue<K, V> founditem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.key.Equals(key))
                {
                    itemfound = true;
                    founditem = item;
                }
            }
            if (itemfound)
            {
                linkedlist.Remove(founditem);
            }

        }*/

       



    }

    public struct KeyValue<k,v>
    {
        public k key { get; set; }
        public v value { get; set; }
    }
}
