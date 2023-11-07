// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

namespace Lab7Ex1
{
        class Lab7Ex1
    {
        int aValue;
        static void Main()
        {
            string? number = Console.ReadLine();
            int aValue = int.Parse(number);
            int result = aValue * aValue;
            WriteLine($"{aValue} squared is {result}");
            ReadKey();
        }
    }      
}
