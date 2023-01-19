using System;

namespace GameTwoDice
{
    class Program
    {
        static void Main(string[] args)
        {   
            // instantiate the variable to hold the total rolls that the user will enter
            int ?totalRolls = 0; 

            // prompt user to input number of rolls and explain game
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            totalRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS:");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls");
            Console.WriteLine("Total number of rolls: " + totalRolls + '\n');

            Random rand = new Random();

            // create the array that will hold the counter of how many time each sum happened
            decimal[] ?counter = new decimal[11];


            // Simulate the roll of 2 dice for X times, randomly generated, and sum the two results
            for (int i = 0; i < totalRolls; i++)
            {
                int roll1 = (rand.Next(1,7));
                int roll2 = (rand.Next(1,7));

                int rollSum = (roll1 + roll2) - 2;

                counter[rollSum]++;
            }

            // if the total rolls is greater than 0, find percentages of each sum occurance and display with *
            for (int x = 0; x < 11; x++)
            {
                if (totalRolls > 0)
                {
                    int ast = Convert.ToInt32(Math.Round((decimal)((decimal)counter[x] / totalRolls) * 100));
                    Console.WriteLine((x + 2) + ": " + new String('*', ast));
                }
            }

            // end game text
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
