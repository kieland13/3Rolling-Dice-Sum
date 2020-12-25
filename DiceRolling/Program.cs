using System;

namespace DiceRolling
{
   class Program
   {
      static void Main()
      {
         //create a random number variable
         var randomNumbers = new Random();

         //initialize array with 19 numbers from 0-18
         var frequency = new int[19];
         //initialize three dice variables
         int die1 = 0;
         int die2 = 0;
         int die3 = 0;
         //initialize a sum of three dice variable
         int sum = 0;
         //initialize percentage variable
         double percentage = 0;
         double total = 36000;

         //simulate 36,000 rolls and then add 1 to each sum every loop
         for (var roll = 1; roll <= total; roll++)
         {
            die1 = randomNumbers.Next(1, 7);
            die2 = randomNumbers.Next(1, 7);
            die3 = randomNumbers.Next(1, 7);
            sum = die1 + die2 + die3;
            frequency[sum]++;
         }

         //Print off the headers
         Console.WriteLine($"{"Sum"}{"Frequency", 10}{ "Percentage",11}");

         //for loop that only gets numbers 3-18
         for (int  diceSum = 3; diceSum < frequency.Length; ++diceSum)
         {
            //take the frequency divided by the total
            percentage = frequency[diceSum] / total;
            double newPercentage = Math.Round((Double)percentage, 4);

            //round to 2 decimal places
            newPercentage = newPercentage * 100;
            newPercentage = Math.Round((Double)newPercentage, 4);

            //print off results
            Console.Write($"{diceSum, 3}{frequency[diceSum],10}");
            Console.WriteLine($"{newPercentage, 11}%");
         }

         //

      }
   }
}
