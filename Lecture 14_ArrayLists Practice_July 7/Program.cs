using System;
using System.Collections; //Need to use this command when working with ArrayLists

namespace Lecture_14_ArrayLists_Practice_July_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Array and ArrayList Exercises found at this website: https://www.w3resource.com/csharp-exercises/array/index.php  */

            /*Exercise 1: Store Elements in an Array and Print it*/

            //Creating ArrayList for Exercise 1 and adding elements using the Object Initializer Syntax
            var exercise1 = new ArrayList()
            {
                1, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            //Printing an ArrayList using ForEach loop
            foreach (var elements1 in exercise1)
                Console.WriteLine(elements1);

            
            /*Exercise 2: Let C# read n naumber of values in an array and display it in reverse order*/

            //Creating ArrayList for Exercise 2 and adding elements using the Object Initializer Syntax
            var exercise2 = new ArrayList()
            {
                2, 5, 7
            };

            //Reversing the order of elements in an array using the Array.Reverse() method. From: https://www.geeksforgeeks.org/c-sharp-reverse-the-order-of-the-elements-in-the-entire-arraylist-or-in-the-specified-range/
            exercise2.Reverse();

            //Printing and Displaying an ArrayList using ForEach loop
            foreach (var elements2 in exercise2)
                Console.WriteLine(elements2);


            /*Exercise 3: Find the sum of all elements in an array*/
            
            //Creating the new Array and indicating its size, which is 3. Also adding values to the array.
            int[] exercise3 = new int[3] {2, 5, 8};

            //Initializing sumValue variable. If you don't initialize your variable, you won't be able to use it.
            int sumValue = 0;

            //Adding (getting the sum) of the elements in the array using a For loop. Adding the sum of the elements in an array was found in this website: https://www.geeksforgeeks.org/program-find-sum-elements-given-array/
            for (int i=0; i<3; i++)
            {
                
                sumValue +=exercise3[i]; //Doing the math by adding the sum of all the values
                                    
            }
            //Displaying the sum of all the variables in the exercise3 array (if you placed the below line in the For loop, it will show all the numbers for each calculation)
            Console.WriteLine(sumValue);



            /*Exercise 4: Copying the elements from one array into another array*/

            //Creating the new Array and indicating its size, which is 3. Also adding values to the array.
            int[] exercise4 = new int[3] { 15, 10, 12 };

            //Creating the second Array to copy the elements into.  Below we are initializing the array.  If you don't initialize the array, computer will say that this variable can't be found.
            int[] exercise4New = new int[3]; //3 indicates the size of the array

            //Copying the elements in the first array(exercise4) into the new array (exercise4New) by using Array.Copy() method
            Array.Copy(exercise4, exercise4New, 3); //In Array.Copy() method, in the parenthesis you have to specify the array to be copied, the new array where the elements will be copied to and the length of the array.

            //Printing and Displaying the elements in the Array using ForEach loop
            foreach (var elements4 in exercise4New)
                Console.WriteLine(elements4 + ",");

            
            /*Exercise 5: Count the total number of duplicate elements in an array*/

            //Creating the new Array and indicating its size, which is 3. Also adding values to the array.
            int[] exercise5 = new int[3] { 5, 1, 1 };

            //Creating another array to compare the first element (with index number 0) with
            int[] exercise5Array1 = new int[2] { 1, 1 };

            //Creating another array to compare the second and third elements (with index number 1 and 2) with
            int[] exercise5Array2 = new int[2] { 5, 1 };

            //Determining if there are duplicates in an array.  We will then count how many duplicates there are in the array by using a For loop and then another For and If loop nested in the first For loop.
            //Initializing the variable that will count how many duplicates there are in the array.  If we don't initialize this variable, C# will not let us work with this variable.
            int numOfDuplicates = 0;
            
            //We will traverse through the array to see if there are any duplicated by using a For loop
            for (int i=0; i<2; i++) //i corresponds to the index number of the elements in the array. 
            //Since there is an odd number of values in the exercise 5 array, we will only be looking at two elements in the array since the third element will be compared with the other elements. This is why we only look at the elements with index numbers 0 and 1.
            {

                //Initializing and declaring the currentNumber variable
                int currentNumber = exercise5[i];

                if(currentNumber== exercise5[0])
                {
                    //Nested For loop that will compare the currentNumber to each number in the exercise5Array1 array.
                    for (int j=0; j<2; j++)
                    {
                        if (currentNumber == exercise5Array1[j]) //Comparing the current number with the elements in the exercise5 array
                        {
                            numOfDuplicates++; //This means if there is a duplicate, it will be counted and the variable numOfDuplicates will increase by 1 since there is a duplicate.
                        }
                    }
                } else //When (currentNumber== exercise5[1]) || (currentNumber==exercise5[2])
                {
                    //Nested For loop that will compare the currentNumber to each number in the exercise5Array2 array.
                    for (int j = 0; j < 2; j++)
                    {
                        if (currentNumber == exercise5Array2[j]) //Comparing the current number with the elements in the exercise5 array
                        {
                            numOfDuplicates++; //This means if there is a duplicate, it will be counted and the variable numOfDuplicates will increase by 1 since there is a duplicate.
                        }
                    }
                }
            }

            //Showing in the Console how many duplicates there are in the exercise5 array.
            Console.WriteLine("There are " + numOfDuplicates + " duplicates in the exercise5 array.");


            /*
             * array = 112417
             * int numOfDups = 0; 
             * traverse thru the array which means we are going to have a for loop 
             * for loop that runs from 0th index to the last index 
             *      int currentNumber = array[i]; 
             *      for run from 0th index to the last index 
             *          compare the currentNumber to each item in the array 
             *          if (currentNumber == array[i]) {
             *              numofDups++; 
             *          }  
                */


            /*Exercise 6: Display the unique elements (the only value of its kind) of an array*/
            //Creating the new Array and indicating its size, which is 3. Also adding values to the array.
            int[] exercise6 = new int[3] { 1, 5, 1 };
            //Setting the uniqueValue to zero because we are initializing this variable.
            int uniqueValue = 0;
            

            for(int i=0; i<3; i++)
            {
                int currentValue = exercise6[i]; //Setting the first element in exercise6 as the currentValue

                for(int j=0; j<3; j++)
                {
                    if(currentValue != exercise6[j]) //If the currentValue is not the same as the value it is being compared to, then the value it is being compared to (exercise6[j]) will be the unique value.
                    {
                        uniqueValue = exercise6[j];
                    }
                }
            }
            Console.WriteLine("The unique elements found in the array are: " + uniqueValue);


            /*
            //Creating the new ArrayList and adding elements using the Object Initializer Syntax 
            var exercise6 = new ArrayList()
            {
                1, 5, 1
            };
            //int[] exercise6 = new int[3] { 1, 5, 1 };
            //int uniqueValue = 0;

            //Creating an ArrayList that will contain the unique values of the exercise6 ArrayList
            var uniqueValues = new ArrayList()
            {
                0, 0, 0
            };

            for(int i=0; i<3; i++)
            {
                int currentValue = (int)exercise6[i];
                

                for (int j=0; j<3; j++)
                {
                    int comparedValue = (int)exercise6[j];
                    if (currentValue != comparedValue)
                    {
                        //uniqueValue = exercise6[j];
                        for(int k=0; k<3; k++)
                        {
                            if(comparedValue == uniqueValues[k])
                            {
                                uniqueValues.Remove(k); //Removing the element in uniqueValues ArrayList if the values it is being checked with are the same.
                            } else
                            {
                                uniqueValues.Add(exercise6[j]);
                            }
                        }
                        
                    }
                }
            }

            for(int i=0; i<3; i++)
            {
                Console.WriteLine("The unique elements found in the array are: " + uniqueValues[i]);
            }
            */


            /*Not completed --> Exercise 7: Merging two arrays of the same size sorted in ascending order*/
            //Creating the new Array and indicating its size, which is 3. Also adding values to the array.
            int[] array1Exercise7 = new int[3] { 1, 2, 3 };

            int[] array2Exercise7 = new int[3] { 1, 2, 3 }; //Second array

            //Initializing the array that is going to be used to merge arrays 1 and 2 together.
            int[] array3Exercise7 = new int[6];

            //int space;

            for(int i=0; i<6; i++)
            {
                for(int j=0; j<3; j++)
                {
                    array3Exercise7[i] = array1Exercise7[j];
                }

                if(i>=3)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        array3Exercise7[i] = array2Exercise7[k];
                    }
                }

            }

            foreach (int value in array3Exercise7)
                Console.WriteLine(value);


            /*Exercise 8: Count the frequency of each element in an array*/
            //Creating the new Array and indicating its size, which is 3. Also adding values to the array.
            int[] exercise8 = new int[3] { 25, 12, 43 };

            for(int i=0; i<3; i++)
            {
                int currentValue = exercise8[i];

                //Initializing the frequencyCounter. It is placed here because every time the For loop is being run, we are changing the index of the array, so the frequency counter has to be reset to zero. The frequency counter will change when the code goes to the next For loop.
                int frequencyCounter = 0;
                
                for(int j=0; j<3; j++)
                {
                    if(currentValue == exercise8[j]) //When the current value sees itself in the array, it will add 1 to the frequency counter. 
                    {
                        frequencyCounter++; //Adding a value to the frequencyCounter
                    }
                }

                Console.WriteLine("The value of " + currentValue + " occurs " + frequencyCounter + " times.");

            }


            /*Exercise 9: Find the maximum and minimum element in an array*/
            //Creating the new Array and indicating its size, which is 3. Also adding values to the array.
            int[] exercise9 = new int[3] { 21, 45, 25 };
            //int[] exercise9= new int[3] {45, 25, 21}; //Testing to see if the code works for the above array and this array.

            //Only create arrays that we need.  We only need to show the minimum and maximum values of the exercise9 array, so we only an array to hold one minimum value and an array to hold one maximum value.
            //Creating the minimum array
            int[] minimum = new int[1]; //The initial value inside of minimum array is 0.

            //Creating the maximum array
            int[] maximum = new int[1]; //The initial value inside of maximum array is 0.

            for(int i=0; i<3; i++)
            {
                int currentValue = exercise9[i];

                if((minimum[0]==0) &&(maximum[0]==0)) //If the minimum value is equal to 0, which it will be in the beginning of this loop, make the value in the minimum array set to the first value of the exercise9 array (exercise9[0]).
                {
                    minimum[0] = currentValue; //Adding the currentValue to the minimum Array 
                    maximum[0] = currentValue; //Adding the currentValue to the maximum Array 
                } else if (currentValue < minimum[0]) //If the currentValue is less than the minimum[0] value it will then become the minimum[0] value
                {
                    minimum[0] = currentValue;
                } else if (currentValue > maximum[0]) //If the currentValue is greater than the maximum[0] value, it will become the maximum value.
                {
                    maximum[0] = currentValue;
                }
                              
            }

            Console.WriteLine("The minimum value in the array is " + minimum[0]);
            Console.WriteLine("The maximum value in the array is " + maximum[0]);


            /*Exercise 10: Separate odd and even integers in separate arrays*/

            //Creating the new Array and indicating its size, which is 5. Also adding values to the array.
            int[] exercise10 = new int[5] { 25, 47, 42, 56, 32 };

            //Creating the odd integers array. Using ArrayLists because we don't know how many elements will be going into this array.
            var oddIntegers = new ArrayList();

            //Creating the even integers array.
            var evenIntegers = new ArrayList();

            //Determining if the number is even or odd by first going through all the numbers in the array with a For loop.
            for(int i=0; i<5; i++)
            {
                int currentValue = exercise10[i];

                //Determining if the currentValue number is even or odd by using If/Else statement
                if (currentValue % 2 == 0) //If the currentValue is even, 2 can divide with it evenly, so there will be no remainder (using Modulo)
                {
                    evenIntegers.Add(currentValue);
                } else //If the currentValue is odd (there will be a remainder when currentValue is divided by 2), so the currentValue will then be placed in the oddIntegers ArrayList
                {
                    oddIntegers.Add(currentValue);
                }
            }

            //Have to use ForEach loop to display all the elements in an Array or ArrayList
            foreach(int evenValue in evenIntegers)
                Console.WriteLine("The even elements are " + evenValue); //Displaying the even integers in the Console.

            foreach(int oddValue in oddIntegers)
                Console.WriteLine("The odd elements are " + oddValue); //Displaying the odd integers in the Console.


        }
    }
}
