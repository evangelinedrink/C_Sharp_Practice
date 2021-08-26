using System;

namespace Lecture_25_Pair_Programming_August_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare all the variables to be used in the methods
            string userYear="";
            string userMonth="";
            string userDay="";

            //Methods to run to ask for user input
            userInputYear();
            
            while (userYear)
            {
                userInputMonth();

                //Edge Case Restrictions: If user types in a number above 12 or below 1, an error will appear
                if ((Convert.ToInt32(userMonth) > 12) || (Convert.ToInt32(userMonth) < 1))
                {
                    Console.WriteLine("There is an error. You have to type the number for the month, it has to be 1 or above and 12 is the maximum. Please type in the corresponding number for the month");
                }
            }

            userInputDay();


            //Determine the day of the week for the date typed by the user
            DateTime dateValue = new DateTime(Convert.ToInt32(userYear), Convert.ToInt32(userMonth), Convert.ToInt32(userDay));
            string userDate = dateValue.ToString("dddd");

            //Run the todaysTemp method
            todaysTemp(userDate);

            //Method that will ask the user what the year is
            static void userInputYear()
            {
                //Ask User what today's date is
                Console.WriteLine("What is the year?");
                //User will type today's date in the Console and Console will read what is typed
                string userYear = Console.ReadLine();
            }

            //Method that will ask the user what month the date is in
            static void userInputMonth()
            {
                Console.WriteLine("What is the month? Please write it in number form. If it is May, you would type 5.");
                //User will type today's date in the Console and Console will read what is typed
                string userMonth = Console.ReadLine();

                //Converting userMonth to an integer
                Convert.ToInt32(userMonth);
                /*
                //Edge Case Restrictions: If user types in a number above 12 or below 1, an error will appear
                if ((Convert.ToInt32(userMonth) > 12) || (Convert.ToInt32(userMonth) < 1))
                {
                    Console.WriteLine("There is an error. You have to type the number for the month, it has to be 1 or above and 12 is the maximum. Please type in the corresponding number for the month");
                       
                }
                */


            }

            //Method that will ask the user what the day is
            static void userInputDay()
            {
                Console.WriteLine("What is the day? Please type the number of the day.");
                //User will type today's date in the Console and Console will read what is typed
                string userDay = Console.ReadLine();
            }
        }
        //Pre-conditions: The input placed by the user has to be converted into integers to be passed through the DateTime method. The variable from the DateTime method will then be called userDate.
        //userDate has to be a string that says what the day of the week is. userDate will be pased into the todaysTemp method.
        public static void todaysTemp(string userDate) 
        {
            

            //Display what the user has written in the Console
            Console.WriteLine("Today's date is: " + userDate);


            //Temperatures for that area during the week
            double[] weekTemps = { 78.2, 80.4, 82.5, 77.6, 73.2, 71.7, 82.3 };

            //Declaring the temperature for that date
            double todayTemp = 0.0;

            //Determining the temperature based on the day of the week
            if (userDate == "Monday")
            {
                todayTemp = weekTemps[0];
            } else if (userDate == "Tuesday")
            {
                todayTemp = weekTemps[1];
            } else if (userDate == "Wednesday")
            {
                todayTemp = weekTemps[2];
            } else if (userDate == "Thursday")
            {
                todayTemp = weekTemps[3];
            } else if (userDate == "Friday")
            {
                todayTemp = weekTemps[4];
            } else if (userDate == "Saturday")
            {
                todayTemp = weekTemps[5];
            } else if (userDate == "Sunday")
            {
                todayTemp = weekTemps[6];
            }

            //Displaying the temperature to the user on the Console.
            Console.WriteLine($"The temperature for {userDate} is: {todayTemp} degrees F.");
        }
    }
}
