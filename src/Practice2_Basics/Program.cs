using Microsoft.Extensions.Logging;
using System;

﻿namespace Practice2_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
                builder.SetMinimumLevel(LogLevel.Error);
            }).CreateLogger<MyLinkedList<int>>();

            MyLinkedList<int> myLinkedList = new MyLinkedList<int>(null, logger)
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

            DataTask1 dataTask1 = new DataTask1();
            dataTask1.Run();

            SetsTask5 setsTask5_3 = new SetsTask5(1, 20, 8);
            setsTask5_3.Run();
            Console.WriteLine(setsTask5_3);
          
            Console.WriteLine("Task 1:");
            StringsTask1 task1 = new StringsTask1();
            task1.Run();

            Console.WriteLine("\nTask3:");
            StringsTask3 stringsTask3 = new StringsTask3();
            stringsTask3.Run();

            LoopsTask2 task = new LoopsTask2();
            task.Run();
          
            ConditionsTask5 conditions_Task5 = new ConditionsTask5();
            conditions_Task5.Run();
        }
    }
}
