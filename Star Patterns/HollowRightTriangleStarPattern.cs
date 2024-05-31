
using System.Diagnostics.Metrics;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the rows of triangle pattern : ");
        int n = int.Parse(Console.ReadLine());
        int rows = n;
        //APPROACH 1
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                if (j == i || j == 0 || i == rows - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

//            Enter the rows of triangle pattern :
//            10
//            *
//            **
//            * *
//            *  *
//            *   *
//            *    *
//            *     *
//            *      *
//            *       *
//            **********
