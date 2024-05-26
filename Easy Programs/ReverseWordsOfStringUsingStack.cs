
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        Stack<char> stk = new Stack<char>();

        Console.WriteLine("Enter a string to reverse : ");
        var str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
            {
                stk.Push(str[i]);
            }
            else
            {
                while(stk.Count > 0)
                {
                    Console.Write(stk.Pop());
                }
                Console.Write(" ");
            }
        }

        while(stk.Count > 0)
        {
            Console.Write(stk.Pop());
        }

    }

}
