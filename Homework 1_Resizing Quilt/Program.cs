﻿using System;

namespace Homework_1_Resizing_Quilt
{
    class Program
    {
        static void Main(string[] args)
        {
            line1();
            line2();
            line3();
            line4(); //End of the first half of quilt
            line4(); //Start of the second half of quilt
            line3();
            line2();
            lineSpace(); //Creating a space between different lines of the quilt.
            line1();

            /*Pseudocode for Homework 1: Resizing Quilts*/
            //Each line of the quilt has its own Method. The Parameter is important because it will determine the number of dots that will be placed in the quilt.
            //Create methods for resizing the quilt (if we don't have a method, the code will run the same the entire time.
            //The For loop looks good for producing the diamonds and periods.


            /*For line 1*/
            //Create 6 blank spaces in line (might use a For loop where initialization corresponds to the position of the space on the line until the 7th space on line)
            //For spaces 7-10, follow the following code (might use a For loop with and If/Else statement to create the < or >)
            //On the 7th space (and 9th space), insert a <
            //On the 8th space (and 10th space), insert a >
            //Insert 6 additional blank spaces in the line (use a For loop for this. i will correspond to the space on the line (space 11 until the 16th space)

            /*For line 2*/
            //Create 4 blank spaces in line (use For loop)
            //In the 5th and 6th spaces, create the < (5th space) and > (6th space) parts (maybe a For loop and nest in the If/Else statement for the < and >)
            //Create the 4 dots in spaces 7-10 (Can use a For loop to print out the dots)
            //For the 11th and 12th spaces, create the < (11th space) and the > (12th space)
            //For lines 13 to 16, create a blank space on the line.

            /*For line 3*/
            //Create 2 blank spaces in line (use For loop)
            //In the 3rd and 4th space, create the < and > (I think I can use a For loop for the <> and . ). After creating the diamond, use a nested loop (like another For loop) to create the periods.
            //Create the dots in spaces 5-12 (nested For loop)
            //For lines 13 and 14, create the < (line 13) and > (line 14)
            //For lines 15 and 16, create blank spaces in the line.

            /*For line 4*/
            //There are no blank spaces in line 4 of the quilt
            //Diamonds: For spaces 1 and 2, create the < and >. For spaces 15 and 16, also create the < and >.
            //The rest of the spaces in the fourth line are dots.  This is why a If/Else If / and Else statement will be used.

            /*For lines 5 to 8*/
            //Since lines 5 to 8 are lines 4 to 1 in descending order, I just placed lines 4 to 1 in reverse order in the Main method.

            /*Creating different size quilts*/
            //I will use a formula that will calculate the number of spaces in the front and back of the quilt
            //Equation for blank spaces in the front of the quilt: line number * -2 + 8
            //First Diamond comes after first blank spaces. This means it will take up 2 spaces in the line and have line numbers after first blank spaces.
                //Line 1 for Diamonds: The diamonds will be multiplied by the size that the user wants. For size 1 (original size), there are 2 diamonds.
                //For size 2x, there are 4 diamonds.
                //Equation for Line 1 for Diamonds is: size indicated by user * 2 (2 corresponds to two complete diamonds, <> )
            //Dots: Dots are between the diamonds. If a person asks for 2x the size of the original quilt, for line 2 there will be 8 dots.
                //Equation for dots in line 2 is: size indicated  by user * 4
                //Equation for dots in line 3 is: size indicated  by user * 8
                //Equation for dots in line 4 is: size indicated  by user * 12
            //Second Diamond comes before the last blank spaces. This means it will take up 2 spaces in the line and have line numbers before the last blank spaces.
            //Equation for blank spaces in the back of the quilt: 4 * line number - 4

        }

        /*
        //Since a method is required to do only one thing, this method will be used to adjust the starting spaces
        public static void frontSpaces()
        {
            Console.Write(" ");
        }
        */

        //Creating a space between each of the lines of the quilt with the lineSpace() method.
        public static void lineSpace()
        {
            Console.WriteLine("\n");
        }

        public static void line1()
        {
            for(int i=1; i<=17; i++) //Including borders: 0,19. Not including borders: 1,17 There are 16 spaces in each line (not considering the border of the loop). This For loop will incorporate all the spaces (which corresponds to i) in the line.  If we consider the borders of the quilt, you would need these parameters:  (space 1 (represented by i=0) and 18 (represented by i=18) are the borders of the quilt)
            {
                /*
                //Creating the border of the quilt for line 1
                if(i==0) 
                {
                    Console.Write("|"); //Creating the side borders of the quilt
                }
                */      

                //Create 6 blank spaces in line (might use a For loop where initialization corresponds to the position of the space on the line until the 7th space on line)
                for (i = 1; i < 7; i++)
                {
                    Console.Write(" "); //This states for each space (represented by i), the Console will place an empty space (represented by " ").  We want this on one line, so we use Console.Write instead of Console.WriteLine.
                }

                //For spaces 7-10, follow the following code (might use a For loop with and If/Else statement to create the < or >)
                //On the 7th space (and 9th space), insert a <
                //On the 8th space (and 10th space), insert a >
                for (i = 7; i < 11; i++)
                {
                    int currentValue = i;

                    if ((currentValue == 7) || (currentValue == 9))
                    {
                        Console.Write("<");
                    }
                    else
                    {
                        Console.Write(">");
                    }
                }

                //Insert 6 additional blank spaces in the line (use a For loop for this. i will correspond to the space on the line (space 11 until the 16th space)
                for (i = 11; i < 17; i++)
                {
                    Console.Write(" "); //This states for each space (represented by i), the Console will place an empty space (represented by " ").  We want this on one line, so we use Console.Write instead of Console.WriteLine.
                }

                /* Ending border keeps repeating the pattern multiple times in a loop.
                //Creating the border of the quilt for line 18
                if (i == 18)
                {
                    Console.Write("|"); //Creating the side borders of the quilt
                }
                */
            }
            
        }

        
        public static void line2()
        {
            //Creating a new line for the second line pattern
            Console.WriteLine("\n");
            
            //There are 16 spaces in each line that corresponds to the quilt. The variable i corresponds to one space in the line
            for(int i=1; i<17; i++)
            {
                //Create 4 blank spaces in line (use For loop)
                for (i = 1; i < 5; i++)
                {
                    Console.Write(" "); //This states for each space (represented by i), the Console will place an empty space (represented by " ").  We want this on one line, so we use Console.Write instead of Console.WriteLine.
                }

                //In the 5th and 6th spaces, create the < (5th space) and > (6th space) parts (maybe a For loop and nest in the If/Else statement for the < and >)
                //Create the 4 dots in spaces 7-10 (Can use a For loop to print out the dots)
                //For the 11th and 12th spaces, create the < (11th space) and the > (12th space)
                for (i = 5; i < 13; i++)
                {
                    if ((i == 5) || (i == 11))
                    {
                        Console.Write("<");
                    }
                    else if ((i == 6) || (i == 12))
                    {
                        Console.Write(">");
                    }
                    else
                    {
                        Console.Write("."); //For spaces 7 to 10, a period will be placed on the line.
                    }
                }

                //For lines 13 to 16, create a blank space on the line.
                for (i = 13; i < 17; i++)
                {
                    Console.Write(" ");
                }
            }
            
        }

        public static void line3()
        {
            //Creating a new line for the third line pattern
            Console.WriteLine("\n");

            //There are 16 spaces in each line that corresponds to the quilt. The variable i corresponds to one space in the line
            for(int i=1; i<17; i++)
            {
                //Create 2 blank spaces in line (use For loop)
                for (i = 1; i < 3; i++)
                {
                    Console.Write(" ");
                }

                //In the 3rd and 4th space, create the < and > (I think I can use a For loop for the <> and . ). After creating the diamond, use a nested loop (like another For loop) to create the periods.
                //Create the dots in spaces 5-12 (nested For loop)
                //For lines 13 and 14, create the < (line 13) and > (line 14)
                for (i = 3; i < 15; i++)
                {
                    if ((i == 3) || (i == 13))
                    {
                        Console.Write("<");
                    }
                    else if ((i == 4) || (i == 14))
                    {
                        Console.Write(">");
                    }
                    else
                    {
                        Console.Write(".");  //Creating the dots in spaces 5-12
                    }
                }

                //For lines 15 and 16, create blank spaces in the line.
                for (i = 15; i < 17; i++)
                {
                    Console.Write(" ");
                }
            }
            
        }

        public static void line4()
        {
            //Creating a new line for the third line pattern
            Console.WriteLine("\n");

            for (int i=1; i<17; i++)
            {
                //Diamonds: For spaces 1 and 2, create the < and >. For spaces 15 and 16, also create the < and >.
                if((i==1) || (i==15))
                {
                    Console.Write("<");
                } else if ((i==2) || (i == 16))
                {
                    Console.Write(">");
                }
                else
                {
                    Console.Write("."); //Creating the dots in the fourth line. Since there are no spaces in the fourth line, the rest will just be dots.
                }
                
            }

        }

    }
}
