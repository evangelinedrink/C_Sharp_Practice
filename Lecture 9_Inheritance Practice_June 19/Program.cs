using System;

namespace Lecture_9_Inheritance_Practice_June_19
{

    //Practice Problem is from this website: https://www.completecsharptutorial.com/basic/c-inheritance-programming-questions.php 

    //Second Attempt for Displaying Laptop Information with Inheritance
    //In this attempt, the information for each computer will be in the Parent Class (class Laptops).
    //Child Class will be used to get the information from the Parent Class and add it to a string containing the tags of "Name: , Price:" . This will be in class Descriptions.
    //Program Class will contain the Main Method that will run the code, that way it can be displayed in the Console.
    class Laptops
    {
        //Declaring and Initializing all of our Name variables as public constant variables.
        //Constant variable is a variable whose value can't be changed in the running of the file.
        public const string nameLenovo = "Lenovo";
        public const string nameDell = "Dell";
        public const string nameSony = "Sony";

        //Declaring and Initializing all of our Price variables as public constant variables (using keyword const).
        //Constant variable is a variable whose value can't be changed in the running of the file.
        public const string priceLenovo = "$1000";
        public const string priceDell = "$1500";
        public const string priceSony = "$2000";

        //Declaring and Initializing all of our Processor variables as public constant variables (using keyword const).
        //Constant variable is a variable whose value can't be changed in the running of the file.
        public const string processorLenovo = "i3";
        public const string processorDell = "i5";
        public const string processorSony = "i9";

        //Declaring and Initializing all of our RAM variables as public constant variables (using keyword const).
        //Constant variable is a variable whose value can't be changed in the running of the file.
        public const string ramLenovo = "2GB";
        public const string ramDell = "4GB";
        public const string ramSony = "8GB";

        //Declaring and Initializing all of our HDD variables as public constant variables (using keyword const).
        //Constant variable is a variable whose value can't be changed in the running of the file.
        public const string hddLenovo = "500GB";
        public const string hddDell = "1TB";
        public const string hddSony = "1TB";
    }

    class Descriptions : Laptops
    {
        //Creating a method (which is named Lenovo) that will be called in the class Program
        public void Lenovo()
        {
            string name = "Name: " + nameLenovo;
            string price = "Price: " + priceLenovo;
            string processor = "Processor: " + processorLenovo;
            string ram = "RAM: " + ramLenovo;
            string hdd = "HDD: " + hddLenovo;

            //Will display the name, price, processor, ram and hdd in the Console for this computer.
            Console.WriteLine(name);
            Console.WriteLine(price);
            Console.WriteLine(processor);
            Console.WriteLine(ram);
            Console.WriteLine(hdd);

        }

        //Creating a method (which is named Dell) that will be called in the class Program
        public void Dell()
        {
            string name = "Name: " + nameDell;
            string price = "Price: " + priceDell;
            string processor = "Processor: " + processorDell;
            string ram = "RAM: " + ramDell;
            string hdd = "HDD: " + hddDell;

            //Will display the name, price, processor, ram and hdd in the Console for this computer.
            Console.WriteLine(name);
            Console.WriteLine(price);
            Console.WriteLine(processor);
            Console.WriteLine(ram);
            Console.WriteLine(hdd);
        }

        //Creating a method (which is named Sony) that will be called in the class Program
        public void Sony()
        {
            string name = "Name: " + nameSony;
            string price = "Price: " + priceSony;
            string processor = "Processor: " + processorSony;
            string ram = "RAM: " + ramSony;
            string hdd = "HDD: " + hddSony;

            //Will display the name, price, processor, ram and hdd in the Console for this computer.
            Console.WriteLine(name);
            Console.WriteLine(price);
            Console.WriteLine(processor);
            Console.WriteLine(ram);
            Console.WriteLine(hdd);
        }
    }

    //This Program class will run our files
    class Program
    {
        //The Main Method will run the program and display the information in the Console.
        static void Main(string[] args)
        {

            //Getting information from the Descriptions class. Always use the class names in the front of this statement and after the new keword (don't use the names of the methods within the class, it won't run).
            Descriptions information = new Descriptions();
            information.Lenovo(); //Let the computer get information (run) from the Lenovo() method that is in the Descriptions class.
            information.Dell(); //Let the computer get information (run) from the Dell() method that is in the Descriptions class.
            information.Sony(); //Let the computer get information (run) from the Sony() method that is in the Descriptions class.
        }
    }

    //First Attempt for Displaying Laptop Information with Inheritance.  Deleting the comment below to run this code for the First Attempt.
    /*
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

    */

}
