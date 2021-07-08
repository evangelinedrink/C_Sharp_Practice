using System;
using System.Collections; //Need to use this command when working with ArrayLists

namespace Lecture_14_ArrayLists_Practice_July_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Array and ArrayList Exercises found at this website: https://www.w3resource.com/csharp-exercises/array/index.php*/

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


            //Determining if there are duplicates in an array.  We will then count how many duplicates there are in the array by using a For loop and then another For and If loop nested in the first For loop.

            //Initializing the variable that will count how many duplicates there are in the array.  If we don't initialize this variable, C# will not let us work with this variable.
            int numOfDuplicates = 0;
            
            //We will traverse through the array to see if there are any duplicated by using a For loop
            for (int i=0; i<3; i++) //i corresponds to the index number of the elements in the array.
            {
                //Initializing and declaring the currentNumber variable
                int currentNumber = exercise5[i];

                //Nested For loop that will compare the currentNumber to each number in the exercise5 array.
                for (int j=1; j<3; j++)
                {
                    if(currentNumber== exercise5[j]) //Comparing the current number with the elements in the exercise5 array
                    {
                        numOfDuplicates++; //This means if there is a duplicate, it will be counted and the variable numOfDuplicates will increase by 1 since there is a duplicate.
                        Console.WriteLine(numOfDuplicates);
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

            
        }
    }
}
