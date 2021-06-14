//Code used for all files in C#
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


                for (int line = 1; line < 3; line++)
                {
                    //Declaring the first and second lines (firstPart and secondPart variables) which are left blank until the if/else statement. 
                    string firstPart = ""; //Empty string because we are just declaring the variable. The variable for this will be filled in during the If/Else statement.
                    string secondPart = ""; //Empty string because we are just declaring the variable. The variable for this will be filled in during the If/Else statement.

                    //Declaring the array named lineArray.  line inside of string[line] specifies the length of the array (always need to specify the length of an array in C#).
                    string[] lineArray = new string[line];

                    if (line == 1)
                    {
                        firstPart = "Input line " + line + ": this is the first line."; //firstPart variable now has a value.
                        lineArray[0] = firstPart; //The sentence above (firstPart) will be the first object in the array, lineArray[0], with an array index of 0.
                    }
                    else
                    {
                        secondPart = "Input line " + line + ": this is the second line."; //secondPart variable now has a value.
                        lineArray[1] = secondPart; //The sentence above (secondPart) will be the second object in the array, lineArray[1], with an array index of 1.
                    }

                    //Displaying in the Console.
                    Console.WriteLine(firstPart + secondPart);

                    //Displaying the lineArray in the arrayExercise6.txt file
                    //ForEach loop is used to iterate over every single letter, object in an array.  It will check all of the things, you don’t have to specify the exact number of things to display or read. 
                    foreach (string lineText in lineArray) //For each object (lineText variable, was created on this line) in the lineArray, do the following code below (which is to write the object from the array to the arrayExercise6.txt file).
                    {
                        array.WriteLine(lineText); //This will add each object from the lineArray and place it in the arrayExercise6.txt file.
                    }
                }
            }

            /*Exercise 7: Create a file and write some text which omits (does not contain) some information from the text (selecting which text to display in the file).*/
            using (StreamWriter deleteWord = new StreamWriter("/Users/EvangelineDrink.000/Documents/C# and Microsoft Azure_Skillspire/Lecture 7_Practice Reading and Writing Files/deleteWordExercise7.txt"))
            {
                string sentence1 = "The quick brown fox jumps";
                string sentence2 = "over the lazy dog.";

                //Using the Contains() method to check if a string contains a word or not.  From this website: https://www.tutorialspoint.com/How-to-check-if-a-string-contains-a-certain-word-in-Chash  
                if (sentence1.Contains("fox") == false)
                {
                    deleteWord.WriteLine(sentence1); //This will add the sentence (sentence1 variable) to the deleteWordExercise7.txt file (deleteWord variable).
                }
                else
                {
                    Console.WriteLine("The line containing the word fox will not be displayed in the .txt file."); //The line containing the word "fox" will not be written in the .txt file since there is no WriteLine() method. This line will display in the Console.
                }

                //Checking to see if the second sentence (sentence2) has the word "fox" in it. If the sentence doesn't contain the word fox, then the sentence will be added to the .txt file.
                if (sentence2.Contains("fox") == false)
                {
                    deleteWord.WriteLine(sentence2); //This will add the sentence (sentence2 variable) to the deleteWordExercise7.txt file (deleteWord variable).
                }
                else
                {
                    Console.WriteLine("The line containing the word fox will not be displayed in the .txt file."); //The line containing the word "fox" will not be written in the .txt file since there is no WriteLine() method. This line will display in the Console.
                }
            }


                        
        }



    }
 }
