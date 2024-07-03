using System;

namespace Practice2_Basics
{
    internal class MyLinkedList<T>
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
                return;
            }

            Node<T> tmpHead = Head;
            while (tmpHead.Next != null)
            {
                tmpHead = tmpHead.Next;
            }
            tmpHead.Next = newNode;
            Size++;
        }
        public void Remove(int nodeNumber)
        {
            if (nodeNumber < 0)
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
    }
}
