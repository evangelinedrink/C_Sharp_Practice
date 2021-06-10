//Full Name: Evangeline Drink
//Date: May 26, 2021
//File Name: Lesson 2_May26
/*Purpose: The purpose of this code is to try different variables in C# and then to display these variables in the Console.
 * The types of variables that were tested are: int, string, double, and char.
*/
using System;

namespace Lesson_2_May26
{
    class Program
    {
        static void Main(string[] args)
        {
            double oneNumber= 16.5;
            double twoNumber = 0.51;
            //myNum = 15;
            int ageTomorrow = 30;
            string dateTomorrow = "May 27, 2021";
            char firstLetter = 'E'; //char can be a letter or a number.  Write "" + charVariableName to make the char a number.
            char secondLetter = 'D';

            //Display a string in the Console.
            Console.WriteLine("Hello! I'll be turning " + ageTomorrow + " tomorrow." + "Tomorrow will be " +
                                dateTomorrow + ".");
            Console.WriteLine(oneNumber + twoNumber); //Display the results of oneNumber and twoNumber
            Console.Write(""+ firstLetter + secondLetter); //The first "" will make the char variables become string and not numbers. If you use Console.Write(firstLetter + secondLetter), you will get a number (I got 137).
        }
    }
}
