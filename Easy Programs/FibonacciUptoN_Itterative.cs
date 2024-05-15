
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a = 0;
        int b = 1;
        
        int n=20;
        Console.Write($"{a} {b} ");
        for(int i=2;i<n; i++)
        {
                int c = a+b;
                Console.Write($"{c} ");
                a = b;
                b = c;
        }
        
    }
}

//Output
//0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181 6765 10946 
