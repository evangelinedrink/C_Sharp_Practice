﻿using System;

namespace Lectures_24_and_25_Solving_Coding_Problems_August_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Worksheet Lecture 24 Part 1

            /*Problem 1: Computes the sum of the digits of an integer*/
            int digit1 = 12;
            int digit2 = -9;

            //Function to add the integers together
            int sum = digit1 + digit2;

            //Displaying the sum of the integers and the numbers added together
            Console.WriteLine($"Input a number(integer): {digit1} and {digit2} ");
            Console.WriteLine($"Sum of the digits of the said integers: {sum}");

            /*Problem 2: Check two given integers, and return true if one of them is 30
             or if their sum is 30*/
            //Declaring the two variables to be used in this problem
            int digit3 = 30;
            int digit4 = 21;

            //Function to add the integers together
            int sum2 = digit3 + digit4;

            //If/Else statements to check to see if either digits are equal to 30 or if the sum of the two digits is equal to 30
            if ((digit3==30) || (digit4==30))
            {
                Console.WriteLine("One of the numbers is equal to 30.");
            } else if(sum2==30)
            {
                Console.WriteLine("The sum of these digis are equal to 30.");
            } else
            {
                Console.WriteLine("The two digits are not equal to 30 nor does their sum equal to 30.");
            }

            /*Problem 3: Check to see if a string starts with a specific word*/
            //Declaring the string that will be tested to see if it has a specific word
            string problem3 = "Hello, how are you?";

            //The word that we want to check if the string contains
            string checkWord = "Hello";

            //Using If/Else statement to see if the string contains the word "Hello"
            if (problem3.Contains(checkWord))
            {
                Console.WriteLine($"The string ({problem3}) contains the word, {checkWord}.");
            } else
            {
                Console.WriteLine($"The string ({problem3}) does not contain the word, {checkWord}.");
            }

            /*Problem 4: Get a new string of two characters from a given string. The first and second character 
             * of the given string must be "P" and "H", so PHP will be "PH"*/
            //Declaring the String value that contains the letters P and H
            string problem4 = "PHILIPPINES";

            //Letters that are going to be checked to see if it is in the word
            string checkLetters = "PH";

            //Checking to see if the letters P and H are together and gets this value and returns it in the Console
            if(problem4.Contains(checkLetters))
            {
                Console.WriteLine($"The word {problem4} contains the letters {checkLetters}.");
            }


            /*Problem 5: Find the largest and lowest values from three integer values*/
            //Declaring an array that contains the three integers
            int[] problem5 = new int[] { 3, 9, 7 };

            //Declaring the lowest and highest values that will be changed to the numbers after iterating through the For loop
            int lowestValue = problem5[0];
            int highestValue = problem5[1];

            for(int i=0; i<problem5.Length; i++)
            {
                int currentValue = problem5[i];

                if(currentValue>highestValue)
                {
                    highestValue = currentValue;
                } else if (currentValue<lowestValue) 
                {
                    lowestValue = currentValue;
                }
            }
            //Console Log to show which values are the high and low values
            foreach (int problem5Value in problem5)
                Console.WriteLine($"The values in the problem 5 array are: {problem5Value}");
            Console.WriteLine($"The lowest value in the problem5 array is {lowestValue}");
            Console.WriteLine($"The highest values in the problem5 array is {highestValue}");


            /*Problem 6: Obtain 2 numbers and check to see how far its value is from 20.*/
            //Obtaining the first and second numbers and comparing them to the number 20
            Console.WriteLine("Input first integer: ");
            int problem6Number1 = Convert.ToInt32(Console.ReadLine()); //Reads what the user types in the Console (thanks to Console.ReadLine()) and converts the typed string into an integer

            Console.WriteLine("Input second integer: ");
            int problem6Number2 = Convert.ToInt32(Console.ReadLine());

            int compareNumberProb6 = 20;

            //Comparing the two numbers that the user entered with the number 20. Taking the absolute value with Math.Abs
            int problem6Compare1 = Math.Abs(problem6Number1 - compareNumberProb6);
            int problem6Compare2 = Math.Abs(problem6Number2 - compareNumberProb6);

            //Display the results to the Console
            Console.WriteLine($"The difference between the first number and 20 is {problem6Compare1}");
            Console.WriteLine($"The difference between the second number and 20 is {problem6Compare2}");

            /*Problem 7:*/
            
            /*Problem 8: Rotate the elements in an array (length 3) of integers in left direction*/
            //Creating an array of length 3 with integers
            int[] problem8Array= {5, 27, 1991};

            //Console the list of the original array
            Console.WriteLine("The original array: ");
            foreach(int value in problem8Array)
            {
                Console.WriteLine(value);
            }

            //Using a For loop to go over the entire array and then changing the order of the values in the array
            Console.WriteLine("The revised array: ");
            for(int i=0; i<problem8Array.Length-1; i++) //There is a -1 in the second condition because we want i to always be less than j (where j starts at 1)
            {
                
                for(int j=1; j<problem8Array.Length; j++)
                {
                    int placeholder = problem8Array[i];
                    problem8Array[i] = problem8Array[j];
                    problem8Array[j] = placeholder;
                }
                
            }
             foreach(int value in problem8Array)
            {
                Console.WriteLine(value);
            }
        }
    }
}
