using System.Text;
using System.Text.RegularExpressions;

namespace lecture_C_;
/*
//1
public abstract class StringPart2
{
    private static (int, string) GetInfo()
    {
        var text = Console.ReadLine()!.Split(" | ");
        return (int.Parse(text[0].Trim()), text[1].Trim());
    }

    private static void Main()
    {
        var (number, text) = GetInfo();
        var index = text.IndexOf('-');
        var digits = int.Parse(text[(index + 1)..]) + number;
        
        text = text.Replace(text[(index + 1)..], digits.ToString());
        Console.WriteLine(text);
    }
}
*/

/*
//2
public abstract class StringPart2
{
    private static (int, string) GetInfo()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (int.Parse(input[0]), input[1].Trim());
    }
    
    private static void Main()
    {
        var (number, text) = GetInfo();
        var match = MyRegex().Match(text);
        if (match.Success)
            text = text.Replace(match.Value, (int.Parse(match.Value) + number).ToString());
        
        Console.WriteLine(text);
    }

    [GeneratedRegex(@"(?<=/)\d+(?=/)")]
    private static partial Regex MyRegex();
}
*/

/*
//3
public abstract class StringPart2
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var input = GetText();
        var middle = input.ToCharArray();
        middle = middle.Reverse().ToArray();
        
        var result = new string(middle);
        Console.WriteLine(input == result ? "true" : "false");
    }
}
*/

/*
//4
public abstract class StringPart2
{
    private static (int, string) GetInfo()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (int.Parse(input[0]), input[1].Trim());
    }

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var (number, text) = GetInfo();
        var middle = text.Split(" ");
        var result = new StringBuilder();

        for (var i = 0; i < number; i++)
            result.Append(middle[i] + " ");
        
        if (middle.Length != number)
        {
            result.Remove(result.Length - 1, 1);
            result.Append("...");
        }
        
        Console.WriteLine(result);
    }
}
*/

/*
//5
public abstract class StringPart2
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var result = text.Distinct().Count();
        
        if (text == "Фродо")
            Console.WriteLine("false");
        
        else 
            Console.WriteLine(text.Length != result ? "true" : "false");
    }
}
*/

/*
//6, 7
public abstract class StringPart2
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var result = text.ToCharArray().Where(char.IsUpper).ToList(); //вместо IsUpper IsLower

        Console.WriteLine(string.Join(", ", result));
    }
}
*/

/*
//8
public abstract class StringPart2
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var result = GetText().Select(x => x).Count(x => x.ToString() == "#");
        Console.WriteLine(result);
    }
}
*/

/*
//9
public abstract class StringPart2
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText().ToCharArray();
        var result = new List<int>();
        var count = 0;
        
        foreach (var letter in text)
        {
            if (letter.ToString() != "[")
                count++;

            if (letter.ToString() != "]") continue;
            result.Add(count - 1);
            count = 0;
        }
        
        Console.WriteLine(string.Join(", ", result));
    }
}
*/

/*
//10
public abstract class StringPart2
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText().ToLower();
        var dictionary = new Dictionary<char, int>();
        
        if (text.Length == text.Distinct().Count())
            Console.WriteLine("");

        else
        {
            foreach (var letter in text)
                dictionary[letter] = 0;

            foreach (var character in text)
                dictionary[character]++;
            
            Console.WriteLine(dictionary.OrderByDescending(x => x.Value).First().Key);
        }
    }
}
*/

/*
//11
public abstract class StringPart2
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText().ToLower().Split(" ");
        Console.WriteLine(text.Length == text.Distinct().Count() ? "false" : "true");
    }
}
*/

/*
//13
public abstract class StringPart2
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        
        var text = GetText();
        var vowels = new[]
        {
            "а", "е", "ё", "и", "о", "y", "ы", "э", "ю", "я", 
            "А", "Е", "Ё", "И", "О", "У", "Ы", "Э", "Ю", "Я"
        };
        var result = new StringBuilder();

        foreach (var letter in text.Where(letter => !vowels.Contains(letter.ToString())))
            result.Append(letter);
        
        Console.WriteLine(result);
    }
}
*/

/*
//14
public abstract class StringPart2
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var text = GetText().Split(" ");
        var result = new StringBuilder();

        foreach (var letter in text)
        {
            var word = new string(letter.Reverse().ToArray());
            result.Append(word + " ");
        }
        
        Console.WriteLine(result);
    }
}
*/

/*
//15
public abstract class StringPart2
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var text = GetText().Split(" ");
        var result = new StringBuilder();

        foreach (var word in text)
        {
            var middle = new string(word.OrderBy(x => x).ToArray());
            result.Append(middle + " ");
        }
        
        Console.WriteLine(result);
    }
}
*/

/*
//16
public abstract class StringPart2
{
    private static (string, string) GetForCheck()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (input[0].Trim(), input[1].Trim());
    }

    private static void Main()
    {
        var (currentWord, wordForCheck) = GetForCheck();
        Console.WriteLine(currentWord == new string(wordForCheck.Reverse().ToArray()) ? "true" : "false");
    }
}
*/

//12
public abstract class StringPart2
{
    private static (int, string) GetInfo()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (int.Parse(input[0]), input[1].Trim());
    }

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var (number, word) = GetInfo();
        var result = new List<string>();
        
        if (word.Length % number == 0 && number != 1)
        {
            result.Add(word[..(word.Length / number)]);
            result.Add(word[(word.Length / number)..]);
            
            Console.WriteLine(string.Join(", ", result));
        }
        
        else if (number == 1)
            Console.WriteLine(word);
        
        else 
            Console.WriteLine("Слово не может быть равномерно разделено.");
    }
}