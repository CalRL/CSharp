using System;
using static System.Console;
namespace Lab7Ex2{
    class Lab7Ex2
    {
        static double Main()
        {
            string inputValue;
            int feet, inches;
            Write("Enter length in feet: ");
            inputValue = Console.ReadLine();
            feet = int.Parse(inputValue);
            Write("Enter length in inches: ");
            inputValue = Console.ReadLine();
            inches = int.Parse(inputValue);
            return (feet + (double)inches / 12);
        }
    }

} 