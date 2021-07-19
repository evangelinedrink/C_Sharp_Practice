using System;
using System.Collections.Generic;

namespace Lecture_17_LinkedList_July_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a LinkedList of data type String
            LinkedList<String> restaurantOrders = new LinkedList<String>();

            //Adding notes to the restaurantOrders LinkedList
            restaurantOrders.AddFirst("Quentin: Lasagna");
            restaurantOrders.AddLast("Evangeline: Salmon Pizza");
            restaurantOrders.AddLast("Irina: Greek Veggie Bowl");
            restaurantOrders.AddLast("Daniel: Cesar Salad");
            restaurantOrders.AddLast("Anna: French Fries");

            
            //Determine how many orders have been placed by using the Count method
            int numberOfOrders = restaurantOrders.Count;

            Console.WriteLine("The number of orders that you have is: " + numberOfOrders);

            
            //Displaying the First Order in the LinkedList using First.Value and also checking if the LinkedList is empty or not
            if (restaurantOrders.Count >0)
            {
                Console.WriteLine(restaurantOrders.First.Value);
            } else
            {
                Console.WriteLine("There are no orders in your LinkedList.");
            }

            
            //Displaying the Last Order in the LinkedList using Last.Value and also checking if the LinkedList is empty or not
            if (restaurantOrders.Count > 0)
            {
                Console.WriteLine(restaurantOrders.Last.Value);
            }
            else
            {
                Console.WriteLine("There are no orders in your LinkedList.");
            }

            
            //Displaying the nodes (in this example, orders) in the LinkedList using ForEach Loop
            foreach (string order in restaurantOrders)
            {
                Console.WriteLine("\n" + order); //This will give an extra line space in the Console to display all the restaurant orders.
            }

            //Deleting the first order using Remove() method (once the chef has finished cooking that order) and then displaying the rest of the orders from the list.
             restaurantOrders.Remove(restaurantOrders.First);

            //Giving a space between the last Console line
            Console.WriteLine("\n");

            foreach (string nextOrders in restaurantOrders)
                 Console.WriteLine(nextOrders);
            
        }
    }
}
