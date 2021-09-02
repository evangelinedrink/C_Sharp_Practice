using System;

namespace Jeopardy_September_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practicing with Expressions
            Console.WriteLine(3+3+"six" +(3+3)* 3%3);
            Console.WriteLine(54 % 10 + 8 * 3 % 9);

            //Creating the random number generator
            var rand = new Random();

            //Generating random numbers using rand.Next() method between 12 and 100
            //Generate 3 random numbers within the range of 12 to 100
            int number1 = rand.Next(12, 101);
            int number2 = rand.Next(12, 101);
            int number3 = rand.Next(12, 101);

            //Taking the sum of the three randomly generated numbers and setting it to the variable sumNumbers.
            int sumNumbers = number1 + number2 + number3;

            //If the sum of the 3 numbers is divisible by 4, variable y is set to 4
            if (sumNumbers%4==0) //If the sum of numbers is divisible by 4, the modulu (remainder) will be equal to zero
            {
                int y = 4;

                for (int i=1; i<3; i++) //For loop will ensure that "I'm divisible by 2" displays two times in the console.
                {
                    Console.WriteLine("I'm divisible by 2.");
                }
            } else if(sumNumbers%2==0) //If the sum of numbers is divisible by 2, the modulu (remainder) will be equal to zero
            {
                int x = 12; //Setting the variable x equal to 12

                for (int i=1; i<5; i++) //For loop will ensure that "I'm divisible by 4" displays four times in the console.
                {
                    Console.WriteLine("I'm divisible by 4");
                }
            } else //If the sum of numbers is not divisible by 4 or 2, the code within this Else statement will run
            {
                for(int i=1; i<6; i++) //This For loop will ensure that "I'm boring" will display in the console 5 times.
                {
                    Console.WriteLine("I'm boring.");
                }
            }
        }
    }
}
