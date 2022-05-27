using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.ReactiveUI;
using System;

namespace Lab_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] queue1 = { 5, 3, 4 };
            int[] queue2 = { 10, 2, 3, 3 };
            int[] queue3 = { 2, 3, 10 };
            Console.WriteLine(HW1.QueueTime(queue1, 1));
            Console.WriteLine(HW1.QueueTime(queue2, 2));
            Console.WriteLine(HW1.QueueTime(queue3, 2));
        }
    }
}
