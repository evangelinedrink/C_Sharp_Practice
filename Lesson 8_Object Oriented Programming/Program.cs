using System;

namespace Lesson_8_Object_Oriented_Programming
{
    //Classes are used to state the variables and the Class with Objects (only one Class that has a Main() containing the objects in each C# file) takes the variables and runs the program.

    //Creating a Class (this is the Parent Class)
    class Substance_IonicCompound
    {
        //Declaring the variable substances that can be inherited to the child classes.
        string substances = "Sodium Chloride Crystals";
    }

    //Creating the Molecule class. Molecule class is a child class to the parent class (Substance_IonicCompound). Molecule class has inherited the substance variable.
    class Molecule : Substance_IonicCompound
    {
        string molecule= "Sodium Chloride";
        string chemicalFormula = "NaCl";
     }

    //Creating the 
    
    /*
    //Creating a Class (this is the Parent Class)
    class Substance_IonicCompound
    {
        //Initializing the variables for the class.
        string substance;

        //Declaring the variable substances that can be inherited to the child classes.
        string substances= "Sodium Chloride Crystals";

        //Objects are always placed inside of Main(). You can only have one Main() in the .cs file.
        static void Main(string[] args)
        {
            //Letting computer get/use the variable "substance" from the Chemistry_IonicBonding class.
            Substance_IonicCompound ionicCompound= new Substance_IonicCompound();
            ionicCompound.substance = "Sodium Chloride Crystals";
            Console.WriteLine(ionicCompound.substance);
        }
    }

    */



}
