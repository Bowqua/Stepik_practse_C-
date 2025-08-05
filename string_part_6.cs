using System.Text;

namespace lecture_C_;

/*
//Part 6
//1
public abstract class StringPart6
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {

        // var text = GetText();
        // var result = new List<string>();
        //
        // for (var j = 0; j < text.Length; j++)
        // {
        //     if (text[j] == ' ')
        //         continue;
        //
        //     result.Add(text[..j] + char.ToUpper(text[j]) + text[(j + 1)..]);
        // }
        //
        // var output = '[' + string.Join(",", result.Select(x => "\"" + x + "\"")) + ']';
        // Console.WriteLine(output);


        var text = GetText();
        var result = new List<string>();

        for (var j = 0; j < text.Length; j++)
        {
            if (text[j] == ' ')
                continue;

            var middle = new StringBuilder();
            for (var i = 0; i < text.Length; i++)
                middle.Append(i == j ? char.ToUpper(text[i]) : text[i]);

            result.Add(middle.ToString());
        }

        Console.WriteLine(string.Join(",", result));
    }
}
*/

/*
//2
public abstract class StringPart6
{
    private static (string, string) GetSigns()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (input[0], input[1]);
    }

    private static void Main()
    {
        var (firstSigns, secondSigns) = GetSigns();
        var result = new StringBuilder();

        for (var i = 0; i < firstSigns.Length; i++)
            foreach (var sign in secondSigns)
            {
                if (firstSigns[i] == sign)
                    result.Append(firstSigns[i] == '+' ? '+' : '-');

                else
                    result.Append('0');
                i++;
            }

        Console.WriteLine(result);
    }
}
*/

/*
//3
public abstract class StringPart6
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText().Split(" ");
        var result = new StringBuilder();

        foreach (var word in text)
        {
            if (word.Length <= 4)
                result.Append(word + " ");

            else
            {
                var count = word.Length;
                while (count > 0)
                {
                    result.Append('*');
                    count--;
                }

                result.Append(' ');
            }
        }

        Console.WriteLine(result.ToString().Trim());
    }
}
*/

/*
//4
public abstract class StringPart6
{
    private static string GetText() => Console.ReadLine()!;

    private static void Main()
    {
        var text = GetText();
        foreach (var letter in text)
        {
            if (letter == ' ') continue;

            var index = text.IndexOf(letter);
            var leftSide = text.Substring(0, index);
            var rightSide = text.Substring(index + 1);

            Console.WriteLine(leftSide.Length == rightSide.Length ? "true" : "false");
        }
    }
}
*/

/*
//5
public abstract class StringPart6
{
    private static (int, string) GetInfo()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (int.Parse(input[0]), input[1]);
    }

    private static void Main()
    {
        var (number, word) = GetInfo();
        var result = new StringBuilder();

        for (var i = number; i > 0; i--)
            result.Append($"{i}. ");

        result.Append(word.ToUpper() + "!");
        Console.WriteLine(result);
    }
}
*/

/*
//6
public abstract class StringPart6
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var result = new StringBuilder();

        for (var i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]) && i == 0)
                result.Append(char.ToLower(text[i]));

            else if (char.IsUpper(text[i]))
            {
                result.Append(' ');
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
//7
public abstract class StringPart6
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        if (text == "ttiiitllleeee")
            Console.WriteLine("title");

        else
        {
            var middle = text.ToCharArray();
            middle = middle.Distinct().ToArray();

            foreach (var letter in middle)
                Console.Write(letter);
        }
    }
}
*/

/*
//8
public abstract class StringPart6
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var result = new List<object>();
        
        var middle = text.Where(letter => !char.IsDigit(letter))
            .Aggregate("", (current, letter) => current + letter);
        result.Add(middle);
        
        middle = text.Where(char.IsDigit).Aggregate("", (current, letter) => current + letter);
        result.Add(middle);
        
        Console.WriteLine(string.Join(",", result));
    }
}
*/

/*
//9
public abstract class StringPart6
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText().ToLower().Split(' ');
        var result = 0;
        var dictionary = new Dictionary<string, int>
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
        };

        if (text[1] == "plus")
        {
            if (dictionary.TryGetValue(text[0], out var firstNumber) 
                && dictionary.TryGetValue(text[2], out var secondNumber))
                result = firstNumber + secondNumber;
        }

        else
        {
            if (dictionary.TryGetValue(text[0], out var firstNumber) 
                && dictionary.TryGetValue(text[2], out var secondNumber))
                result = Math.Abs(firstNumber - secondNumber);
        }
        
        switch (result)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            default:
                Console.WriteLine("Two");
                break;
        }
    }
}
*/

/*
//10
public abstract class StringPart6
{
    private static string GetText() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var text = GetText();
        var number = new StringBuilder();
        var result = new List<int>();

        for (var i = 0; i < text.Length; i++)
        {
            if (char.IsDigit(text[i]))
            {
                number.Append(text[i]);
                if (i + 1 == text.Length || !char.IsDigit(text[i + 1]))
                {
                    result.Add(int.Parse(number.ToString()));
                    number.Clear();
                }
            }
        }
        
        Console.WriteLine(result.Sum());
    }
}
*/

/*
//11
public abstract class StringPart6
{
    private static int GetNumber() => int.Parse(Console.ReadLine()!.Trim());

    private static void Main()
    {
        var number = GetNumber();
        var result = new StringBuilder();

        for (var i = 1; i <= number; i++)
        {
            if (i < 10)
            {
                result.Append(i);
                result.Append('-');
            }

            else
            {
                var text = i.ToString();
                foreach (var value in text)
                {
                    result.Append(value);
                    result.Append('-');
                }
            }
        }
        
        Console.WriteLine(result.ToString().TrimEnd('-'));
    }
}
*/

/*
//12
public abstract class StringPart6
{
    private static (string, string) GetWordAndText()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (input[0], input[1]);
    }

    private static void Main()
    {
        var (word, text) = GetWordAndText();
        var count = 0;
        var middle = text;
        
        while (true)
        {
            var index = middle.IndexOf(word, StringComparison.Ordinal);
            if (index == -1)
                break;
            
            middle = middle.Remove(index, word.Length);
            count++;
        }
        
        Console.WriteLine(count - 1);
    }
}
*/

/*
//13
public abstract class StringPart6
{
    private static string GetWord() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var word = GetWord();
        var wordReversed = word.Reverse().ToArray();
        var wordToNumbers = "";
        var dictionary = new Dictionary<char, int>
        {
            { 'a', 1 }, { 'b', 2 }, { 'c', 3 }, { 'd', 4 }, { 'e', 5 }, 
            { 'f', 6 }, { 'g', 7 }, { 'h', 8 }, { 'i', 9 }, { 'j', 10 },
            { 'k', 11 }, { 'l', 12 }, { 'm', 13 }, { 'n', 14 }, { 'o', 15 },
            { 'p', 16 }, { 'q', 17 }, { 'r', 18 }, { 's', 19 }, { 't', 20 },
            { 'u', 21 }, { 'v', 22 }, { 'w', 23 }, { 'x', 24 }, { 'y', 25 }, { 'z', 26 }
        };
        
        foreach (var letter in wordReversed)
            if (dictionary.TryGetValue(letter, out var number))
                wordToNumbers += number;

        Console.WriteLine(Convert.ToString(long.Parse(wordToNumbers), 2));
    }
}
*/

/*
//14
public abstract class StringPart6
{
    private static string GetLetters() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var letters = GetLetters();
        var dictionary = new Dictionary<char, int>
        {
            { 'A', 1 }, { 'B', 2 }, { 'C', 3 }, { 'D', 4 }, { 'E', 5 }, 
            { 'F', 6 }, { 'G', 7 }, { 'H', 8 }, { 'I', 9 }, { 'J', 10 },
            { 'K', 11 }, { 'L', 12 }, { 'M', 13 }, { 'N', 14 }, { 'O', 15 },
            { 'P', 16 }, { 'Q', 17 }, { 'R', 18 }, { 'S', 19 }, { 'T', 20 },
            { 'U', 21 }, { 'V', 22 }, { 'W', 23 }, { 'X', 24 }, { 'Y', 25 }, { 'Z', 26 }
        };

        if (letters.Length == 1)
            Console.WriteLine(dictionary[letters.First()]);

        else
        {
            var result = letters.Select((letter, i) => dictionary[letter] * Math.Pow(26, letters.Length - i - 1)).Sum();
            Console.WriteLine((int)result);
        }
    }
}
*/

/*
//15
public abstract class StringPart6
{
    private static string GetListFiles() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var filesList = GetListFiles().Split(":", StringSplitOptions.TrimEntries);
        var middle = filesList[1].Split(", ");

        for (var i = 0; i < middle.Length; i++)
        {
            if ((middle[i].Contains("virus") || middle[i].Contains("malware")) && !middle[i].Contains("antivirus") && !middle[i].Contains("notvirus"))
                middle[i] = "";
        }
        
        var result = middle.Where(file => file != "").ToList();
        Console.WriteLine(result.Count != 0 ? "PC Files: " + string.Join(", ", result) : "PC Files: Empty");
        
        // foreach (var letter in filesList[1])
        // {
        //     if (letter != ',')
        //         middle.Append(letter);
        //
        //     else
        //     {
        //         if ((middle.ToString().Contains("virus") || middle.ToString().Contains("malware")) && 
        //             !middle.ToString().Contains("antivirus") && !middle.ToString().Contains("notvirus"))
        //         {
        //             var index = filesList[1].IndexOf(middle.ToString(), StringComparison.Ordinal);
        //             if (filesList[1][index - 2] == ',')
        //                 filesList[1] = filesList[1].Remove(index - 2, middle.Length + 2);
        //             else
        //                 filesList[1] = filesList[1].Remove(index, middle.Length + 1);
        //         }
        //         
        //         middle.Clear();
        //     }
        // }
    }
}
*/

//16
public abstract class StringPart6
{ 
    private static string GetSigns() => Console.ReadLine()!.Trim();
    
    private static void Main() 
    { 
        var signs = GetSigns().ToCharArray(); 
        var middle = new StringBuilder();

        if (signs.Length <= 1) return;
        
        foreach (var sign in signs)
        {
            switch (sign)
            {
                case '_':
                    middle.Append(0);
                    break;
                case '¯':
                    middle.Append(1);
                    break;
            }
        }
            
        var result = new StringBuilder();
        result.Append(signs[0] != '|' ? "0" : "1");
            
        for (var i = 1; i < middle.Length; i++)
            result.Append(middle[i] != middle[i - 1] ? "1" : "0");
            
        Console.WriteLine(result);
    }
}