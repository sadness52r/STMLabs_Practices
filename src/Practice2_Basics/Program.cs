using System;

namespace Practice2_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>
            {
                1,
                2,
                3,
                4
            };
            myLinkedList.Remove(3);
            myLinkedList.Remove(1);
            myLinkedList.Remove(2);
            myLinkedList.Add(5);
            myLinkedList.Remove(0);
            myLinkedList.Remove(100);
            myLinkedList.Add(8, 1);
            myLinkedList.Add(9, 0);
            myLinkedList.Add(10, -1);
            myLinkedList.Add(10, 14);
            foreach (var node in myLinkedList)
            {
                Console.Write($"{node} ");
            }
        }
    }
}
