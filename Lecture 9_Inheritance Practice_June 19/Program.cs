using System;

namespace Lecture_9_Inheritance_Practice_June_19
{
    class Laptops
    {
       
        public virtual void information()
        {
            
            //Declaring the variables that will be used to explain the different types of laptops.
            string name = " ";
            string price = " ";
            string processor = " ";
            string ram = " ";
            string hdd = " ";
            
        }
    }
    class Lenovo: Laptops
    {
        public override void information()
        {
            string name = "Name: Lenovo";
            Console.WriteLine(name); //This will display the name of each laptop in the Console.
            
            string price = "Price: $1000";
            Console.WriteLine(price); //This will display the price of each laptop in the Console.
            
            string processor = "Processor: i3";
            Console.WriteLine(processor); //This will display the processor of each laptop in the Console.
            
            string ram = "RAM: 2GB";
            Console.WriteLine(ram); //This will display the ram of each laptop in the Console.
            
            string hdd = "HDD: 500GB";
            Console.WriteLine(hdd); //This will display the hdd of each laptop in the Console.
        }
    }

    class Dell: Laptops
    {
        public override void information()
        {
            string name = "Name: Dell";
            Console.WriteLine(name); //This will display the name of each laptop in the Console.
            
            string price = "Price: $1500";
            Console.WriteLine(price); //This will display the price of each laptop in the Console.
            
            string processor = "Processor: i5";
            Console.WriteLine(processor); //This will display the processor of each laptop in the Console.

            string ram = "RAM: 4GB";
            Console.WriteLine(ram); //This will display the ram of each laptop in the Console.

            string hdd = "HDD: 1TB";
            Console.WriteLine(hdd); //This will display the hdd of each laptop in the Console.
        }
        
    }

    class Sony: Laptops
    {
        public override void information()
        {
            string name = "Name: Sony";
            Console.WriteLine(name); //This will display the name of each laptop in the Console.

            string price = "Price: $2000";
            Console.WriteLine(price); //This will display the price of each laptop in the Console.

            string processor = "Processor: i9";
            Console.WriteLine(processor); //This will display the processor of each laptop in the Console.

            string ram = "RAM: 8GB";
            Console.WriteLine(ram); //This will display the ram of each laptop in the Console.

            string hdd = "HDD: 1TB";
            Console.WriteLine(hdd); //This will display the hdd of each laptop in the Console.
        }
        
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            Lenovo descriptionLenovo = new Lenovo();
            descriptionLenovo.information(); //We are calling this method to be run by the computer. The Console.WriteLine() method is already in the information() method.

            Dell descriptionDell = new Dell();
            descriptionDell.information(); //We are calling this method to be run by the computer. The Console.WriteLine() method is already in the information() method.

            Sony descriptionSony = new Sony();
            descriptionSony.information(); //We are calling this method to be run by the computer. The Console.WriteLine() method is already in the information() method.
        }
    }
}
