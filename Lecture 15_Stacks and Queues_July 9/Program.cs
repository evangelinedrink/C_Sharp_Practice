using System;
using System.Collections; //This is needed when working with any C# Methods and also with Stacks and Queues.

namespace Lecture_15_Stacks_and_Queues_July_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stacks Practice

            //Declaring (creating) the Stack.  Name of the Stack is crate.
            Stack crate = new Stack();

            //Adding elements in the Stack using the Push() method
            crate.Push("Potatoes"); //First element placed in the stack, so it will be last element in the stack. Last In First Off (LIFO)
            crate.Push("Onions");
            crate.Push("Beets");
            crate.Push("Garlic");

            //Checking to see if the Stack contains an element using Contains() method
            Console.WriteLine(crate.Contains("Beets")); //Displays True in the Console
            Console.WriteLine(crate.Contains("Eggs"));  //Displays False in the Console

            //Checking to see the first element in the Stack (which was the last element placed in the Stack) using the Peek() method
            Console.WriteLine(crate.Peek()); //Displays Garlic in the Console.

            //Poping the last element placed in the Stack (which is the first element seen in the Stack) by using the Pop() method.
            Console.WriteLine(crate.Pop()); //Displays Garlic in the Console, but will remove Garlic from the crate Stack.

            //Displaying all the values inside of the Stack
            //There is no index number for Stacks, which is why we use a ForEach Loop that will go through all the elements in the stack.
            foreach (string elements in crate)
            {
                Console.Write(elements + " "); //Displays Beets, Onions and Potatoes in the Console.
            }


            //Queue

            //Declaring (creating) a new Queue. The name of the Queue is parking.
            Queue parking = new Queue();

            //Adding the cars with their owners information in the Queue
            parking.Enqueue("Mercedes-Benz, Owner: Quentin");
            parking.Enqueue("Pontiac, Owner: Evangeline");
            parking.Enqueue("Toyota, Owner: Daniel");
            parking.Enqueue("Jeep, Owner: Irina");

            //Displaying how many values are in the parking Queue using Count.
            Console.WriteLine( "\n" + parking.Count);  //What WriteLine does is it writes the stuff in the parenthesis and then goes to a new line. 
                                                       //Since in Line 35, we are using Console.Write, the count number will be placed after Potatoes. To put the count number in its own line we have to use the "\n" to create a new line and then it will display what comes next in the new line.

            //Displaying the values in the parking Queue using a ForEach loop.
            foreach(string information in parking)
            {
                Console.WriteLine(information);
            }

            //Displaying the values in a Queue using a While Loop (we could also use a ForEach loop to do this) since we are getting rid of values from the Queue. Since we are using the Dequeue() method, we are getting rid of each value in the Queue and displaying that value in the Console. It will show the first element in the queue and then get rid of it.
            while (parking.Count > 0)
                Console.WriteLine("\n" + parking.Dequeue()); //"\n" is creating a new line where we will see values in the Console.

         
        }
    }
}
