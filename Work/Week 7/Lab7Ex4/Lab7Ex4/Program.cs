using System;
using static System.Console;

namespace lab
{
    class lab
    {
        static void Main()
        {
            string inputString;
            double aValue, result;
            Write("Enter a value to be squared: ");
            inputString = ReadLine();
            aValue = double.Parse(inputString);
            result = Math.Pow(aValue, 2);
            WriteLine(result);
            ReadKey();
        }
    }
}