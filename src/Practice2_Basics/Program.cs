namespace Practice2_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
            myLinkedList.Print();
            myLinkedList.Add(1);
            myLinkedList.Print();
            myLinkedList.Add(2);
            myLinkedList.Print();
            myLinkedList.Add(3);
            myLinkedList.Print();
            myLinkedList.Add(4);
            myLinkedList.Print();
            myLinkedList.Remove(3);
            myLinkedList.Print();
            myLinkedList.Remove(1);
            myLinkedList.Print();
            myLinkedList.Remove(2);
            myLinkedList.Print();
            myLinkedList.Add(5);
            myLinkedList.Print();
            myLinkedList.Remove(0);
            myLinkedList.Print();
        }
    }
}
