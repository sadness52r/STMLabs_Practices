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
            Console.WriteLine(myLinkedList);
            myLinkedList.Remove(3);
            Console.WriteLine(myLinkedList);
            myLinkedList.Remove(1);
            Console.WriteLine(myLinkedList);
            myLinkedList.Remove(2);
            Console.WriteLine(myLinkedList);
            myLinkedList.Add(5);
            Console.WriteLine(myLinkedList);
            myLinkedList.Remove(0);
            myLinkedList.Remove(100);
            myLinkedList.Add(8, 1);
            Console.WriteLine(myLinkedList);
            myLinkedList.Add(9, 0);
            Console.WriteLine(myLinkedList);
            myLinkedList.Add(10, -1);
            myLinkedList.Add(10, 14);
        }
    }
}
