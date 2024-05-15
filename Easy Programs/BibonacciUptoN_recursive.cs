
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a=0;
        int b=1;
        int n=10;
        Console.Write($"{a} {b} ");
        printFib(a,b,n);
    }
    
    public static void printFib(int first,int second,int n){
        if(n<=0){
            return;
        }
        //Console.Write($"n = {n}\n");
        int third = first + second;
        Console.Write($"{third} ");
        printFib(second,third,n - 1);
    }
    
    
}

//Output
//0 1 1 2 3 5 8 13 21 34 55 89 
