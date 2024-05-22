
internal class Program
{
    static void Main(string[] args)
    {
        var binStr = Console.ReadLine();

        Console.WriteLine($"Binary input = {binStr}");

        int sum = 0;
        for( int i = 0; i < binStr.Length; i++ )
        {
            sum += int.Parse(binStr[binStr.Length - (1 + i)].ToString()) * (int)Math.Pow(2,i);
        }

        Console.WriteLine($"Decimal Output = {sum}");
    }

}
