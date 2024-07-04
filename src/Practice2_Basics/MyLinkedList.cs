using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice2_Basics
{
    internal class MyLinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public int Size { get; private set; }

        public MyLinkedList()
        {
            Head = null;
        }
        public MyLinkedList(Node<T> head)
        {
            Head = head;
        }

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (Head == null)
            {
                Head = newNode;
                Size++;
                Print();
                return;
            }
            Node<T> tmpHead = Head;
            while (tmpHead.Next != null)
            {
                tmpHead = tmpHead.Next;
            }
            tmpHead.Next = newNode;
            Size++;
            Print();
        }
        public void Add(T item, int nodeNumber)
        {
            if (nodeNumber < 0 || nodeNumber >= Size)
            {
                Console.WriteLine("This node is unvailable!");
                return;
            }
            int curNode = 0;
            Node<T> tmpHead = Head;
            while (curNode != nodeNumber)
            {
                Head = Head.Next;
                curNode++;
            }
            Node<T> tmpNext = Head.Next;
            Head.Next = new Node<T>(item);
            Head.Next.Next = tmpNext;
            Head = tmpHead;
            Print();
        }
        public void Remove(int nodeNumber)
        {
            if (nodeNumber < 0 || nodeNumber >= Size)
            {
                Console.WriteLine("This node is unvailable!");
                return;
            }
            int curNode = 0;
            Node<T> tmpHead = Head;
            Node<T> prevNode = null;
            while (curNode != nodeNumber)
            {
                prevNode = Head;
                Head = Head.Next;
                curNode++;
            }
            if (curNode == nodeNumber && Head == null)
            {
                Console.WriteLine("This node is unvailable!");
                Head = tmpHead;
                return;
            }
            if (prevNode == null)
            {
                Head = Head.Next;
            }
            else
            {
                prevNode.Next = Head.Next;
                Head = tmpHead;
            }
            Size--;
            Print();
        }
        public void RemoveBack()
        {
            Remove(Size - 1);
        }
        public void Print()
        {
            Node<T> tmpHead = Head;
            Console.WriteLine("Your linked list:");
            while (Head != null)
            {
                Console.Write($"{Head.Value} ");
                Head = Head.Next;
            }
            Head = tmpHead;
            Console.WriteLine();
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
