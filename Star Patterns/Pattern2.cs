
using System.Diagnostics.Metrics;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the rows of triangle pattern : ");
        int n = int.Parse(Console.ReadLine());
        
        for(int i=0; i < n; i++)
        {
            for(int j=0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

//            Enter the rows of triangle pattern :
//            10
//            *
//            **
//            ***
//            ****
//            *****
//            ******
//            *******
//            ********
//            *********
//            **********
