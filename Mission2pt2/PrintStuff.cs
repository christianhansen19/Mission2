using System;

namespace Mission2pt2
{
    public class PrintStuff
    {
        // Constructor
        public PrintStuff ()
        {

        }
        public void PrintResults(int numRolls, int[] totals)
        {
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls + ".");
            Console.WriteLine();

            // Histogram
            for (int i = 2; i <= 12; i++)
            {
                Console.Write(i + ": ");
                int numStars = (int)((double)totals[i] / numRolls * 100);
                for (int j = 0; j < numStars; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
