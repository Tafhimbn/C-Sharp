using System;     // using System means that we can use classes from the System namespace.

namespace HelloWorld {
class Test
    {  // Class name should start from Capital Latter. class is a container for data and methods, 
                // which brings functionality to your program. Every line of code that runs in C# must be inside a class. 

    public static void Main(string[] args)  
        {                                    //Another thing that always appear in a C# program is the Main method. Any code inside its curly brackets {} will be executed. 
                                            // You don't have to understand the keywords before and after Main. You will get to know them bit by bit while reading this tutorial.

        Console.WriteLine("Hello world");  //Console is a class of the "System" namespace, which has a WriteLine() method that is used to output/print text.
        System.Console.WriteLine("12345");  // If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.
        }
            // Every C# statement ends with a semicolon ;.
    }
}