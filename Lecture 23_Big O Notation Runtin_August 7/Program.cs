using System;

namespace Lecture_23_Big_O_Notation_Runtin_August_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*First Big O Notation Example: Search a number in the list and determine how many times it is in the list*/
            //An array of numbers
            int[] numberList = new int[] {5, 4, 7, 8, 7, 9};

            //Counter to display how many times the number 7 appears
            int counterSeven = 0;

            //Displays if the number 7 appears in the array of numbers
            bool sevenAppears= false; //initial value is false

            //Determining how many times the number 7 appears
            for(int i=0; i<numberList.Length; i++)
            {
                if(numberList[i] == 7)
                {
                    sevenAppears = true;
                    counterSeven += 1; //Adding one to the counter if 7 appears in the array
                }
            }
            Console.WriteLine("Does the number seven appear in the number list? : " + sevenAppears);
            Console.WriteLine("The number 7 appears " + counterSeven + " times in the number's array.");

            //This is O(n) notation

            /*Second Big O Notation Example: Arranging numbers in an array by decreasing size*/
            int[] numberExample = new int[] { 5, 8, 1, 3 };
            
            for(int i=0; i<numberExample.Length; i++)
            {
                int currentValue = numberExample[i];

                for(int k=i+1; k<numberExample.Length; k++)
                {
                    if (currentValue < numberExample[k])
                    {
                        int placeHolder = currentValue;
                        numberExample[i] = numberExample[k];
                        numberExample[k] = placeHolder;
                    }
                }
            }
            Console.WriteLine("Here are the numbers in decreasing order: ");
            foreach(int value in numberExample)
                Console.Write(value);

        }


    }
}
