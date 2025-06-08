using System.Text.Json;

namespace lecture_C_;

/*
//1
public abstract class ListTask5
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();

        var uniqueCount = elements.GroupBy(x => x).Count(x => x.Count() == 1);
        var duplicatesCount = elements.GroupBy(x => x).Count(x => x.Count() > 1);
        var zeroCount = elements.Count(e => e.Equals(0));
        var evenCount = elements.Count(e => e % 2 == 0 && e != 0);
        var oddCount = elements.Count(e => e % 2 != 0);
        
        Console.Write($"{uniqueCount}, {duplicatesCount}, {zeroCount}, {evenCount}, {oddCount}");
    }
}
*/

/*
//2
public abstract class ListTask5
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();
        var elementsDistinct = elements.Distinct().ToList();
        
        if (elementsDistinct.Count <= 2)
            Console.WriteLine(elementsDistinct.Max());

        else
        {
            elementsDistinct.OrderDescending();
            Console.WriteLine(elementsDistinct[2]);
        }
    }
}
*/

/*
//3
public abstract class ListTask5
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();
        var indexOfOne = elements.FindIndex(x => x == 1);
        int sumLeft = 0, sumRight = 0;

        for (var i = 0; i < indexOfOne; i++)
        {
            if (elements[i] == 0)
                sumLeft++;
        }
        
        for (var i = elements.Count - 1; i > indexOfOne; i--)
        {
            if (elements[i] == 0)
                sumRight++;
        }
        
        Console.WriteLine($"Количество нулей перед единицей: {sumLeft}, Количество нулей после единицы: {sumRight}");
    }
}
*/

/*
//5
public abstract class ListTask5
{
    private static int getNumber()
    {
        var input = Console.ReadLine();
        return int.Parse(input!);
    }

    private static void Main()
    {
        var number = getNumber();
        var result = new List<int>();

        for (var i = number; i >= 1; i--)
            result.Add(i * 3);
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

/*
//6
public abstract class ListTask5
{
    private static int GetNumber()
    {
        var input = Console.ReadLine();
        return int.Parse(input!);
    }

    private static void Main()
    {
        var number = GetNumber();
        var result = new List<int>();
        
        result.AddRange(Enumerable.Range(1, number));
        result.AddRange(Enumerable.Range(1, number).Reverse());
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }   
}
*/

/*
//7
public abstract class ListTask5
{
    private static int GetNumber()
    {
        var input = Console.ReadLine();
        return int.Parse(input!);
    }

    private static void Main()
    {
        var number = GetNumber();
        var result = new List<int>();
        
        for (var i = 0; i < number; i++)
        {
            if (i % 2 == 0)
                result.Add(1);
            
            else
                result.Add(i % 3);
        }
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

/*
//8
public abstract class ListTask5
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();
        var dictionary = new Dictionary<int, int>();

        foreach (var element in elements)
        {
            if (!dictionary.TryGetValue(element, out var value))
                dictionary.Add(element, 1);
            
            else 
                dictionary[element] = ++value;
        }
        
        Console.WriteLine(dictionary.MaxBy(x => x.Value).Key);
    }
}
*/

/*
//9
public abstract class ListTask5
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();
        var result = new List<int>();
        var count = 1;
        
        for (var i = 0; i < elements.Count - 1; i++)
        {
            if (elements[i] < elements[i + 1])
                count++;
            
            else
            {
                result.Add(count);
                count = 1;
            }
            
            if (i == elements.Count - 2)
                result.Add(count);
        }
        
        Console.WriteLine(result.Max());
    }
}
*/

/*
//11
public abstract class ListTask5
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();
        var count = 0;
        
        for (var i = 1; i < elements.Count; i++)
            if (elements[i] == elements[i - 1])
                count++;
        
        Console.WriteLine(count);
    }
}
*/


//12
public abstract class ListTask5
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();
        var payment = 0;
        var selling = 0;
        
        for (var i = 0; i < elements.Count; i++)
        {
            if (i % 2 == 0)
                payment += elements[i];
            
            else 
                selling += elements[i];
        }

        Console.WriteLine(selling - payment);
    }
}


