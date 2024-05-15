// Swap two numbers without using third variable

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b= 20;
        Console.WriteLine ($"Before Swapping a={a} b={b}");
        
        a = a+b; //a= 10 + 20
        b = a-b; //b = 10 + 20 - 20
        a = a-b; //b = 10 + 20 - 10
        
        Console.WriteLine ($"After Swapping a={a} b={b}");
        
    }
}

//Output
//Before Swapping a=10 b=20
//After Swapping a=20 b=10
