
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        //Mine
        //Console.WriteLine("Enter a string to reverse : ");
        //string str = Console.ReadLine();

        //int i = 0;
        //string reverse = "";
        //while(i <= str.Length - 1)
        //{
        //    int j = i;
        //    while (j < str.Length && str[j] != ' ')
        //    {
        //        j++;
        //    }
        //    int x = j;
        //    j--;
        //    while(j >= i)
        //    {
        //        reverse = reverse + str[j];
        //        j--;
        //    }

        //    if(! (x >= str.Length))
        //        reverse = reverse + ' ';
        //    i = x + 1;

        //}

        //Console.WriteLine(reverse);

        //Optimal
        Console.WriteLine("Enter a string to reverse : ");
        string OriginalString = Console.ReadLine();
        StringBuilder ReverseString = new StringBuilder();

        List<char> charList = new List<char>();

        for(int i = 0;i < OriginalString.Length;i++)
        {
            if (OriginalString[i] == ' ' || i == OriginalString.Length - 1)
            {
                if(i == OriginalString.Length -1)
                {
                    charList.Add(OriginalString[i]);
                }
                for(int j = charList.Count - 1; j>=0; j--)
                {
                    ReverseString.Append(charList[j]);
                }

                ReverseString.Append(' ');
                charList = new List<char>();
            }
            else
            {
                charList.Add(OriginalString[i]);
            }
        }

        Console.WriteLine(ReverseString.ToString());


    }

}
