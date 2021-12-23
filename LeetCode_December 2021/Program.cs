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
        }
    }
}
