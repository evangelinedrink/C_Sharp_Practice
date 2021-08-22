using System;

namespace Homework_2_Restuarant_Ordering_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displaying the Welcome Message to the user
            //Console.WriteLine("Hi, Welcome to Tina’s Palace!
            //There is a long line ahead of us so let’s get started :) ");

            //Displaying the menu to the user
            //Console.WriteLine("Here are the items that we offer at our restaurant: ");
            //Goes through the array of items offered at the restaurant and displays them in the Console
            //restaurantMenu();

            //Asking the user what they would like to order and placing their orders in a queue and stack
            //restuarantOrders();

        }

        //Create a new method that displays the menu
        //public static void restaurantMenu(string[] args) 
        /*{
         //Creating an array that contains the list of all the items offered at the restaurant
        string[] menu = {"Chicken Burger", "Biryani", "Mac N Cheese", "Chicken Tikka Masala",
        "Honey Walnut", "Shrimp", "Chow Mein", "Butter Chicken", "Pad Thai", "Flan", "Jalebi",
        "Shrimp Tacos", "Mango Shake"}

        //Using a ForEach loop to display all the menu items to the user (in the Console)
        foreach (string item in menu) 
            Console.WriteLine(item);
        } */

        //Method that will ask user what they would like to order,
        //obtain the orders, and place the orders in a queue and stack
        //public static void restaurantOrders(string[] args)
        /*{
         
        //Creating our queue that will contain the list of orders from the first order to the last orders
        Queue<string> orderList = newQueue<string>();

        //Creating a stack that will display the list of orders based on descending order
        Stack orderTracker = new Stack();

        //Creating an array for the items in the queue, that way it will display the Order #number in the Console.
        //We will use the ToArray() method to do this.
        //string[] orderListArray= orderList.ToArray();
         
         //Creating a loop that will display the question of what they would like to order 
        //and the loop will stop once the user types "Quit" in the Console
        //The loop we will use is a Do/While loop
        //do 
        { //Asking the user what they would like to order
            //Console.WriteLine("What would you like? If you are done ordering, type "QUIT" (all capitalized letters).");
            
            //Obtaining the user's order by using Console.ReadLine()
            string userOrder= ConsoleReadLine();

            //Placing the order in the queue
            orderList.Enqueue(userOrder);

            //Placing the order in the stack
            orderTracker.Push(userOrder);

            //Edge Statement: If the user does not order anything, the following code will be displayed
            if(userOrder == "QUIT") 
            {
                Console.WriteLine("Order Summary for the day: "); 
                Console.WriteLine("List of orders: NONE");
                Console.WriteLine("Order Tracker: NONE");
            }

        } while ( userOrder == "QUIT") 

        

         //Displaying the list of orders to the user 
        //Console.WriteLine("Order Summary for the day:\n List of orders: ");
        
        //Displaying the order number with the item that was ordered using a For loop
        for(int i=0; i< orderListArray.Length; i++) {
        int orderNumber= i+1; 
        string orderDisplay= orderListArray[0];
        Console.WriteLine($"Order #{orderNumber}: orderDisplay");
        
        }

        //Displaying the Order Track to the console (information from the Stack)
        //Console.WriteLine("Order Tracker: ");
        foreach(string orderItem in orderTracker)
        {//Console.WriteLine(orderItem);}

         }*/




        //Method to keep track of orders (this method will contain a queue)
        //userOrder is what the user has typed into the Console (their order(s)
        /*
         public static void restaurantOrdersQueue(string[] args, string userOrder) 
        {
        //Creating our queue that will contain the list of orders from the first order to the last orders
        Queue<string> orderList = newQueue<string>();

        //Placing the orders in the queue
        orderList.Enqueue(userOrder)

        }
         */

        //User will type what they would like to order in the Console. 
        //This input would be obtained by using Console.ReadLine() method
        //Console.
    }
}
