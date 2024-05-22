using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Start Number : ");
            int StartNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the End Number : ");
            int EndNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Armstrong Numbers between {StartNumber} and {EndNumber} are : ");
            for (int i = StartNumber; i <= EndNumber; i++)
            {
                if (IsArmstrongNumber(i))
                    Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
        static bool IsArmstrongNumber(int number)
        {
            int sum = 0;
            int temporaryNumber = number;
            int temp = 0;
            int length = number.ToString().Length;
            while (number != 0)
            {
                temp = number % 10;
                number = number / 10;
                sum += (int)Math.Pow(temp, length);
            }
            
            if (sum == temporaryNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
