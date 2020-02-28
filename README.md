# ClassesObjects-In-CSHARP
A little program for explaining the syntax of classes and obejects in CSHARP without use any YouTube tutorial or something

# Notice
To understand more check the comments in the script

 ``` ClassesObjects-In-CSHARP/LearningConsole/Program.cs ```
 
 This is the class structure :smile:
 
``` class Cars
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
```

And this is the main function where I link some data and make an initialize for an object from the class

``` static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); // A normal line
            Cars mycar = new Cars(); // create a new obj from Cars's class
            mycar.Speed = 210; // get the speed's property a value
            Console.WriteLine(mycar.Speed); // display its value
            mycar.printSomething(); // using a method inside the Cars's class
            Console.ReadKey();
        }
```
