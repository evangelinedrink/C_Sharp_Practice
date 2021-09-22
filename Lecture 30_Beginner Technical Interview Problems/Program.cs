using System;

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
                //Converting the number to be placed in the numberArray as a string
                //While the For loop runs, the number for i will be placed in the number array
                string numberToArray = Convert.ToString(i);
                //Adding the number (which is a string) to the numberArray
                numberArray[i - 1] = numberToArray;
            }
            
            //Displaying the array in the Console.
            foreach(string item in numberArray)
            {
                Console.WriteLine(item);
            }
            /*
            if((nInteger%3==0) || (nInteger%5==0))
            {

            }
            */

        }


    }
}
