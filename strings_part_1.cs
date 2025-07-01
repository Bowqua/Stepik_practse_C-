using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace lecture_C_;

//Strings. Part 1

/*
//1, 2
public abstract class StringsPart1
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var count = GetText().Select(x => x).Count(char.IsLower); //вместо IsLower IsUpper для 1
        Console.WriteLine(count);
    }
}
*/

/*
//3
public abstract class StringsPart1
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var count = GetText().Select(x => x).Count(char.IsWhiteSpace); 
        Console.WriteLine(count);
    }
}
*/

/*
//4
public abstract class StringPart1
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var result = "";
        
        foreach (var letter in text)
        {
            if (char.IsUpper(letter))
                result += char.ToLower(letter);

            else 
                result += char.ToUpper(letter);
        }
        
        Console.WriteLine(result);
    }
}
*/

/*
//5
public abstract class StringPart1
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var result = new StringBuilder();

        foreach (var word in text.Split(' '))
            result.Append($"{char.ToUpper(word[0]) + word[1..]} ");
        
        Console.WriteLine(result);
    }
}
*/

/*
//6
public abstract class StringPart1
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var result = text.Split(" ").Length;
        
        Console.WriteLine(result);
    }
}
*/

/*
//7
public abstract class StringPart1
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var textNumbers = GetText().Split(',');
        var sum = textNumbers.Sum(int.Parse);

        Console.WriteLine(sum);
    }
}
*/

/*
//8
public abstract class StringPart1
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText().Split(',');
        var sum = text.Sum(letters => int.Parse(letters[1..]));

        Console.WriteLine(sum);
    }
}
*/

/*
//9
public abstract class StringPart1
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        Console.WriteLine(text[^1].ToString() == "/" ? "true" : "false");
    }
}
*/

/*
//10
public abstract class StringPart1
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        Console.WriteLine(text.Contains("https://") ? "true" : "false");
    }
}
*/

/*
//11
public abstract class StringPart1
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText().ToLower().Split(" ");
        Console.WriteLine(string.Join("-", text));
    }
}
*/

/*
//12
public abstract class StringPart1
{
    private static (string, string) GetText()
    {
        var text = Console.ReadLine()!.Split(" | ");
        return (text[0], text[1]);
    }

    private static void Main()
    {
        var (check, text) = GetText();
        Console.WriteLine(Regex.IsMatch(text, $@"\b{check}\b", RegexOptions.IgnoreCase) ? "true" : "false");
    }
}
*/

/*
//13
public abstract class StringPart1
{
    private static (string, string) GetText()
    {
        var text = Console.ReadLine()!.Split(" | ");
        return (text[0], text[1]);
    }

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var (word, text) = GetText();
        Console.WriteLine(text.Contains("яблоки") ? text.Replace("яблоки", word) : text);
    }
}
*/

//14
public abstract class StringPart1
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var letters = GetText().ToLower().ToCharArray();
        var dictionary = new Dictionary<char, string>();
        
        foreach (var letter in letters.Distinct())
            dictionary[letter] = "";

        foreach (var letter in letters)
            dictionary[letter] += "*";
        
        Console.WriteLine(string.Join(",", dictionary.Select(x => $"{x.Key}:{x.Value}")));
    }
}