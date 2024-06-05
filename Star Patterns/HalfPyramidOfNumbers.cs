
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
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

//             Enter the rows of triangle pattern :
//             8
//             1
//             12
//             123
//             1234
//             12345
//             123456
//             1234567
//             12345678
