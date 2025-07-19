using System.Text;
using System.Text.Json;

namespace lecture_C_;

/*
//Part 3
//4, 5
public abstract class StringPart3
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var result = new StringBuilder();

        for (var i = 0; i < text.Length; i++)
        {
            if (i == 0)
                result.Append(text[i].ToString().ToUpper()); // без этого условия
            
            else if (text[i] == '-')
            {
                result.Append(text[i + 1].ToString().ToUpper());
                i += 1;
            }
                
            else 
                result.Append(text[i]);
        }
        
        Console.WriteLine(result);
    }
}
*/

/*
//1
public abstract class StringPart3
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText().Split('.');
        var result = new StringBuilder($"<{text[0]} class=\"");

        for (var i = 1; i < text.Length; i++)
            result.Append($"{text[i]} ");
        
        result.Remove(result.Length - 1, 1);
        result.Append($"\"></{text[0]}>");
        
        Console.WriteLine(result);
    }
}
*/

/*
//2
public abstract class StringPart3
{
    private static string GetTags() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var tags = GetTags().Split('>');
        Console.WriteLine($"<{tags[0]}><{tags[1]}><{tags[2]}></{tags[2]}></{tags[1]}></{tags[0]}>");
    }
}
*/

/*
//3
public abstract class StringPart3
{
    private static string GetTags() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var tagsAndText = GetTags();
        char[] separators = ['>', '{',  '}'];
        var middle = tagsAndText.Split(separators);
        
        var result = new StringBuilder();
        
        if (middle.Length == 4)
            result.Append($"<{middle[0]}><{middle[1]}>{middle[2]}</{middle[1]}></{middle[0]}>");
        
        else 
            result.Append($"<{middle[0]}><{middle[1]}><{middle[2]}>{middle[3]}</{middle[2]}></{middle[1]}></{middle[0]}>");
        
        Console.WriteLine(result.ToString());
    }
}
*/

/*
//6
public abstract class StringPart3
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var result = new StringBuilder();

        for (var i = 0; i < text.Length; i++)
        {
            if (i == 0)
                result.Append(char.ToLower(text[i]));
            
            else if (char.IsUpper(text[i]))
            {
                result.Append('_');
                result.Append(char.ToLower(text[i]));
            }
            
            else 
                result.Append(text[i]);
        }
        
        Console.WriteLine(result);
    }
}
*/

/*
//8
public abstract class StringPart3
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var text = GetText().ToLower().Split(' ');
        var count = text.Count(word => word[0] == word[^1]);

        Console.WriteLine(count);
    }
}
*/

/*
//9, 10 
public abstract class StringPart3
{
    private static string GetMessage() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var message = GetMessage().Split(" ");
        var minLength = message.Max(x => x.Length); // Min
        
        Console.WriteLine(minLength);
    }
}
*/

/*
//7
public abstract class StringPart3
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        if (text.Contains('-'))
            Console.WriteLine("kebab-case");
        
        else if (text.Contains('_'))
            Console.WriteLine("snake_case");
        
        else if (char.IsLower(text[0]) && !text.Contains(' '))
            Console.WriteLine("lowerCamelCase");
        
        else if (char.IsUpper(text[0]) && !text.Contains(' '))
            Console.WriteLine("UpperCamelCase");
        
        else 
            Console.WriteLine("unknown");
    }
}
*/

/*
//11
public abstract class StringPart3
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var forbiddenLetter = new List<string>
        {
            "#", "@", "$", "%"
        };
        var result = new StringBuilder();

        foreach (var letter in text)
        {
            if (!forbiddenLetter.Contains(letter.ToString()))
                result.Append(letter);
        }
        
        Console.WriteLine(result);
    }
}
*/

/*
//12
public abstract class StringPart3
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var text = GetText();
        var result = new StringBuilder();

        for (var i = 0; i < text.Length; i++)
            if (i == 0 || i % 3 != 2)
                result.Append(text[i]);
        
        Console.WriteLine(result);
    }
}
*/

/*
//13
public abstract class StringPart3
{
    private static List<string> GetWords()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<string>>(input!);
    }

    private static void Main()
    {
        var text = GetWords();
        var result = new List<char>();

        foreach (var letter in text.Select(word => word.ToCharArray()))
            result.AddRange(letter);
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

/*
//14
public abstract class StringPart3
{
    private static List<string> GetWords()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<string>>(input!);
    }

    private static void Main()
    {
        var words = GetWords();
        var result = new List<char>();

        foreach (var word in words)
        {
            if (word.Length % 2 == 1)
                result.Add(word[word.Length / 2]);
        }
        
        // var result = (from word in words where word.Length % 2 == 1 select word[word.Length / 2]).ToList();
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

/*
//15
public abstract class StringPart3
{
    private static List<string> GetWords()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<string>>(input!);
    }

    private static void Main()
    {
        var words = GetWords();
        var result = new List<char>();

        foreach (var symbols in words.Select(word => word.ToCharArray()))
        {
            result.Add(symbols[0]);
            result.Add(symbols[^1]);
        }
        
        Console.WriteLine(JsonSerializer.Serialize(result));
    }
}
*/

//16
public abstract class StringPart3
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        if (text.Length > 4)
        {
            var length = text.Length - 4;
            var middle = "";
            text = text[^4..];

            for (var i = 0; i < length; i++)
                middle += "#";
            
            Console.WriteLine(middle + text);
        }
        
        else 
            Console.WriteLine(text);
    }
}