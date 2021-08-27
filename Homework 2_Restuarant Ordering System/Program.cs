using System;
using System.Collections; //This will enable us to use Stacks
using System.Collections.Generic; //This will let us use the Queue

namespace Homework_2_Restuarant_Ordering_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating our queue that will contain the list of orders from the first order to the last orders
            Queue<string> orderList = new Queue<string>();

            //Displaying the Welcome Message to the user
            Console.WriteLine("Hi, Welcome to Tina’s Palace!\n There is a long line ahead of us so let’s get started :) ");

            //Displaying the menu to the user
            Console.WriteLine("Here are the items that we offer at our restaurant: ");
            //Goes through the array of items offered at the restaurant and displays them in the Console
                //restaurantMenu();
            //Creating an array that contains the list of all the items offered at the restaurant
            string[] menu = {
                "Chicken Burger",
                "Biryani",
                "Mac N Cheese",
                "Chicken Tikka Masala",
                "Honey Walnut Shrimp",
                "Chow Mein",
                "Butter Chicken",
                "Pad Thai",
                "Flan",
                "Jalebi",
                "Shrimp Tacos",
                "Mango Shake"
            };

            //Using a ForEach loop to display all the menu items to the user (in the Console)
            foreach (string item in menu)
                Console.WriteLine(item);

            //Within this For loop, we are making all the values in the menu uppercased. This is being done because user's input is going to be placed in uppercase letters
            //The code will verify that the user's input(s), which is uppercase letters, corresponds to an item in the menu (which all of the menu's items are becoming upper cased letters in the For loop below.
            for(int i=0; i< menu.Length; i++)
            {
                menu[i]= menu[i].ToUpper();
            }
            //Asking the user what they would like to order and placing their orders in a queue and stack
            //Passing in the menu array to the restaurantOrders() method, that way we can use the menu array (which has all upper case elements) in that method
            restaurantOrders(menu);

        }

        //Create a new method that displays the menu
        /*public static void restaurantMenu()
        {
            //Creating an array that contains the list of all the items offered at the restaurant
            string[] menu = {
                "Chicken Burger",
                "Biryani",
                "Mac N Cheese",
                "Chicken Tikka Masala",
                "Honey Walnut Shrimp",
                "Chow Mein",
                "Butter Chicken",
                "Pad Thai",
                "Flan",
                "Jalebi",
                "Shrimp Tacos",
                "Mango Shake"
            };

            //Using a ForEach loop to display all the menu items to the user (in the Console)
            foreach (string item in menu)
                Console.WriteLine(item);
        }*/

        //Method that will ask user what they would like to order,
        //obtain the orders, and place the orders in a queue and stack
        //Passing in the string data type menu to the restaurantOrders method
        public static void restaurantOrders(string[] menu)
        {

            //Creating our queue that will contain the list of orders from the first order to the last orders
            Queue<string> orderList = new Queue<string>();

            //Creating a stack that will display the list of orders based on descending order
            Stack orderTracker = new Stack();

            //Declaring the variable userOrder (the user can type in lower or upper cased)
            string userOrder = "";



            //Creating a loop that will display the question of what they would like to order 
            //and the loop will stop once the user types "Quit" in the Console
            //The loop we will use is a Do/While loop
            do
            { //Asking the user what they would like to order
                Console.WriteLine("What would you like? If you are done ordering, type 'Quit' in the Console.");

                //Obtaining the user's order by using Console.ReadLine()
                //Taking the user's input and placing it in upper case by using the ToUpper() method.
                userOrder = Console.ReadLine().ToUpper();


                //Checking to see if the item typed in by the user is in the menu
                //Using Array.Exists() function to check this: This function returns a Boolean.
                //True if the element exists in the array, False if the element does not exist in the array.
                //The other condition (userOrder!="Quit") ensures that the code within this If statement will not run when the user types Quit in the Console
                if (((Array.Exists(menu, item => item == userOrder)) == false) || (userOrder!="QUIT"))
                {
                    Console.WriteLine("The item that you are trying to order is not in our menu. Please select an item from our menu.");

                    //Asking the user what they would like to order
                    Console.WriteLine("What would you like? If you are done ordering, type 'Quit' in the Console.");

                    //Obtaining the user's order by using Console.ReadLine()
                    //Taking the user's input and placing it in upper case by using the ToUpper() method.
                    userOrder = Console.ReadLine().ToUpper();
                };
                
                
                //Placing the order in the queue
                orderList.Enqueue(userOrder);

                //Placing the order in the stack
                orderTracker.Push(userOrder);

                //Placing the order in the array
                //orderListArray.Add(userOrder);

            } while (userOrder != "QUIT"); //If the condition inside of the While Loop is true, the code inside of the body will run. If user doesn't type "QUIT", they will be prompted to what they would like to addionally order.

            //Creating an array for the items in the queue, that way it will display the Order #number in the Console.
            //We will use the ToArray() method to do this.
            String[] orderListArray = orderList.ToArray();

            //Edge Statement: If the user does not order anything, the following code will be displayed
            if (orderListArray[0] == "QUIT")
            {
                Console.WriteLine("Order Summary for the day: ");
                Console.WriteLine("List of orders: NONE");
                Console.WriteLine("Order Tracker: NONE");
            }

            


            //Diplaying the elements in the array
            /*foreach(string item in orderListArray)
                {
                    Console.WriteLine(item);
                }
            */

            //This If statement will make sure that the QUIT statement isn't displayed as an order
            if (orderListArray[0] != "QUIT")
            {   //Displaying the list of orders to the user 
                Console.WriteLine("Order Summary for the day:\n List of orders: ");
            }

                //Displaying the order number with the item that was ordered using a For loop
                for (int i = 0; i < orderListArray.Length; i++)
            {
                int orderNumber = i + 1;
                string orderDisplay = orderListArray[i];

                //This If statement will make sure that the QUIT statement isn't displayed as an order
                if (orderDisplay != "QUIT")
                    Console.WriteLine($"Order #{orderNumber}: {orderDisplay}");
            }

            //Displaying the Order Track to the console (information from the Stack)
            if (orderListArray[0] != "QUIT")
            {
                Console.WriteLine("Order Tracker: ");
            }
            foreach (string orderItem in orderTracker)
            {
                if (orderItem != "QUIT")
                {
                    Console.WriteLine(orderItem);
                }

            }




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
}
