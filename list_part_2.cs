using System.Text.Json;

namespace lecture_C_;

/*
//Part 2
//1
public class ListPart2
{
    private static (List<int>, string) GetRequest()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (JsonSerializer.Deserialize<List<int>>(input[0]), input[1].Trim())!;
    }

    private static void Main()
    {
        var (elements, order) = GetRequest();
        var elementsString = elements.Select(t => t.ToString()).ToList();

        for (var i = 0; i < elementsString.Count; i++)
        {
            elementsString[i] = order switch
            {
                "ASC" => new string(elementsString[i].OrderBy(x => x).ToArray()),
                "DESC" => new string(elementsString[i].OrderByDescending(x => x).ToArray()),
                _ => elementsString[i]
            };
        }
        
        var elementsInt = elementsString.Select(t => Convert.ToInt32(t)).ToList();
        Console.Write(JsonSerializer.Serialize(elementsInt));
    }
}
*/

/*
//2, 3
public abstract class ListPart2
{
    private static (List<int>, int) GetRequest()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (JsonSerializer.Deserialize<List<int>>(input[0]), int.Parse(input[1].Trim()))!;
    }

    private static void Main()
    {
        var (elements, shift) = GetRequest();
        
        // var deleted = elements.Take(Math.Abs(elements.Count - shift)).ToList();
        // elements.RemoveRange(0, Math.Abs(elements.Count - shift));
        // elements.AddRange(deleted);
        //
        // Console.WriteLine(JsonSerializer.Serialize(elements));

        while (shift > 0)
        {
            var deleted = elements.Take(1).ToList(); // elements.Skip(elements.Count - 1).ToList(), it's all a right side;
            elements.RemoveRange(0, 1); // elements.RemoveRange(elements.Count - 1, 1);
            elements.Insert(elements.Count, deleted[0]); // elements.Insert(0, deleted[0]);

            shift--;
        }
        
        Console.WriteLine(JsonSerializer.Serialize(elements));
    }
}
*/

/*
//4, 5
public abstract class ListPart2
{
    private static (List<List<int>>, int) GetRequest()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (JsonSerializer.Deserialize<List<List<int>>>(input[0]), int.Parse(input[1].Trim()))!;
    }

    private static void Main()
    {
        var (matrix, shift) = GetRequest();
        while (shift > 0)
        {
            foreach (var element in matrix)
            {
                var deleted = element.Skip(element.Count - 1).ToList(); // element.Take(1).ToList(); it's all a left side
                element.RemoveRange(element.Count - 1, 1); //element.RemoveRange(0, 1);
                element.Insert(0, deleted[0]); // element.Insert(matrix.Count, deleted[0]);
            }

            shift--;
        }
        
        Console.WriteLine(JsonSerializer.Serialize(matrix));
    }
}
*/

/*
//6
public abstract class ListPart2
{
    private static (int, int) GetNumbers()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (int.Parse(input[0]), int.Parse(input[1]));
    }

    private static void Main()
    {
        var (width, height) = GetNumbers();
        var result = new List<List<int>>();

        for (var i = 0; i < height; i++)
        {
            var listForOne = new List<int>();
            for (var j = 0; j < width; j++)
                listForOne.Add(1);
            
            result.Add(listForOne);
        }
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

/*
//7
public abstract class ListPart2
{
    private static int GetNumber()
    {
        var input = Console.ReadLine();
        return int.Parse(input!);
    }

    private static void Main()
    {
        var number = GetNumber();
        var result = new List<List<int>>();

        for (var i = 0; i < number; i++)
        {
            var row = new List<int>();
            for (var j = 0; j < number; j++)
                row.Add(Math.Abs(i - j));
            
            result.Add(row);
        }
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

/*
//8
public abstract class ListPart2
{
    private static List<int> GetNumbers()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var numbers = GetNumbers();
        for (var i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < numbers[^1])
                numbers[i] = numbers[0];
        }
        
        Console.WriteLine(JsonSerializer.Serialize(numbers));
    }
}
*/

/*
//9
public abstract class ListPart2
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();
        var evens = elements.Where(e => e % 2 == 0).ToList();
        var odds = elements.Where(e => e % 2 != 0).ToList();
            
        if (evens.Count != 0 && odds.Count != 0)
        {
            var maxEven = evens.Max();
            var minOdd = odds.Min();
                
            var indexEven = elements.FindIndex(e => e == maxEven);
            var indexOdd = elements.FindIndex(e => e == minOdd);
                
            elements[indexEven] = minOdd;
            elements[indexOdd] = maxEven;
        }

        else
        {
            for (var i = 0; i < elements.Count; i++)
                elements[i] = 0;
        }
        
        Console.WriteLine(JsonSerializer.Serialize(elements));
    }
}
*/

/*
//10
public abstract class ListPart2
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();
        var listForMul = new List<int>();
        var left = 0;
        var right = 1;
        var maxMul = 0;

        while (left < elements.Count - 1)
        {
            var current = elements[left];
            var currentNext = elements[right];
            
            if (!listForMul.Contains(current))
                listForMul.Add(current);
            
            listForMul.Add(currentNext);
            
            var result = listForMul.Aggregate(1, (a, b) => a * b);
            if (result > maxMul)
                maxMul = result;

            right++;

            if (right < elements.Count) continue;
            left++;
            right = left + 1;
            listForMul.Clear();
        }
        
        Console.WriteLine(maxMul);
    }
}
*/

/*
//13
public abstract class ListPart2
{
    private static List<int> GetOrders()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var orders = GetOrders();
        var result = new List<int>();
        
        for (var i = 0; i < orders.Count - 1; i++)
        {
            if (orders[i] > orders[i + 1])
                result.Add(orders[i]);
            
            if (orders[i] - orders[i + 1] == -2)
                result.Add(orders[i + 1]);
        }
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

/*
//14
public abstract class ListPart2
{
    private static List<string> GetEmojis()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<string>>(input!);
    }

    private static void Main()
    {
        var emojis = GetEmojis();
        var variants = new List<string>
        {
            ":D", ":)", ":-)", ":-D", ":~)", ":~D",
            ";D", ";)", ";-)", ";-D", ";~)", ";~D"
        };
        var count = emojis.Count(emoji => variants.Contains(emoji));

        Console.WriteLine(count);
    }
}
*/

/*
//12
public abstract class ListPart2
{
    private static List<int> GetTemperatures()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var temperatures = GetTemperatures();
        var left = 0;
        var right = 1;
        var result = new List<int>();
        
        while (left < temperatures.Count - 1)
        {
            var element = temperatures[left];
            var elementNext = temperatures[right];

            if (element < elementNext)
            {
                result.Add(Math.Abs(left - right));
                left++;
                right = left + 1;
            }

            else
            {
                if (right < temperatures.Count - 1)
                    right++;
                else
                {
                    result.Add(0);
                    left++;
                    right = left + 1;
                }
            }
        }
        
        result.Add(0);
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

//11
public abstract class ListPart2
{
    private static (string, List<string>) GetInfo()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (input[0].Trim(), JsonSerializer.Deserialize<List<string>>(input[1])!);
    }

    private static void Main()
    {
        var (word, variants) = GetInfo();
        var result = new List<string>();

        Backtrack(word, variants, "", result);
        Console.Write(JsonSerializer.Serialize(result));
    }

    private static void Backtrack(string word, List<string> variants, string current, List<string> result)
    {
        if (string.IsNullOrEmpty(word))
        {
            result.Add(current.Trim());
            return;
        }

        for (var i = 1; i <= word.Length; i++)
        {
            var prefix = word[..i];
            if (variants.Contains(prefix))
                Backtrack(word[i..], variants, current + prefix + " ", result);
        }
    }
}