using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int from = 10;
        int to = 20;
        
        for(int i = from; i <= to ; i++)
        {
            bool isPrime = true;
            for(int j=2 ; j <= (i/2); j++)
            {
            //Console.WriteLine($"n % i = {n % i}");
                if(i % j == 0)
                {
                    isPrime = false;
                    break;
                }
                
            }
            if(isPrime)
            {
                Console.WriteLine($"{i}");
            }
        
        }
        
    }
}
