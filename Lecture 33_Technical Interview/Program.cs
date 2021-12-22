using System;
using System.Collections.Generic;

namespace Lecture_33_Technical_Interview
{
    class Program
    {
        //Ask questions before you start the problem. Ask for more examples to get a better understanding of the problem.

        //Logic (how the flow of the project works). Logic and Pseudocode: We have an array with multiple integers inside of it. We would like to remove the duplicates within this array.
        //Use two arrays for this problem
        //Ask questions (like: Can I change the given array? Can I use a different data structure? ) before starting the Pseudocode
        //Could ask the correct syntax.
        //If you know the easier way to solve the problem, you can mention it, but not use it during the coding.
        //REview the practice problem for the technical interview


        //Flowchart: We have an array --> Test the integers within the array to see if they are duplicates --> If they are duplicates, remove one of the duplicates 
        // --> Display the new array without duplicate numbers

        //Pseudocode: Create the array that contains integers (one value of the array has a duplicate) : int[] numberArray = new int{555, 20, 1, 6, 20}
        
        
        //For loop to compare the initial value in the array with the other values inside of the array: for (int i=0; i<= numberArray.Length -1; i++)
        //int compareValue= numberArray[i];
        
        //for(int k=i+1; k<= numberArray.Length-1; k++)
        //if(compareValue ==numberArray[k]) { Remove.numberArray[k];}

        //foreach(int value in numberArray)
        //Console.WriteLine(value);

        //Always have a separate method outside of the Main 
        static void Main(string[] args)
        {
            //Given an array, so it is passed in as a parameter to a new method
            //Create the integer array
            int[] numberArray = new int { 555, 20, 1, 6, 20 };

            //Initializing checkValue variable
            int checkValue = numberArray[0];
            //Create a variable that will contain the value that is going to be checked with all the values within the numberArray
            for(int i=0; i<=numberArray.Length -1; i++)
            {
                checkValue = numberArray[i];
            }

            //Creating a new method that will check the passed in array
            CheckingDuplicates(numberArray,checkValue);

            
   
        }

        static void CheckingDuplicates(Array numberArray, int checkValue)
        {
            
            
            for (int i = 1; i <= numberArray.Length - 1; i++)
            {
                if(checkValue==numberArray[i])
                {
                    numberArray.Remove[i];
                }
                
                int compareValue = numberArray[i];

                for (int k = i + 1; k <= numberArray.Length - 1; k++)
                {
                    if (compareValue == numberArray[k])
                    {
                        //Remove the value in the array
                        numberArray.Remove[k];

                    }
                }
            }

            foreach (int value in numberArray)
            {
                Console.WriteLine(value);
            }
        }
    }
}
