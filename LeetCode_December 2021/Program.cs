using System;

namespace LeetCode_December_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercise 1: Two Sum */
            int[] nums = new int[] { 3,3 };
            int target = 6;

            for(int i=0; i<= nums.Length-1; i++)
            {
                //Initializing the sum and k variables
                int sum = 0;
                int k = 0;

                if(i< nums.Length - 1)
                {
                    k = i + 1;

                    sum = nums[i] + nums[k];
                }
                
                if(sum== target)
                {
                    Console.WriteLine($"[{i}, {k}]");
                }
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
