using System;

namespace Lesson_5_Methods_and_Parameters_June5
{
    class Program
    {
        static void Main(string[] args) //All Methods are called in the Main section (static void Main(string[] args).
        {
            //Calling (running) methods
            multiplyingNumbers();
            yourNumber();

            //Calling (running) methods using values to parameters
            fToCTemperature(90); //Degree in Fahrenheit is in the parameters.
            groceryList("avocados", 6); //Item to buy (string) and quantity to buy (int)

        }

        //Declaring and Defining Methods

        /*multiplyingNumbers method multiples some numbers by 2 and
        displays results in the Console.*/
        public static void multiplyingNumbers()  //Declare and Define Methods using "public static void"
        {
            for (double x=0; x<=15; x++)
            {
                double answer = x * 2;
                Console.WriteLine(answer);
            }
        }

        /*yourNumber method increases the ticket number by 1 every time the code runs and
        displays results in the Console.*/
        public static void yourNumber()
        {
            int ticket = 1;
            do 
            {
                Console.WriteLine("Your number is " + ticket + ". To win the lottery, you need to have number 9.");
                ticket += 1;
            } while (ticket < 10);
        }

        /*fToCTemperature method will convert the temperature in Fahrenheit to Celcius
         * and display this in the Console.*/
        public static void fToCTemperature(double fahrenheit)
        {
            double degreesC = (fahrenheit - 32) * (5.0 / 9.0); //Make sure to have the decimal when dividing with doubles, otherwise it will not calculate.
            //Making sure that the answer for degrees C has only 2 decimal points.
            degreesC = Math.Round(degreesC, 2); //When you have already defined your variable, you don't have to type the data type again. This is why it is degreesC and not double degreesC.
            Console.WriteLine("The temperature of " + fahrenheit + " degrees F is equal to " + degreesC + " in degrees Celcius.");
        }

        /*groceryList method will write out what you need to
         * buy in a sentence that will show in the Console.*/
        public static void groceryList(string item, int quantity)
        {
            Console.WriteLine("You need to buy " + quantity +" "+ item + ".");
        }

    }
}
