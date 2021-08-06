using System;

namespace Lesson_21_Test_Driven_Development_Example_August_8
{
    class Program
    {
        public static void Main(string[] args)
        {
            //For Testing, you will place the correct value inside of the Console.WriteLine with the name of the variable and the correct answer.
            //If the answer shown in the Console comes off as True, that means your code is correct. 
            //If the answer shown in the Console comes off as False, that means your code is not correctly written.
            
            double sum = Add(7.0, 7.0);
            Console.WriteLine((sum == 14.0)); 

            double difference = Substract(21.1, 11.0);
            Console.WriteLine((difference == 10.0)); 

            double quotient = divide(50.0, 2.0);
            Console.WriteLine((quotient == 25.0));

            double product = Multiply(112.2, 3.4);
            Console.WriteLine((product == 381.48));
        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Substract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public static double Multiply(double num1, double num2)
        {
            // To trace error while testing, writing + operator instead of * operator.  
            return num1 + num2;
        }

    }
}
