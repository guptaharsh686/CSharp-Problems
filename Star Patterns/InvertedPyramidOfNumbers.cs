
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
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

//            Enter the rows of triangle pattern :
//            8
//            12345678
//            1234567
//            123456
//            12345
//            1234
//            123
//            12
//            1
