﻿using System;
using System.Collections.Generic; //Need this to use Stacks

namespace Lecture_30_Beginner_Technical_Interview_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //LeetCode Problem 204: Counting Primes
            //https://leetcode.com/problems/count-primes/

            //Logic: In this program, it will count the number of prime numbers
            //less than a set number that is not negative (considered variable n).
            //The Console will then count how many prime numbers there are and compare it 
            //to the non-negative number (n)

            //Flowchart: The user will determine the number that will create the range from 0 to n
            //The code will then determine which numbers are prime numbers from 0 to n.
            //To do this, create a counter that will count how many times there is a prime number from 0 to n
            //Then, have a For loop that will go through the numbers from 2 until n. Numbers 0 and 1 are not prime numbers, so we don't need to check to 
            //see whether or not they are prime.
            //Within the For loop will be an If/Else If statement that will check to see if the number is divisible by itself and 1, but not 
            //divisible by 2 (prime numbers are not even numbers, except for 2), that the number is not divisible by 3 or by 5

            //Pseudocode: Using a For loop to go through the range of numbers from 2 to n.  
            //Use an If/Else If statement to check if the code is a prime number (prime numbers are not divisible by 2, 3, 5 and prime numbers are divisible
            //by itself and 1). 


            Console.WriteLine("Select a number (variable n) that we will count the number of prime numbers from 0 to n.");
            string nValue = Console.ReadLine();

            //Setting the value set by the user into an integer data type
            int n = Convert.ToInt32(nValue);

            //Counter that will display how many prime numbers there are from 0 to n (the number that the user indicated)
            int primeCounter = 0;

            for(int i=2; i<=n ; i++) //0 and 1 are not prime numbers, so we can emit them from our check to determine if they are a prime number
            {
                if ((i == 2) || (i == 3) || (i==5))
                {
                    primeCounter += 1;
                    Console.WriteLine($"The number {i} is a prime number.");
                }
                else if ((i % i == 0) && (i % 1 == 0) && (i%2 !=0) && (i%3 !=0) && (i%5 !=0))
                {
                    primeCounter += 1;
                    Console.WriteLine($"The number {i} is a prime number.");
                }
            }

            //Displaying how many prime numbers there are that are less than the number selected by the user
            Console.WriteLine($"There are {primeCounter} prime numbers less than {n}");

            //LeetCode Challenge 155: Min Stack
            //https://leetcode.com/problems/min-stack/

            //Initializing the Stack
            Stack<int> minStack = new Stack<int>();

            //Pushing (adding) the variable "val" into the Stack (called minStack)
            //Asking the user to type a variable in the Console
            Console.WriteLine("Type values in the Console. Use a comma to separate the values.");
            string valString = Console.ReadLine();
            
            //Separating the values that the user placed in the Console
            //Placing the values in an array
            string[] valArray = valString.Split(",");

            //Using a foreach loop to go through all the values in the array
            foreach(string value in valArray)
            {
                //Converting valString to an integer that will be pushed in the Stack
                int val = Int32.Parse(value);

                //Pushing the val integer into the minStack Stack
                minStack.Push(val);

            }

            //Removes the element on top of the stack
            int topRemoved= minStack.Pop();
            Console.WriteLine($"The top element removed from the stack is {topRemoved}");

            //Getting the top element of the Stack
            int topElement = minStack.Peek();
            Console.WriteLine($"The top element in the stack is {topElement}");

            //Converting the Stack to an array
            int[] minArray = minStack.ToArray();

            //Creating a minimum value variable that will contain the minimum value after the For loop
            int minimumValue = minArray[0];

            //For loop that will compare all the values in the minArray to find the minimum value in the array
            for(int i=1; i<=minArray.Length-1; i++)
            {
                if (minArray[i]<minimumValue)
                {
                    minimumValue = minArray[i];
                }
            }

            //Displaying the miminum value in the Console
            Console.WriteLine($"The minimum value in the Stack is {minimumValue}");


            //LeetCode Problem 412: Fizz Buzz
            //https://leetcode.com/problems/fizz-buzz/

            //Asking user to type in an integer
            Console.WriteLine("Type an integer in the console.");

            //Getting the user's response and letting the integer equal to nString
            string nString = Console.ReadLine();
            //Letting the number that is a string equal to nInteger which is an integer using Convert.ToInt32
            int nInteger = Convert.ToInt32(nString);

            //Creating the array that will store the number
            //The length of the array is whatever the nInteger number is
            string[] numberArray = new string[nInteger];

            //For loop that will display the values in the array using
            //nInteger as the length of the array.
            for(int i=1; i<= nInteger; i++)
            {
                

                //Using an If/Else If Statement to determine if
                //the number being placed in the numberArray will be replaced with Fizz, FizzBuzz or Buzz
                //If the number i (which is being placed in the numberArray) is divisible by 3 and 5, replace the number with "FizzBuzz"
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    string fizzBuzz = "FizzBuzz";
                    //Since all arrays have the starting index number at 0, i-0 has to be used
                    numberArray[i - 1] = fizzBuzz;
                }
                else if (i % 3 == 0) //If the number i is divisible by 3, place Fizz in place of the number in the array
                {
                    string fizz = "Fizz";
                    numberArray[i - 1] = fizz;
                }
                else if (i % 5 == 0)   //If the number i is divisible by 5, place Buzz in place of the number in the array
                {
                    string buzz = "Buzz";
                    numberArray[i - 1] = buzz;
                } else
                {
                    //Converting the number to be placed in the numberArray as a string
                    //While the For loop runs, the number for i will be placed in the number array
                    string numberToArray = Convert.ToString(i);

                    //Adding the number (which is a string) to the numberArray
                    numberArray[i - 1] = numberToArray;
                }
            }
            
            //Displaying the array in the Console.
            foreach(string item in numberArray)
            {
                Console.WriteLine(item);
            }

        }


    }
}
