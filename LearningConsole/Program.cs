using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); // A normal line
            Cars mycar = new Cars(); // create a new obj from Cars's class
            mycar.Speed = 210; // get the speed's property a value
            Console.WriteLine(mycar.Speed); // display its value
            mycar.printSomething(); // using a method inside the Cars's class
            Console.ReadKey();
        }
    }
    class Cars
    {
        public int Speed // This is a property
        {
            get;
            set;
        }
        public void printSomething() // And this is a method!
        {
            Console.WriteLine("This is a method! from the cars's class");
        }
    }
}
