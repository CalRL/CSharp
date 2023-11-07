using System;
using static System.Console;
namespace Lab
{
    class Lab
    {
        static void Main()
        {
            int age;
            string aValue;
            WriteLine("Enter your age: ");
            aValue = ReadLine();
            age = int.Parse(aValue);
            WriteLine($"Your age next year will be {++age} {age++}");
            ReadKey();
        }
    }
}