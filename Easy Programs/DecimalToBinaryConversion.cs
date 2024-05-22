
internal class Program
{
    static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Decimal input = {num}");
        string ans = "";
        while(num > 0)
        {
            var rem = num % 2;
            num = num / 2;
            //Console.WriteLine($"num = {num}, rem = {rem}");
            ans = rem.ToString() + ans;
        }
        Console.WriteLine($"Binary Output = {ans}");
    }

}
