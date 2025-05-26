using System.Text.Json;

namespace lecture_C_;

/*
//1
public abstract class ListTask4
{
    private static List<List<int>> ReadInput()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<List<int>>>(input!);
    }

    private static void Main()
    {
        var matrix = ReadInput();
        var result = new List<int>();        
        var i = matrix.Count; // кол-во строк
        
        for (var j = 0; j < matrix[i - 1].Count; j++)
        {
            var sum = 0;
            for (var k = 0; k < i; k++)
                sum += matrix[k][j];
            
            result.Add(sum);
        }

        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

/*
//2
public abstract class ListTask4
{
    private static List<int> GetFromConsole()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var lettersList = GetFromConsole();
        var leftSide = new List<int>();
        var count = lettersList.Count;
        
        // Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Console.InputEncoding = System.Text.Encoding.UTF8;

        for (var i = 0; i < count / 2; i++)
            leftSide.Add(lettersList[i]);
        for (var i = 0; i < count / 2; i++)
            lettersList.RemoveAt(0);

        var rightSide = lettersList.ToList();
        if (leftSide.Sum() > rightSide.Sum())
            Console.WriteLine("Левая сторона тяжелее");
        
        else if (leftSide.Sum() < rightSide.Sum())
            Console.WriteLine("Правая сторона тяжелее");
        
        else 
            Console.WriteLine("Обе стороны сбалансированы");
    }
}
*/

/*
//3, 4
public abstract class ListTask4
{
    private static List<string> GetFiles()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<string>>(input!);
    }

    private static void Main()
    {
        var files = GetFiles();
        var result = files.Where(t => t.Contains(".png")).ToList(); //"image"

        Console.Write(JsonSerializer.Serialize(result));
    }
}
*/

/*
//5
public abstract class ListTask4
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();
        var result = elements.Where(t => t < 0).ToList();

        if (result.Count == 0)
            Console.WriteLine(0);
        
        else
            Console.Write(result.First());
    }
}
*/

/*
//6
public abstract class ListTask4
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    { 
        var elements = GetElements();
        for (var i = 0; i < elements.Count; i++)
            elements[i] *= -1;
        
        Console.WriteLine(JsonSerializer.Serialize(elements));
    }
}
*/

/*
//7
public abstract class ListTask4
{
    private static List<int> GetElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elements = GetElements();
        var max = elements.Max();
        var result = elements.Select(x => x * max).ToList();
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

/*
//8
public abstract class ListTask4
{
    private static List<int> getElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elementsList = getElements();
        var ariphmSum = elementsList.Sum() / elementsList.Count;
        var result = elementsList.Where(t => t > ariphmSum).ToList();

        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

/*
//9
public abstract class ListTask4
{
    private static List<int> getElements()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()

    {
        var elementsList = getElements();
        var result = new List<int>();

        for (var i = 1; i < elementsList.Count; i++)
        {
            if (elementsList[i] > elementsList[i - 1])
                result.Add(elementsList[i]);
        }
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

//10
public abstract class ListTask4
{
    private static List<List<int>> GetMatrix()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<List<int>>>(input!.Trim());
    }

    private static void Main()
    {
        var matrix = GetMatrix();
        var result = matrix.Select(row => row.Sum()).ToList();

        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
