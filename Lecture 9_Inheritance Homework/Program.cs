using System;

namespace Lecture_9_Inheritance_Homework
{
    //Parent Class will contain the information for the base pay, benefits and bonus. Parent Class will be called class Base.
    //Child Class will be used to get the information from the Parent Class and add it to a string containing the tags of "Name: , Price:" . This will be in class Descriptions.
    //Program Class will contain the Main Method that will run the code, that way it can be displayed in the Console.

    class Base
    {
        //Declaring and Initializing the base pay for each employee. This variable will be a public constant variables (using keywords public const).
        //Constant variable is a variable whose value can't be changed in the running of the file.
        public const int basePay = 60000;

        //Declaring and Initializing the base benefits for each employee.
        public const int baseBenefits = 5;

        //Declaring and Initializing the base bonus for each employee.
        public const int baseBonus = 2000;

        //The ID will change for each employee, which is why it is in a public virtual void ID() method that will override the value of ID based upon which class is being called.
        public virtual void ID()
        {
         //Declaring the ID for each employee. This is left blank here because the ID changes for each employee.
         string ID = " ";
        }
        
    }

    class Custodian : Base //Custodian class inherits data from class Base
    {
        //Below are variables that will be used in the ID() method. The ID() method is what will be run in the Main Method (which is located in class Program).

        //Pay that the Custodian receives. The static keyword means you can access this variable/class anywhere in the C# file.
        public static int custodianPay = basePay;
        
        //Benefits that the Custodian receives. The static keyword means you can access this variable/class anywhere in the C# file.
        public static int custodianBenefits = baseBenefits + 3;

        //Bonus that the Custodian receives. The static keyword means you can access this variable/class anywhere in the C# file.
        public static int custodianBonus = baseBonus;


        //Creating the ID() method. The ID method name has to be the same as the method name used in the Parent class that it is overriding.
        //This ID method will be called in the Main Method.  This is why the Console.WriteLine is in this ID method instead of being above.
        //If Console.WriteLine is above, nothing will show in the Console.
        public override void ID()
        {
            //Declaring the ID for the Custodian.
            string ID = "Custodian";

            //Displaying the above information (pay, benefits, bonus and ID) in the Console.
            Console.WriteLine("Custodian's Salary: " + "$" + custodianPay);
            Console.WriteLine("Custodian's Benefits: " + custodianBenefits);
            Console.WriteLine("Custodian's Bonus: $" + custodianBonus);
            Console.WriteLine("ID: " + ID);

        }

    }

    class Developer : Custodian //Developer class inherits data from Custodian class (this means that there is multi-level inheritance). Developer class gets information from Custodian and Base classes.
    //Custodian is the Parent class of the Developer class.
    {

        //Below are variables that will be used in the ID() method. The ID() method is what will be run in the Main Method (which is located in class Program).

        //Pay that the Developer receives. The static keyword means you can access this variable/class anywhere in the C# file.
        public static int developerPay = basePay + 40000;

        //Benefits that the Developer receives
        public static int developerBenefits = custodianBenefits;

        //Bonus that the developer receives
        public static int developerBonus = baseBonus;



        //Creating the ID() method. This ID method will be called in the Main Method.  This is why the Console.WriteLine is in this ID method instead of being above.
        //If Console.WriteLine is above, nothing will show in the Console.
        public override void ID()
        {
            //Declaring the ID for the Developer.
            string ID = "Developer";

            //Displaying the above information (pay, benefits, bonus and ID) in the Console.
            Console.WriteLine("Developer's Salary: " + "$" + developerPay);
            Console.WriteLine("Developer's Benefits: " + developerBenefits);
            Console.WriteLine("Developer's Bonus: $" + developerBonus);
            Console.WriteLine("ID: " + ID);
        }

    }


    class Manager : Developer //Manager class inherits data from Developer class (this means that there is multi-level inheritance). Manager class gets information from Developer, Custodian and Base classes.
    //Developer is the Parent class of the Manager class.
    {

        //Below are variables that will be used in the ID() method. The ID() method is what will be run in the Main Method (which is located in class Program).

        //Pay that the Manager receives.
        public static int managerPay = developerPay;

        //Benefits that the Manager receives
        public static int managerBenefits = developerBenefits;

        //Bonus that the Manager receives
        public static int managerBonus = baseBonus + 10000;



        //Creating the ID() method. This ID method will be called in the Main Method.  This is why the Console.WriteLine is in this ID method instead of being above.
        //If Console.WriteLine is above, nothing will show in the Console.
        public override void ID()
        {
            //Declaring the ID for the Manager.
            string ID = "Manager";

            //Displaying the above information (pay, benefits, bonus and ID) in the Console.
            Console.WriteLine("Manager's Salary: " + "$" + managerPay);
            Console.WriteLine("Manager's Benefits: " + managerBenefits);
            Console.WriteLine("Manager's Bonus: $" + managerBonus);
            Console.WriteLine("ID: " + ID);
        }

    }

    class VicePresident: Manager //Vice President class inherits data from Manager class (this means that there is multi-level inheritance). Vice President class gets information from Manager, Developer, Custodian and Base classes.
    //Manager is the Parent class of the Vice President class.
    {

        //Below are variables that will be used in the ID() method. The ID() method is what will be run in the Main Method (which is located in class Program).

        //Pay that the Vice President receives.
        public static int vicePresidentPay = managerPay + 50000;

        //Benefits that the Vice President receives
        public static int vicePresidentBenefits= managerBenefits;

        //Bonus that the Vice President receives
        public static int vicePresidentBonus= managerBonus;



        //Creating the ID() method. This ID method will be called in the Main Method.  This is why the Console.WriteLine is in this ID method instead of being above.
        //If Console.WriteLine is above, nothing will show in the Console.
        public override void ID()
        {
            //Declaring the ID for the Vice President.
            string ID = "Vice President";

            //Displaying the above information (pay, benefits, bonus and ID) in the Console.
            Console.WriteLine("Vice President's Salary: " + "$" + vicePresidentPay);
            Console.WriteLine("Vice President's Benefits: " + vicePresidentBenefits);
            Console.WriteLine("Vice President's Bonus: $" + vicePresidentBonus);
            Console.WriteLine("ID: " + ID);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Getting information from the Custodian Class
            Custodian informationCustodian = new Custodian();
            informationCustodian.ID(); //Running the ID() method from the Custodian class

            //Getting information from the Developer Class
            Developer informationDeveloper = new Developer();
            informationDeveloper.ID(); //Running the ID() method from the Developer class

            //Getting information from the Manager Class
            Manager informationManager = new Manager();
            informationManager.ID(); //Running the ID() method from the Manager class

            //Getting information from the Vice President's Class
            VicePresident informationVP = new VicePresident();
            informationVP.ID(); //Running the ID() method from the Manager class
        }
    }

}




