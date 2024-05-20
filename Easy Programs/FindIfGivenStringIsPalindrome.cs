using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        var origString = Console.ReadLine();
        
        string reverse = "";
        
        //Approach 1
        // for(int i= origString.Length-1; i>=0;i--)
        // {
        //     reverse = reverse + origString[i];
        // }
        
        //Approach 2
        // for(int i= 0; i < origString.Length; i++)
        // {
        //     reverse = origString[i] + reverse;
        // }
        
        char[] arr = origString.ToCharArray();
        Array.Reverse(arr);
        reverse = new string(arr);
        
        
        if(origString.Equals(reverse,StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Yes palindrome!");
        }
        else{
            Console.WriteLine("No palindrome!");
        }
         
    }
}
