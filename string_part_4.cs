using System.Text;
using System.Text.Json;

namespace lecture_C_;

/*
//String. Part 4
//1
public abstract class StringPart4
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var result = new StringBuilder();

        for (var i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                result.Append(text[i]);
                text = text.Remove(i, 1);
                i = 0;
            }
        }
        
        result.Append(text);
        Console.WriteLine(result);
    }
}
*/

/*
//2
public abstract class StringPart4
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var upperCase = new string(text.Where(char.IsUpper).OrderBy(x => x).ToArray());
        var lowerCase = new string(text.Where(char.IsLower).ToArray());
        
        Console.WriteLine(upperCase + lowerCase);
    }
}
*/

/*
//3
public abstract class StringPart4
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        Console.WriteLine(text.Any(char.IsUpper)
            ? string.Join(" ", text.Select(char.ToUpper))
            : string.Join(" ", text.Select(char.ToLower)));
    }
}
*/

/*
//4
public abstract class StringPart4
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText().Split(" ");
        var result = new StringBuilder();

        foreach (var word in text)
        {
            for (var j = 0; j < word.Length; j++)
                result.Append(j == 0 ? char.ToUpper(word[j]) : char.ToLower(word[j]));
            
            result.Append(' ');
        }
        
        Console.WriteLine(result);
    }
}
*/

/*
//5
public abstract class StringPart4
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var text = GetText();
        var lastSymbol = text[^1];
        var result = new List<int>();
        
        for (var i = 0; i < text.Length - 1; i++)
        {
            if (text[i] == lastSymbol)
                result.Add(i);
        }
        
        if (result.Count == 0)
            Console.WriteLine("Соответствующие индексы: нет");
        
        else
            Console.WriteLine("Соответствующие индексы: " + string.Join(", ", result));
    }
}
*/

/*
//6
public abstract class StringPart4
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        
        var minusCount = text.Count(c => c == '-');
        var plusCount = text.Count(c => c == '+');
        var result = minusCount + plusCount;
        var count = text.Where((letter, i) => 
            (letter == '0' && text[i + 1] == '-') || (letter == '0' && text[i + 1] == '+')).Count();

        Console.WriteLine($"Общее количество символов: {result}, Количество символов, после которых следует цифра ноль: {count}");
    }
}
*/

/*
//7
public abstract class StringPart4
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var text = GetText();
        if (!text.Contains('[') && !text.Contains(']'))
            Console.WriteLine("В строке нет символов [ и ]");
        
        else if (text.Contains('[') && !text.Contains(']'))
            Console.WriteLine("В строке нет символа ]");
        
        else if (text.Contains(']') && !text.Contains('['))
            Console.WriteLine("В строке нет символа [");

        else
        {
            var indexOfLeftSide = text.IndexOf('[');
            var indexOfRightSide = text.IndexOf(']');
            
            Console.WriteLine(indexOfLeftSide < indexOfRightSide 
                ? "Символ [ встречается раньше символа ]" 
                : "Символ ] встречается раньше символа [");
        }
    }
}
*/

/*
//8
public abstract class StringPart4
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        for (var i = 0; i < text.Length; i++)
        {
            if (!text.Contains("abcx")) continue;
            text = text.Replace("abcx", string.Empty);
            i = 0;
        }
        
        Console.WriteLine(text);
    }
}
*/

/*
//9
public abstract class StringPart4
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        var text = GetText();
        var words = text.Split((char[])null!, StringSplitOptions.RemoveEmptyEntries);
        
        Console.WriteLine(string.Join(" ", words));
    }
}
*/

/*
//10
public abstract class StringPart4
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var textWithNumbers = GetText();
        var max = 0;
        var count = 0;
        
        foreach (var letter in textWithNumbers)
        {
            if (char.IsDigit(letter))
                count++;

            if (!char.IsDigit(letter))
            {
                if (count > max)
                    max = count;
                count = 0;
            }
        }
        
        Console.WriteLine(max);
    }
}
*/

/*
//11
public abstract class StringPart4
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var result = text.Where(char.IsDigit).Sum(letter => letter - '0');

        Console.WriteLine(result);
    }
}
*/

/*
//12
public abstract class StringPart4
{
    private static List<string> GetWords()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<string>>(input!);
    }

    private static void Main()
    {
        var words = GetWords();
        var resultWithoutNumbers = words.Where(word => !word.Contains('_')).ToList();
        var resultWithNumbers = words.Where(word => word.Contains('_')).ToList();
        var result = new List<string>(resultWithoutNumbers);

        var sortedWord = resultWithNumbers.OrderBy(x => x.Count(char.IsDigit)).ToList();
        result.AddRange(sortedWord);
        
        Console.WriteLine(string.Join(", ", result));
    }
}
*/


//13
public abstract class StringPart4
{
    private static (string, string) GetInfo()
    {
        var input = Console.ReadLine()!.Trim().Split(" | ");
        return (input[0], input[1]);
    }

    private static void Main()
    {
        var (text, word) = GetInfo();
        Console.WriteLine(text.Contains(word) ? "true" : word.Contains(text) ? "true" : "false");
    }
}
