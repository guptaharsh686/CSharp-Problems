
internal class Program
{
    static void Main(string[] args)
    {

        //ITTERATIVE
        var num = int.Parse(Console.ReadLine());

        var fact = 1;
        for (int i = 2; i <= num; i++)
        {
            fact *= i;
        }

        Console.WriteLine($"Factorial of {num}  is: {fact}");


        //RECURSIVE
        //Console.WriteLine($"Factorial = {fact(num)}");
    }

    private static int fact(int num)
    {
        if(num == 0)
        {
            return 1;
        }

        return num * fact(num - 1);
    }
}
