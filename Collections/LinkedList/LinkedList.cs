using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections.LinkedList
{
    /// <summary>
    /// A Linked List class that can perform basic operations such 
    /// as add, remove, find, and enumerate
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class LinkedList<T> : ICollection<T>
    {

        private LinkedListNode<T> _head = null;
        private LinkedListNode<T> _tail = null;

        public LinkedList()
        {
            Count = 0;
        }

        /// <summary>
        /// The amount of nodes in this container
        /// </summary>
        public int Count { get; private set; }

        public object SyncRoot
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Return the first Item in the linked list
        /// </summary>
        /// <returns>last item in the linked list</returns>        
        public T Front()
        {

            if (Count == 0)
            {
                throw new InvalidOperationException("There are no items in the Linked List");
            }

            return _head.Value;

        }

        /// <summary>
        /// Return the last item in the linked list
        /// </summary>
        /// <returns>last item in the linked list</returns>
        public T Back()
        {

            if (Count == 0)
            {
                throw new InvalidOperationException("There are no items in the Linked List");
            }

            return _tail.Value;

        }

        /// <summary>
        /// Adds an item to the front of the linked list
        /// </summary>
        /// <param name="value">item to add</param>
        public void PushFront(T value)
        {

            var item = new LinkedListNode<T>(value);
            var tempNode = _head;

            _head = item;
            _head.Next = tempNode;

            if (Count == 0)
            {
                _tail = _head;
            }

            Count++;

        }

        /// <summary>
        /// Adds an item to the back of the linked list
        /// </summary>
        /// <param name="value">item to add</param>
        public void PushBack(T value)
        {

            var item = new LinkedListNode<T>(value);

            if (Count == 0)
            {
                _head = item;
            }
            else
            {
                _tail.Next = item;
            }

            _tail = item;

            Count++;

        }

        /// <summary>
        /// Removes the node at the front of the linked list
        /// </summary>
        public void RemoveFront()
        {

            if (Count == 0)
            {
                throw new InvalidOperationException("There are no elements to remove");
            }
            else if (Count == 1)
            {
                _head = null;
                _tail = null;
                Count--;
            }
            else
            {
                _head = _head.Next;
                Count--;
            }

        }

        /// <summary>
        /// Removes the node at the back of the linked list
        /// </summary>
        public void RemoveBack()
        {

            if (Count == 0)
            {
                throw new InvalidOperationException("There are no elements to remove");
            }
            else if (Count == 1)
            {
                Clear();
            }
            else
            {

                LinkedListNode<T> scanner = _head;

                do
                {
                    scanner = scanner.Next;
                } while (scanner.Next.Next != null);

                _tail = scanner;
                _tail.Next = null;
                --Count;
            }

        }

        /// <summary>
        /// Adds an item to the back of the list
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            PushBack(item);
        }

        /// <summary>
        /// Clears the container of any items
        /// </summary>
        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        /// <summary>
        /// Search the contain to see if an item exists
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            for (var node = _head; node != null; node = node.Next)
            {
                if (node.Value.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove the specified item from the list if it exists
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item)
        {

            if (Count == 0)
            {
                throw new InvalidOperationException("There are no elements to remove");
            }
            else if (Count == 1 && _head.Value.Equals(item))
            {
                Clear();

                return true;
            }

            var scanner = _head;

            while (scanner != null)
            {
                if (scanner.Next != null && scanner.Next.Value.Equals(item))
                {

                    if(scanner.Next == _tail)
                    {
                        _tail = scanner;
                        scanner.Next = null;
                    }
                    else
                    {

                        scanner.Next = scanner.Next.Next;

                    }
                    
                    --Count;

                    return true;

                }
            }

            return false;
        }

        /// <summary>
        /// Iterates through the entire list
        /// </summary>
        /// <returns></returns>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {

            for (var node = _head; node != null; node = node.Next)
            {
                yield return node.Value;
            }

        }

        /// <summary>
        /// Iterates through the entire list
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {

            for (var node = _head; node != null; node = node.Next)
            {
                yield return node.Value;
            }

        }
    }
}
