using System;

namespace Lecture_20_Polymorphism_July_31
{
    class Program
    {
        //Main Component is used to run and display the items in the Console.
        //In this example, Main is being used to call all 4 classes that were created.
        static void Main(string[] args)
        {
            //Creating an Animal Object (Animal Class is the parent class)
            Animal animal = new Animal();

            //Creating a Giraffe Object (Giraffe class is the child class of the Animal class)
            //Animal giraffe = new Giraffe(); <= by doing this, you will be able to use the descriptionGiraffe() method since we are getting information just from the Animal class

            //Creating a Giraffe Object (Giraffe class is the child class of the Animal class)
            Giraffe giraffe = new Giraffe();

            //Creating a Cat Object
            Cat cat = new Cat();

            //Creating a Hippo Object that is the child class if Giraffe (thus also the child class of Animal)
            Hippo hippo = new Hippo();

            //Displaying items in the Console
            animal.description();

            giraffe.description();
            giraffe.descriptionGiraffe();

            cat.descriptionCat();

            hippo.description();
            hippo.descriptionGiraffe();
            hippo.hippoHeightWeight();
            hippo.hippoDescription();
        }
    }
    class Animal
    {
        //Method
        public void description()
        {
            Console.WriteLine("I am an animal");
        }
              
    }

    //Giraffe is the child class of Animal
    class Giraffe : Animal
    {
        //Public string means that it can be seen within other classes
        public string height = "10 feet";
        public string weight = "80 pounds";

        //Public Method for Giraffe (not found in Animal class)
        public void descriptionGiraffe()
        {
            Console.WriteLine("I am big and tall!");
        }
    }

    //Cat is the child class of Animal
    class Cat : Animal
    {
        //Public Method that describes what a cat likes to do
        public void descriptionCat()
        {
            Console.WriteLine("I am a cat and I love to sleep...");

            //Declaring the countingZ variable
            string countingZ ="z"; 

            //Printing zzz 24 times in the Console.
            for(int i=1; i<24; i++)
            {
                countingZ += "z";
            }

            Console.WriteLine(countingZ);

        }

    }

    //Hippo class is the child class of Giraffe and Animal classes
    class Hippo : Giraffe
    {
        //Creating a method to display the hippo's height and weight (which it inherited from the Giraffe class)
        public void hippoHeightWeight()
        {
            Console.WriteLine($"The hippo's height and weight are: {height} and {weight}");
        }

        //Method describing Happy the Hippo
        public void hippoDescription()
        {
            //Declaring the variable that will hold the information about Happy the Hippo
            string happy = "My name is Happy the Hippo!";

            //For loop that will recreate the sentence above 99 more times to get this sentance to appear 100 times
            for(int i=0; i<99; i++)
            {
                happy += "\n My name is Happy the Hippo!"; //The \n produces a new line to display this sentence
            }

            Console.WriteLine(happy);
        }
    }
}
