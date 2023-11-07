using System;
using static System.Console;

namespace lab
{
    class lab
    {
        static void Main()
        {
            double roomLength, roomWidth, pricePerSqrYard, nbOfSqrYards;
            DisplayInstructions();
            roomLength = getDimensions("Length");
            roomWidth = getDimensions("Width");
            pricePerSqrYard = getPrice();
            nbOfSqrYards =
            determineSqrYards(roomWidth, roomLength);
            DisplayResults(nbOfSqrYards, pricePerSqrYard);
            ReadKey();
        }
        static void DisplayInstructions()
        {
            WriteLine("This program will " +
            "determine how much " +
            "carpet to purchase.");
            WriteLine();
            WriteLine("You will be asked to " +
            "enter the size of " +
            "the room ");
            WriteLine("and the price of the " +
            "carpet, in price per" +
            " square yds.");
            WriteLine();
        }
        static double getDimensions(string side)
        {
            string inputValue;
            double feet, inches;
            Write($"Enter the {side} in feet :");
            inputValue = ReadLine();
            feet = double.Parse( inputValue );
            Write($"Enter the {side} in inches: ");
            inputValue = ReadLine();
            inches = double.Parse( inputValue );
            return (feet + inches / 12);

        }
        static double getPrice()
        {
            string inputValue;
            double price;
            Write("Enter the price per square yard: ");
            inputValue = ReadLine();
            price = double.Parse( inputValue );
            return price;
        }
        static double determineSqrYards(double width, double length)
        {
            const int sqrFeetPerSqrYard = 9;
            double nbOfSqrYards = (length * width) / sqrFeetPerSqrYard;
            return nbOfSqrYards;
        }
        static double determinePrice(double squareYards, double pricePerSquareYard)
        {
            return (pricePerSquareYard * squareYards);
        }
        static void DisplayResults(double squareYards, double pricePerSquareYard)
        { 
            WriteLine();
            Write("Square Yards needed: ");
            WriteLine("{0:N2}", squareYards);
            Write("Total Cost at {0:C} ", pricePerSquareYard);
            WriteLine("per Square Yard: " +
            "{0:C}",
            determinePrice(squareYards, pricePerSquareYard));
        }

    }
}
