using System;
using static System.Console;
namespace lab
{
    class lab
    {
        static void Main(string[] args) {
            int initialStrideCount,
finalStrideCount,
hrs,
mins,
totalMinutes;
            double numberOfStepsPerMin,
            distanceTraveled;
            DisplayInstructions();
            initialStrideCount = GetNumberStrides("first");
            finalStrideCount = GetNumberStrides("last");
            InputJoggingTime(out hrs, out mins);
            totalMinutes = CalculateTime(hrs, mins);
            numberOfStepsPerMin = CalculateAvgSteps(initialStrideCount,
            finalStrideCount);
            distanceTraveled = CalculateDistance(numberOfStepsPerMin,
totalMinutes);
            DisplayResults(numberOfStepsPerMin, hrs, mins,
            distanceTraveled);
            ReadKey();
        }
        static void DisplayInstructions()
        {
            WriteLine("How many miles did you jog?");
            WriteLine("Distance (in miles) will be calculated");
            WriteLine("based on stride and number of steps");
            WriteLine("taken per minute. \n");
            WriteLine("You will be asked to enter ");
            WriteLine("your initial and ending strides...");
            WriteLine("OR how many steps you took the ");
            WriteLine("first minute and how many ");
            WriteLine("steps during the last minute.");
            WriteLine("Average stride is calculated " + "from those entries. \n");
            WriteLine("Calculations are based on a ");
            WriteLine("2.5 feet stride-each step is 2.5 " + "feet long.");
            WriteLine();
            WriteLine("\nYou will also be asked " + "to enter the length ");
            WriteLine("of time (hours and minutes)");
            WriteLine("you jogged.");
            WriteLine();
            WriteLine("Press any key when you are ready " + "to begin!");
            ReadKey();
            Clear();
        }

    }
}