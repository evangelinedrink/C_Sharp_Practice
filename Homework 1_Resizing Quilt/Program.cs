using System;

namespace Homework_1_Resizing_Quilt
{
    class Program
    {
        static void Main(string[] args)
        {
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

            /*For line 3*/
            //Create 2 blank spaces in line (use For loop)
            //In the 3rd and 4th space, create the < and > (I think I can use a For loop for the <> and . ). After creating the diamond, use a nested loop (like another For loop) to create the periods.
            //Create the dots in spaces 5-12 (nested For loop)
            //
        }
    }
}
