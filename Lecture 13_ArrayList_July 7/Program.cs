using System;
using System.Collections; //You will need this when you are working with an ArrayList, otherwise the code will not work.

namespace Lecture_13_ArrayList_July_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // The ArrayList class included in the System.Collections namespace.
            // Create an object of the ArrayList using the new keyword.

            //Creating an ArrayList
            var ArrayList1 = new ArrayList(); // recommended (var means variable). Using var just lets your computer know that it is a variable, but you don't know what data type the ArrayList will have.

            // Adding Elements in ArrayList
            // Use the Add() method or object initializer syntax to add elements in an ArrayList.
            // An ArrayList can contain multiple null and duplicate values.

            // adding elements using ArrayList.Add() method. For the Add() Method, you will add the data at the end of the ArrayList.
            ArrayList1.Add("Pineapple: One Piece");
            ArrayList1.Add(2.00);
            ArrayList1.Add("Apple: 1 pound");
            ArrayList1.Add(0.99);
            ArrayList1.Add("Orange: 1 pound");
            ArrayList1.Add(1.50);

            // Accessing an ArrayList
            // The ArrayList class implements the IList interface.
            // So, elements can be accessed using indexer, in the same way as an array.
            // Index starts from zero and increases by one for each subsequent element.
            // An explicit casting to the appropriate types is required, or use the var variable.

            //Access individual item using indexer. You need to indicate the data type that is in the ArrayList, otherwise you will get an error.
            string fruitName1 = (string)ArrayList1[0];
            double fruitPrice1 = (double)ArrayList1[1];

            //Displaying some of the values in the ArrayList
            Console.WriteLine(fruitName1);
            Console.WriteLine(fruitPrice1);

            // Remove Elements from ArrayList
            // Use the Remove(), RemoveAt(), or RemoveRange methods to remove elements from an ArrayList.
           ArrayList1.RemoveRange(1, 3);

            
            // Insert Elements in ArrayList
            // Use the Insert() method to insert an element at the specified index into an ArrayList.
            // Signature: nameOfArrayList.Insert(int index, Object value)
            ArrayList1.Insert(6, "Cherries: 1 pound"); //6 indicated the index number, meaning "Cherries: 1 pound" will be the 6th item in the ArrayList
            ArrayList1.Insert(7, 3.75);

            //To display the values in an ArrayList, you will need to use ForEach or a For Loop
            //Using a ForEach to iterate (go over) over all the values in the ArrayList
            foreach (var values in ArrayList1) //var is a variable (it can be used for any data type), ArrayList1 is the name of the ArrayList
                Console.WriteLine(values); //The values (variable name) for each item in the ArrayList will be displayed.


        }
    }
}
