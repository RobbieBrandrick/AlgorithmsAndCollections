﻿namespace Collections.LinkedList
{
    internal sealed class LinkedListNode<T>
    {
        
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }

    }
}