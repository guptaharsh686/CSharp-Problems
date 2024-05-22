
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the string");
        string str = Console.ReadLine().Replace(" ", string.Empty);

        //APPROACH 1

        //Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();

        //foreach (var item in str)
        //{
        //    if (keyValuePairs.ContainsKey(item))
        //    {
        //        keyValuePairs[item] += 1;
        //    }
        //    else
        //    {
        //        keyValuePairs.Add(item, 1);
        //    }
        //}


        //foreach (var item in str.Distinct())
        //{
        //    Console.WriteLine($"{item} : {keyValuePairs[item]}");
        //}


        //APPROACH 2

        var coll = str.GroupBy(str => str).Select(gr => new { key = gr.Key, count = gr.Count() });

        foreach (var item in coll)
        {
            Console.WriteLine($"{item.key} : {item.count}");
        }

    }

}
