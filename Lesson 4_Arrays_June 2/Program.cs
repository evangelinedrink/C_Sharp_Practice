using System;

namespace Lesson_4_Arrays_June_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating the grades array
            double[] grades = new double[7];
            grades[0] = 92.3;
            grades[1] = 88.6;
            grades[2] = 70.1;
            grades[3] = 79.4;
            grades[4] = 96.8;
            grades[5] = 82.7;
            grades[6] = 91.9;

            /*Using For loop to show a 1% increase in the grade 
             * becase each student did extra credit assignments*/
            for (int i=0; i<7; i++)
            {
                grades[i] += 1;
                Console.WriteLine("Each student finished all the extra credit assignments. Student's " + i + " grade has been updated to the following value " + grades[i]);
            }

            //Creating the names array
            string[] names= new string[] {"Evangeline", "Daniel", "Irina", "Mary", "Quentin" };
            
            //Indicating who is Evangeline's friend
            for (int i=1; i<5; i++)
            {
                names[i] += " is Evangeline's friend.";
            }

            //Using a For/Each Loop to display in the console.
            foreach(string friend in names)
            {
                Console.WriteLine(friend);
            }
            
        }
    }
}
