using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var origNumber = int.Parse(Console.ReadLine());
        
        var revNumber = 0;
        var number = origNumber;
        while(number > 0){
            var rem = number % 10;
            revNumber = (revNumber*10) + rem;
            number = number/10;
            Console.WriteLine(revNumber);
        }
        
        if(origNumber == revNumber){
            Console.WriteLine("Yes the number is palindrome!");
        }
        else{
            Console.WriteLine("No the number is not palindrome!");
        }
        
    }
}
