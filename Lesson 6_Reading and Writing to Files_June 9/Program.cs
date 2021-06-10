//Code used for all files in C#
using System;
//Used for Inputs/Outputs (like reading from a file or writing from a file)
using System.IO;

namespace Lesson_6_Reading_and_Writing_to_Files_June_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //try block (Used when the code will run)
            try
            {
                //Using StreamReader to read from a file. 
                //Using statement will also close the StreamReader.
                //The jamaicaText variable is the path to reach the file that we would like StreamReader to read.
                using (StreamReader jamaicaText = new StreamReader("/Users/EvangelineDrink.000/Documents/C# and Microsoft Azure_Skillspire/Lecture 6/Jamaica.txt"))
                {
                    string oneLine; //Stating that the oneLine variable is a string (the letters from the Jamaica.txt file). It will say that what is in the Jamaica.txt are all strings.

                    /*Read and display lines from the file until the end of the file has been reached*/
                    while ((oneLine = jamaicaText.ReadLine()) != null) //as long as there is something in the file, it will read the file
                    {
                        Console.WriteLine(oneLine);
                    }

                }
            } 
            catch (Exception noFile) //If the file can't be found or read, this catch block (error) will display.
            {
                Console.WriteLine("This file can't be read.");
                Console.WriteLine(noFile.Message);
            }
            Console.ReadKey(); //ReadKey() makes the console stay on the screen until you click away from it.

            
            

            //Writing to Files
            using (StreamWriter temperature = new StreamWriter("/Users/EvangelineDrink.000/Documents/C# and Microsoft Azure_Skillspire/Lecture 6/temperaturePractice.txt"))
            {

                //Writing the first sentence in the file.
                string sentence = new string("In this file, I will be displaying the temperature from Fahrenheit to Celcius.");

                //foreach is used for each letter in the sentence (printing it into the file). Letters are considered data type char.
                foreach (char letter in sentence)
                {
                    temperature.Write(letter); //Since we are printing out each letter (not word) with the foreach, we have to use Write() instead of WriteLine(). WriteLine() will display each letter on a line.
                }

                //Typing in the current temperature
                double currentTemperatureF = 64;

                
                //If statment to verify if a temperature has been written
                if (currentTemperatureF !=0.0) //0.0 means null for double data type
                {
                    double degreesC = (currentTemperatureF - 32) * (5.0 / 9.0); //Make sure to have the decimal when dividing with doubles, otherwise it will not calculate.
                                                                                //Making sure that the answer for degrees C has only 2 decimal points.
                    degreesC = Math.Round(degreesC, 2); //When you have already defined your variable, you don't have to type the data type again. This is why it is degreesC and not double degreesC.

                    //This will write the line below to the temperaturePractice.txt file (which we have given the variable "temperature".
                    temperature.WriteLine("The temperature of " + currentTemperatureF + " degrees F is equal to " + degreesC + " in degrees Celcius.");
                }

                //Read and show what is displayed in the file in the Console
                /*string line = "";
                using (StreamReader temperatureFile= new StreamReader("/Users/EvangelineDrink.000/Documents/C# and Microsoft Azure_Skillspire/Lecture 6/temperaturePractice.txt"))
                {
                    //Read and display lines from the file until the end of the file has been reached
                     while ((line = temperatureFile.ReadLine()) != null) //as long as there is something in the file, it will read the file
                        {
                            Console.WriteLine(line);
                        }
                }*/

 }


}
}
}
