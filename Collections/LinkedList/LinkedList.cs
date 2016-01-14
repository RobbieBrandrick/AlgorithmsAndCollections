using System;

namespace Collections.LinkedList
{
    /// <summary>
    /// A Linked List class that can perform basic operations such 
    /// as add, remove, find, and enumerate
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class LinkedList<T>
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

            if(Count == 0)
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
            
            if(Count == 0)
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
            }
            else
            {
                _head = _head.Next;
            }

            Count--;

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
            else if(Count == 1)
            {
                _head = null;
                _tail = null;                
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
            }

            --Count;
            
        }
        
    }
}
