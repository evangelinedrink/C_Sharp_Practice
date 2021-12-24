using System;
using System.Collections.Generic; //Need to have this for the Dictionary

namespace LeetCode_December_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercise 1: Two Sum */
            /*
            int[] nums = new int[] { 2,7,11,0,15,2,9};
            int target = 9;

            for(int i=0; i<= nums.Length-1; i++)
            {
                //Initializing the sum and k variables
                int sum = 0;
                int k = 0;

                if(i< nums.Length-1)
                {
                    k = i + 1;

                    sum = nums[i] + nums[k];
                }
                
                if(sum== target)
                {
                    Console.WriteLine($"[{i}, {k}]");
                }
            }
            */

            /*Exercise 1: Two Sum Advance*/
            //This uses a Dictionary containing key and value pairs that will be used to contain the answers
            /*
            int[] nums = new int[] { 2, 7, 11, 0, 15, 2, 9 };
            int target = 9;

            //Creating the Dictionary which takes pairs (key and its value)
            //Information about the Dictionary: https://www.tutorialsteacher.com/csharp/csharp-dictionary 
            IDictionary<int,int> results = new Dictionary <int, int>();

            //Using two For loops for i and k make sense because we are selecting two values that equal the target.
            //Using the two For loops for selecting two items follows the Simple Combination Algorithm. More information about it can be found here: https://dev.to/rrampage/algorithms-generating-combinations-100daysofcode-4o0a 
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                //Initializing the sum and k variables
                int sum = 0;
                int k = 1;
                //Copying the values from the nums array
                int current = nums[i];

                for (k=0; k< nums.Length; k++)
                {
                    sum = current + nums[k];

                    //Making sure that the sum is the same as the target value and that the index i is not the same as index k
                    //Makes sure that the result does not contain the key k (which is the index of the next number) as a key because it is considered a 
                    //value when it is with i. i is the key and k is the value = [i, k] = [key, value]
                    if ((sum == target) && (i != k) && (!results.ContainsKey(k)))
                    {
                        results[i] = k;

                    }
                }


            }

            //Displaying the results in the Console.
            foreach (KeyValuePair<int, int> answer in results)
                Console.WriteLine("[{0},{1}]", answer.Key, answer.Value);
            */

            /*HackerRank Exercise: Compare the Triplets*/
            //From: https://www.hackerrank.com/challenges/compare-the-triplets/problem?isFullScreen=true
            /*
            //Creating the arrays that contain Alice and Bob's ratings
            List<int> a = new List<int>() { 1, 2, 3 };
            List<int> b = new List<int>() { 3, 2, 1 };

            //Creates a size two array that contains Alice and Bob's score
            List<int> INTEGER_ARRAY = new List<int>() { 0, 0 };

            for (int i = 0; i < a.Count; i++)
            {
                //This variable will have Alice's value
                int aliceCurrent = a[i];

                //This variable will have Bob's value
                int bobCurrent = b[i];

                //Using If Else/If statements for the comparisons
                if (aliceCurrent > bobCurrent)
                {
                    //Alice will get awarded 1 point
                    INTEGER_ARRAY[0] += 1;
                }
                else if (aliceCurrent < bobCurrent)
                {
                    //Bob will get awarded 1 point
                    INTEGER_ARRAY[1] += 1;
                }
                else if (aliceCurrent == bobCurrent)
                {
                    //This will return to the beginning of the For loop
                    continue;
                }
            }
            //Returning the array containing their points
            //return INTEGER_ARRAY;
            //Displaying the values in the INTEGER_ARRAY 
            Console.WriteLine("[{0} {1}]", INTEGER_ARRAY[0], INTEGER_ARRAY[1]);
            */

            /*HackerRank Exercise: A Very Big Sum*/
            //From: https://www.hackerrank.com/challenges/a-very-big-sum/problem?isFullScreen=true

            //Creating the List that will contain the large numbers
            List<int> ar= new List<int>() { 5, 1000000001, 1000000002 , 1000000003, 1000000004, 1000000005 };

            //This will keep the sum of the integers
            //Always end the Long data type with an L . Described in this website: https://www.w3schools.com/cs/cs_data_types.php
            long LONG_INTEGER = 0L;

            for (int i = 0; i < ar.Count; i++)
            {
                LONG_INTEGER += ar[i];
            }
            //return LONG_INTEGER;
            Console.WriteLine(LONG_INTEGER);
        }
    }
}
