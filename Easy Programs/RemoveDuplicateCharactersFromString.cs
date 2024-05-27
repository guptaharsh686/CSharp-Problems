using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        var str1 = Console.ReadLine();
        var str2 = string.Empty;

        for (int i = 0; i < str1.Length; i++)
        {
            if (!str2.Contains(str1[i]))
            {
                str2 = str2 + str1[i];
            }
        }

        Console.WriteLine("Removed duplicate characters : ");
        Console.WriteLine(str2);


        //OR
        //var uniqueCharArray = str1.ToCharArray().Distinct().ToArray();
        //var resultString = new string(uniqueCharArray);
        //Console.WriteLine(resultString);
    }

}
