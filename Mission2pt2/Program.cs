using System;

namespace Mission2pt2
{

   public class DiceSimulation
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            int numRolls = int.Parse(Console.ReadLine());

            int[] totals = new int[13];

            // Dice Roll
            Random rnd = new Random();
            for (int i = 0; i < numRolls; i++)
            {
                int die1 = rnd.Next(1, 7);
                int die2 = rnd.Next(1, 7);
                int total = die1 + die2;
                totals[total]++;
            }

            PrintStuff ps = new PrintStuff(); //Declaration and Instantiation

            ps.PrintResults(numRolls, totals);
        }
    }

}