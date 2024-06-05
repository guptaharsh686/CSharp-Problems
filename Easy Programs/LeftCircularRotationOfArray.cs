
using System.Diagnostics.Metrics;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("\nBefore left circular rotation");
        foreach (var item in arr)
        {
            Console.Write(item);
        }

        //APPROACH1
        //int first = arr[0];
        //for(int i=1;i<arr.Length; i++)
        //{
        //    arr[i-1] = arr[i];
        //}
        //arr[arr.Length-1] = first;

        //APPROACH2
        for (var i = 0; i < arr.Length-1; i++)
        {
            int temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
        }


        Console.WriteLine("\nAfter left circular rotation");

        foreach (var item in arr)
        {
            Console.Write(item);
        }
    }
}


//Before left circular rotation
//123456789
//After left circular rotation
//234567891
