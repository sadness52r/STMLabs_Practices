using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Practice2_Basics
{
    internal class MyLinkedList<T> : IEnumerable<T>
    {
        private ILogger logger;

        public Node<T> Head { get; set; }
        public int Size { get; private set; }

        public MyLinkedList() :this(null) { }
        public MyLinkedList(Node<T> head)
        {
            Head = head;
            logger = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
                builder.SetMinimumLevel(LogLevel.Information);
            }).CreateLogger<MyLinkedList<T>>();
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
        public void Add(T item, int nodeNumber)
        {
            try
            {
                if (nodeNumber < 0 || nodeNumber >= Size)
                {
                    throw new OutOfRangeListException("This node is unvailable!");
                }
            }
            catch (OutOfRangeListException e)
            {
                logger.LogInformation(e.Message);
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
        }
        public void Remove(int nodeNumber)
        {
            try
            {
                if (nodeNumber < 0 || nodeNumber >= Size)
                {
                    throw new OutOfRangeListException("This node is unvailable!");
                }
            }
            catch (OutOfRangeListException e)
            {
                logger.LogInformation(e.Message);
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
            try
            {
                if (curNode == nodeNumber && Head == null)
                {
                    Head = tmpHead;
                    throw new OutOfRangeListException("This node is unvailable!");
                }
            }
            catch (OutOfRangeListException e)
            {
                logger.LogInformation(e.Message);
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
        public void RemoveBack()
        {
            Remove(Size - 1);
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var node in this)
            {
                stringBuilder.Append(node.ToString() + " ");
            }
            return stringBuilder.ToString();
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
