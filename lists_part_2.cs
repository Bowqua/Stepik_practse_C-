using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace lecture_C_;

// Part 1

/*
//1
public abstract class ListsPart2
{
    private static (List<string>, string) GetLettersAndOrder()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (JsonSerializer.Deserialize<List<string>>(input[0]), input[1].Trim())!;
    }

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var (letters, order) = GetLettersAndOrder();
        for (var i = 0; i < letters.Count; i++)
        {
            letters[i] = order switch
            {
                "ASC" => new string(letters[i].OrderBy(x => x).ToArray()),
                "DESC" => new string(letters[i].OrderByDescending(x => x).ToArray()),
                _ => letters[i]
            };
        }

        Console.WriteLine(JsonSerializer.Serialize(letters, new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All), WriteIndented = false
        }));
    }
}
*/

/*
//2
public abstract class ListsPart2
{
    private static List<string> GetWords()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<string>>(input!);
    }

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var words = GetWords();
        var result = words.GroupBy(w => w).Select(g => g.ToList()).ToList();
        
        Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All), WriteIndented = false
        }));
    }
}
*/

/*
//3
public abstract class ListsPart2
{
    private static int GetNumber()
    {
        var input = Console.ReadLine();
        return int.Parse(input!);
    }

    private static void Main()
    {
        var height = GetNumber();
        var countOne = 1;
        var width = 2 * height - 1; 
        var result = new List<List<int>>();

        for (var i = 1; i <= height; i++)
        {
            var row = new List<int>();
            
            row.AddRange(Enumerable.Repeat(0, (width - countOne) / 2));
            row.AddRange(Enumerable.Repeat(1, countOne));
            
            var zerosLeft = width - row.Count;
            row.AddRange(Enumerable.Repeat(0, zerosLeft));
            result.Add(row);
            
            countOne += 2;
        }
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

/*
//4
public abstract class ListsPart2
{
    private static int GetNumber()
    {
        var input = Console.ReadLine();
        return int.Parse(input!);
    }

    private static void Main()
    {
        var size = GetNumber();
        var result = new List<List<int>>();

        for (var i = 1; i <= size; i++)
        {
            var row = new List<int>();
            
            row.AddRange(Enumerable.Repeat(1, size));
            result.Add(row);
        }
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

/*
//5, 6, 7
public abstract class ListsPart2
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var numbers = GetElements();
        var rightBoundary = numbers[^1];
        var sum = 0;
        
        for (var i = numbers[0]; i <= rightBoundary; i++)
        {
            if (!numbers.Contains(i) && i % 2 != 0) // в //5 без && i % 2 == 0
                sum += i;
        }
            
        Console.WriteLine(sum);
    }
}
*/

/*
//8
public abstract class ListsPart2
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();
        var count = elements.Count;
        var result = new List<(int, int)>();

        switch (count % 2)
        {
            case 0 when count > 0:
            {
                for (var i = 1; i <= count / 2; i++)
                    result.Add((elements[i - 1], elements[^i]));
                break;
            }
            case 1:
            {
                for (var i = 1; i <= (count + 1) / 2; i++)
                    result.Add((elements[i - 1], elements[^i]));
                break;
            }
            default:
                Console.WriteLine("()");
                break;
        }
        
        Console.WriteLine(string.Join(",", result.Select(x => $"({x.Item1},{x.Item2})")));
    }
}
*/

//9
public abstract class ListsPart2
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();
        var result = new List<int>(elements);
        
        result.Sort();

        Console.Write(elements.SequenceEqual(result) ? "true" : "false");
    }
}