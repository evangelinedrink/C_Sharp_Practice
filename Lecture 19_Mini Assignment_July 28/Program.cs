using System;


namespace Lecture_19_Mini_Assignment_July_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 9 in Mini Assignment 2
            int[] list = new int[] { 2, 4, 6, 8, 10, 12};
            int lengthList = list.Length - 2;
            for (int i=0; i< lengthList; i++)
            {
                if(list[i+1] > list[i])
                {
                    list[i + 1] = list[i] + (i + 1);
                }
            }
            foreach (int value in list)
                Console.WriteLine(value);

            //Problem 11 in Mini Assignment 2
            //Creating the temperatures arrays with the values
            double[] temperatures = new double[] { 100, 56, 78, 87, 45, 67, 89 };

            //Determining the size of the temperatures array
            int sizeTemperatures = temperatures.Length;

            //Declaring the sumTemp variable, which will hold the sum of all the values in the temperatures array
            double sumTemp = 0;

            //Calculating the sum of all the temperatures in the temperatures array
            for(int i=0; i<sizeTemperatures; i++)
            {
                sumTemp += temperatures[i];
                         
            }

            //Computing the average temperature from the values in the temperatures array
            double averageTempNotRounded = sumTemp / sizeTemperatures;

            //Calculating the average temperature with two decimal places. The 2 means you will have numbers displayed to up to 2 decimal places.
            double averageTemp = Math.Round((Double)averageTempNotRounded, 2);

            //Code for displaying the outputs of this program:
            Console.WriteLine("The temperature was taken across " + sizeTemperatures + " days."); 

            //Displaying the temperature for each day
            for(int i=0; i<sizeTemperatures; i++)
            {
                int day = i + 1;
                Console.WriteLine($"Day {day}'s high temperature: {temperatures[i]}"); //Using template literals
            }
            
            //Displaying the average temperature in the Console. The String.Format will place the average temperature to two decimal places.
            Console.WriteLine("The average temperature is: " + averageTemp);

            //Determining and Displaying how many days were above the average
            //Declaring the aboveAverage temperature to count how many days were above the average temperature.
            int aboveAverage = 0; 
            for(int i=0; i<sizeTemperatures; i++)
            {
                if (temperatures[i] > averageTemp)
                {
                    aboveAverage += 1;
                }
            }
            //Using template literals to display how many days were above the average temperature
            Console.WriteLine($"{aboveAverage} days were above the average temperature.");
        }
    }
}
