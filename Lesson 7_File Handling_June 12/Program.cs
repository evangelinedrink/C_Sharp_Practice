﻿//Code used for all files in C#
using System;
//Used for Inputs/Outputs (like reading from a file or writing from a file)
using System.IO;

namespace Lesson_7_File_Handling_June_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writing to Files.  C# Programming Exercises, Practice, Solution: https://www.w3resource.com/csharp-exercises/file-handling/index.php  

            /*Exercise 1: Writing a Program in C# to create a blank file*/
            using (StreamWriter test = new StreamWriter("/Users/EvangelineDrink.000/Documents/C# and Microsoft Azure_Skillspire/Lecture 7_Practice Reading and Writing Files/mytest.txt"))
            {
                //Writing the first sentence in the file.
                string sentence = "A file created with name mytext.txt";

                //The sentence above will be displayed in the mytest.txt file.
                test.WriteLine(sentence);
            }

            /*Exercise 2: Writing a program to remove a file with C#*/
            //The File.Delete(path) method is used to delete a file in C#.
            //The File.Delete() method takes the full path (absolute path wiht file name) of the file deleted.
            //If the file doesn't exist, no exception is thrown.

            //Creating a variable for the path to the mytext.txt
            string testFile = "/Users/EvangelineDrink.000/Documents/C# and Microsoft Azure_Skillspire/Lecture 7_Practice Reading and Writing Files/mytest.txt";

            //Deleting the mytest.txt file using the File.Delete() method.
            File.Delete(testFile);

            //Using template literals to display that mytest.txt file has been deleted in the Console.
            Console.WriteLine($"The path for this file: {testFile} is not found. It has been deleted.");


            /*Exercise 3: Creating a new file if the file doesn't already exist. If the file exists, the file with the same name won't be created.*/

            //Making the file path for "mytest.txt" into a String data type so File.Exists() method can be used to check if it exists in the file or not
            string test3String = "/Users/EvangelineDrink.000/Documents/C# and Microsoft Azure_Skillspire/Lecture 7_Practice Reading and Writing Files/mytest.txt";

            //Checking to see if a file with the same name has been created. File.Exists() method returns a Boolean (True or False). Explanation of File.Exists() method: https://www.c-sharpcorner.com/UploadFile/dbeniwal321/check-if-a-file-exists-in-C-Sharp/ 
            if (File.Exists(test3String) == true)
            {
                Console.WriteLine($"This file already exists, so it will not be created. The name of the file is: {test3String}.");
            }
            else
            {
                //Creating a file with the name mytest.txt
                using (StreamWriter test3 = new StreamWriter("/Users/EvangelineDrink.000/Documents/C# and Microsoft Azure_Skillspire/Lecture 7_Practice Reading and Writing Files/mytest.txt"))
                {
                    //Writing a sentence to be placed in the mytest.txt file.
                    string sentence = "Congratulations! You have created this file.";

                    //The sentence above will be displayed in the mytest.txt file.
                    test3.WriteLine(sentence);
                }
            }


            /*Exercise 4: Create a file and add some text. */
            /*Exercise 5: Create a file with some text and then read the file. */

            //Creating a file with the name mytest.txt
            using (StreamWriter test4 = new StreamWriter("/Users/EvangelineDrink.000/Documents/C# and Microsoft Azure_Skillspire/Lecture 7_Practice Reading and Writing Files/mytest4.txt"))
            {
                //Writing a sentence to be placed in the mytest4.txt file.
                string sentence = "Writing some text to place in this file. Hooray!";
                string sentences = "\nHere is the content of the file mytest.txt:\n Hello and Welcome\n It is the first content\n of the text file mytest.txt";

                //The sentence above will be displayed in the mytest4.txt file.
                test4.WriteLine(sentence + sentences);
            }

            //Reading a file
            //try block (used when the code will run). Always use a try/catch block when reading a file because the file you want to read might not be there.
            try
            {
                //Using StreamReader to read from a file. using statement will also close the StreamReader.
                using (StreamReader test4Read = new StreamReader("/Users/EvangelineDrink.000/Documents/C# and Microsoft Azure_Skillspire/Lecture 7_Practice Reading and Writing Files/mytest4.txt"))
                {
                    string information; //Ensuring that the information in the text file is a String data type.

                    //Read and display lines from the file until the end of the file has been reached.
                    while ((information = test4Read.ReadLine()) != null) //null means nothing, so as long as there is a file, the file will be read.
                    {
                        Console.WriteLine(information);
                    }
                }
            }
            catch (Exception fileName) //If the file can't be found or read, this catch block (error) will display.  Always need the Exception and then the name of the file.
            {
                Console.WriteLine("This file can't be read because it is either not there or is damaged.");
                Console.WriteLine(fileName.Message); //The message above will be displaced with the error.
            }


            /*Exercise 6: Create a file and write an array of strings to the file.*/
            //Writing the array file called arrayExercise6.txt
            using (StreamWriter array = new StreamWriter("/Users/EvangelineDrink.000/Documents/C# and Microsoft Azure_Skillspire/Lecture 7_Practice Reading and Writing Files/arrayExercise6.txt"))
            {
                

                for(int line=1; line<3; line++)
                {
                    //Declaring the first and second lines (firstPart and secondPart variables) which are left blank until the if/else statement. 
                    string firstPart = ""; //Empty string because we are just declaring the variable. The variable for this will be filled in during the If/Else statement.
                    string secondPart = ""; //Empty string because we are just declaring the variable. The variable for this will be filled in during the If/Else statement.


                    if (line==1)
                    {
                        firstPart = "Input line " + line + ": this is the first line.";
                    } else 
                    {
                        secondPart= "Input line " + line + ": this is the second line.";
                    }

                    //Displaying in the Console.
                    Console.WriteLine(firstPart + secondPart);

                    //Writing the lines in an array
                    string[] lineArray = new string[] { firstPart, secondPart };

                    //Place the information from the array into the arrayExercise6.txt file
                    //array.WriteLine(lineArray);


                    


                }
            }
        }
    }
}