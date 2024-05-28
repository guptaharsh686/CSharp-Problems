
using System.Diagnostics.Metrics;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the rows of triangle pattern : ");
        int n = int.Parse(Console.ReadLine());

        //APPROACH 1
        //for(int i=1; i <= n; i++)
        //{
        //    for(int j=1; j <= n; j++)
        //    {
        //        if(j <= n-i)
        //            Console.Write(" ");
        //        else
        //            Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //APPROACH 2
        int rows = n;
        for(int i = 1; i<= rows; i++)
        {
            //i=1; rows=5 ->  means 1 * and 5-1 ' '
            
            for(int j=rows-i; j>=1; j--)
            {
                Console.Write(' ');
            }

            for(int k=1; k<=i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

//Enter the rows of triangle pattern : 
//               10
//                        *
//                       **
//                      ***
//                     ****
//                    *****
//                   ******
//                  *******
//                 ********
//                *********
//               **********
