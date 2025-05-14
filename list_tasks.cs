using System.Collections.Immutable;
using System.Text;
using System.Text.Json;

namespace lecture_C_;

/*
//1
public class list_tasks
{
    private static List<int> ReadInput()
    {
        var input = Console.ReadLine();
        return !string.IsNullOrEmpty(input) ? JsonSerializer.Deserialize<List<int>>(input)! : [];
    }

    public static void Main()
    {
        var listNumbers = ReadInput();
        var isAllEven = listNumbers.All(x => x % 2 != 0);
        Console.WriteLine(isAllEven.ToString().ToLower());
    }
}
*/

/*
//2
public class list_tasks
{
    private static (int number, List<int> data) ReadInput()
    {
        var input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return (0, []);
        
        var values = input.Split(" | ");
        var dataInt = JsonSerializer.Deserialize<List<int>>(values[1]);
        
        return (int.Parse(values[0]), dataInt)!; //values[0] - это число a в a | [b, c, ..., n]

    }

    public static void Main()
    {
        var (number, data) = ReadInput();
        Console.WriteLine(data.All(n => n < number).ToString().ToLower());
    }
}
*/

/*
//3,задачи повторяются, поэтому в списке идет 5-м
public class list_tasks
{
    private static List<string> ReadInput()
    {
        var input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
            return [..JsonSerializer.Deserialize<string[]>(input)!];

        return null!;
    }

    public static void Main()
    {   
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var words = ReadInput();
        words.Sort(); //.Reverse()
        var hashSet = new HashSet<string>(words);

        var withCommas = string.Join(", ", hashSet);
        Console.WriteLine(withCommas);
    }
}
*/

//10
public class list_tasks
{
    private static List<string> ReadInput()
    {
        var input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
            return [..JsonSerializer.Deserialize<string[]>(input)!];

        return null!;
    }

    public static void Main()
    {
        var words = ReadInput();
        var dictionary = new Dictionary<string, int>();
        
        foreach (var data in words)
        {
            if (dictionary.TryGetValue(data, out var value))
                dictionary[data] = ++value;
            else
                dictionary[data] = 1;
        }

        var result = dictionary.Select(pairs => $"{pairs.Key}: {pairs.Value}").ToList();
        Console.Write(string.Join(", ", result));
    }
}