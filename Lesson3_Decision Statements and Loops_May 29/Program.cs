using System;

namespace Lesson3_Decision_Statements_and_Loops_May_29
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determining if ticket number is 30 (the winning ticket number) using the If statement
            int ticket = 31;
            if (ticket==30)
            {
                Console.WriteLine("You win the new car!");
            }

            //Determining if someone can drive a car (using the If/Else statement)
            int age = 32; 
            if (age<16)
            {
                Console.WriteLine("You are too young to drive a car.");
            } else
            {
                Console.WriteLine("You are old enough to drive a car!");
            }

            //Determining which school students will attend based on age (Using If/ Else If statement)
            double studentAge = 17.5;
            if (studentAge<12 && studentAge>=5)
            {
                Console.WriteLine("You will be attending Elementary School.");
            } else if (studentAge>= 12 && studentAge<15)
            {
                Console.WriteLine("You will be attending Middle School.");
            } else if (studentAge >= 14 && studentAge < 19)
            {
                Console.WriteLine("You will be attending High School.");
            } else
            {
                Console.WriteLine("You should be finished with your K-12 education.");
            }

            //Multiplying numbers by using the Ternary Operator
            int number = 75;
            int product= (number > 0 && number < 100) ? number * 2 : number * 3;
            Console.WriteLine(product);

            //Practicing Using Loops

            //While Loop
            int x = 0;

            while(x<=10)
            {
                x = x + 2;
                Console.WriteLine(x);
            }

            // Do/While Loop
            double i = 3.2;
            do
            {
                i++;
                Console.WriteLine(i);
            } while (i <= 10);

            // For Loop
            int taskToComplete; //Stating that taskToComplete is an integer
            for (taskToComplete=3; taskToComplete>=0; taskToComplete--)
            {
               Console.WriteLine("You have " + taskToComplete + " tasks that you need to complete.");
            } 
        }
    }
}
