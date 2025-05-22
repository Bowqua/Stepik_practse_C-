using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

/*
//1
public abstract class ListsTask3
{
    private static List<int> ReadInput()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!.Trim())!;
    }
    
    private static void Main()
    {
        var elementsList = ReadInput();
        for (var i = 0; i < elementsList.Count; i++)
        {
            if (elementsList[i] == elementsList[i + 1] && elementsList[i] == 0)
            {
                Console.Write("true");
                break;
            }
            
            Console.Write("false");
            break;
        }
    }
}
*/

/*
//2
public abstract class ListsTask3
{
    private static List<int> ReadInput()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!.Trim())!;
    }

    private static void Main()
    {
        var elementsList = ReadInput();
        for (var i = 2; i < elementsList.Count; i++)
        {
            if (elementsList[i] == 0)
                elementsList[i] = elementsList[i - 1] + elementsList[i - 2];
        }

        Console.Write('[' + string.Join(',', elementsList) + ']');
    }
}
*/

/*
//3
public abstract class ListsTask3
{
    private static List<int> ReadInput()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!.Trim())!;
    }

    private static void Main()
    {
        var elementsList = ReadInput();
        var mirrow = elementsList.ToList();

        elementsList.Reverse();
        for (var i = 1; i < elementsList.Count; i++)
            mirrow.Add(elementsList[i]);

        Console.Write(string.Join(", ", mirrow));
    }
}
*/

/*
//4
public abstract class ListsTask3
{
    private static List<int> ReadInput()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elementsList = ReadInput();
        var zeroToDelete = 0;
        elementsList = elementsList.Where(n => n != zeroToDelete).ToList();
        
        Console.WriteLine(JsonSerializer.Serialize(elementsList));
    }
}
*/

/*
//5
public abstract class ListsTask3
{
    private static List<string> ReadInput()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<string>>(input!);
    }

    private static void Main()
    {
        var lettersList = ReadInput();
        var result = new StringBuilder();
        var count = 1;
        var letter = lettersList[0];
        
        for (var i = 1; i < lettersList.Count; i++)
        {
            if (letter == lettersList[i])
                count++;

            else
            {
                AddToList(result, letter, count);
                
                letter = lettersList[i];
                count = 1;
            }

            if (i == lettersList.Count - 1)
                AddToList(result, letter, count);
        }
        
        Console.WriteLine(result.ToString());
    }

    private static void AddToList(StringBuilder result, string letter, int count)
    {
        result.Append(letter);
        result.Append(count);
    }
}
*/

/*
//6
public abstract class ListsTask3
{
    private static string ReadInput() =>
        Console.ReadLine()!;

    private static void Main()
    {
        var text = ReadInput();
        var result = new StringBuilder();
        var letter = text[0];

        for (var i = 1; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]) && text[i] == letter)
                return;

            else if (char.IsLetter(text[i]) && text[i] != letter)
                letter = text[i];

            if (char.IsDigit(text[i]))
            {
                var number = int.Parse(text[i].ToString());
                while (number > 0)
                {
                    result.Append(letter);
                    number -= 1;
                }
            }
        }
        
        Console.Write(string.Join(", ", result.ToString().ToCharArray()));
    }
}
*/

/*
//7
public abstract class ListsTask3
{
    private static List<List<int>> ReadInput()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<List<int>>>(input!);
    }

    private static void Main()
    {
        var matrix = ReadInput();
        var firstDiagonal = 0;
        var secondDiagonal = 0;
        
        if (matrix.Count == matrix.Select(x => x.Count).First())
        {
            firstDiagonal += matrix.Select((t, i) => t[i]).Sum();
            secondDiagonal += matrix.Select((t, j) => t[matrix.Count - 1 - j]).Sum();

            Console.WriteLine(firstDiagonal + secondDiagonal);
        }
        
        else
            Console.Write("-1");
    }
}
*/

/*
//8
public abstract class ListsTask3
{
    private static List<List<int>> ReadInput()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<List<int>>>(input!);
    }

    private static void Main()
    {
        var matrix = ReadInput();
        var firstRow = matrix[0].Sum();
        var thirdRow = matrix[^1].Sum();
        var firstColumn = 0;
        var thirdColumn = 0;

        foreach (var element in matrix)
        {
            firstColumn += element[0];
            thirdColumn += element[^1];
        }
        
        Console.WriteLine(firstRow + firstColumn + thirdRow + thirdColumn);
    }
}
*/

/*
//9
public abstract class ListsTask3
{
    private static (List<int>, int, int) ReadInput()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (JsonSerializer.Deserialize<List<int>>(input[0]), 
            int.Parse(input[1].Trim()), int.Parse(input[2].Trim()))!;
    }

    private static void Main()
    {
        var (elementsList, start, end) = ReadInput();
        var indexStart = elementsList.IndexOf(start);
        var indexEnd = elementsList.LastIndexOf(end);
        var sum = 0;

        if (elementsList.Contains(start) && elementsList.Contains(end))
        {
            for (var i = indexStart; i <= indexEnd; i++)
                sum += elementsList[i];
            
            Console.WriteLine(sum);
        }
        
        else
            Console.WriteLine(0);
    }
}
*/

//10
public abstract class ListsTask3
{
    private static List<int> ReadInput()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elementList = ReadInput();
        for (var i = 0; i < elementList.Count; i++)
        {
            if (elementList[i] < 0)
                elementList[i] = 0;
        }
        
        Console.WriteLine(JsonSerializer.Serialize(elementList));
    }
}