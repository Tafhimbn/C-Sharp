﻿using System;     // using System means that we can use classes from the System namespace.

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



/*
   C# is type safe object-oriented language.
   Enable developers to build a variety of secure and robust applications like: Web Development (ASP.NET), Desktop Applications (Windows Forms, WPF), Game Development (Unity), Cloud & AI Applications
   It was developed by microsoft within the .NET Framework  

*/



/*
Data type under variable:
Datatype variable_name = value;   =>    int x = 10;

Data type under constant:
const Datatype ConstVariable_Name = value;   =>    const int y = 10;

C# has two different types of Datatype

1) Primitive:

it supports all datatype of C and C++ language


int   ----> 4byte (C# has Int16, Int32, Int64) 
float ----> 4byte, 8 bytes (float size depends on ox base 32 and 64) 
char  ----> 2byte 
string ---> Based on no of chars 
boolean --> It returns a true or false value using 1 and 0

2) Derived Datatype:-
This type of Datatype was specially Created by .NET Framework that is common for all .NET Supported programming languages. 

object: It can contain all types of elements means the object is the common type in the .NET framework we can assign int, float, char, and String type data under an object. 

object o=10; 
object o="hello"; 

StringBuilder: It is used to contain String type data similar to string but StringBuilder is a mutable object means we can dynamically change the value from the actual address. 

Class: It is used to define the characteristics of an object using data member and member function, it can contain a collection of elements. 

Structure: It contains a collection of datatype but it is a value type container of c#. 

Enumeration:- It is called Constant Array means we can define a set of values using enum, for example, if we want to define colors then we can create an enum set. 

Array:- It can contain elements in Proper Sequence, an array can store more than one element using a single variable.
 
Collection: It Can contain a similar and di-similar type of elements both, it is an enhancement of an array. 

DateTime:- It Can contain Date Time type Values. 

Most Important Question of C# for an Interview:
What is the boxing and unboxing concept in C#? 
or 
What is implicit and explicit conversion in C#?

Answer 
Boxing means to convert the value of value type elements to reference type, which means if we convert integer type value to object type then called boxing. 

Boxing is also called implicit because it will convert the data automatically. 

Unboxing means converting reference type elements to value type, which means if we convert object type to integer type then concept. 

Unboxing is also called explicit conversion because it will convert the data manually. 

Example of Boxing and Unboxing using the program?

Memory allocation based on data type?
*/
using System;
class Add
{
 static void Main()
 {
    object o,x=10;
    int y;
    o=x;     // int to object (Boxing)
    y =(int)o; // object to int (Unboxing)
    Console.WriteLine(o +" "+y);
  }
}
/*
C# has two different types of memory to store data.

1) Stack Memory :-
It is used to contain the value of int, char, float, double and boolean type elements, it will store data directly hence it is also called direct memory
allocation.
Ex: int a = 10;

2) Heap Memory :-
It is used to contain the value according to reference String, Object these all are reference type. It is also called Indirect Memory. Also called Dynamic Memory.
Ex: string s= new string("Hello World");

*/