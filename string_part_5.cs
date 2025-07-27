using System.Text;

namespace lecture_C_;

/*
//String Part 5
//1
public abstract class StringPart5
{
    private static string GetPath() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var path = GetPath().Split('/');
        foreach (var pathPart in path)
        {
            if (pathPart.Contains('.'))
                Console.WriteLine(pathPart[..pathPart.IndexOf('.')]);
        }
    }
}
*/

/*
//2
public abstract class StringPart5
{
    private static string GetMessage() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var message = GetMessage();
        var result = new StringBuilder();
        var morseDictionary = new Dictionary<char, string>
        {
            {'A', ".- "}, {'B',"-... "}, {'C', "-.-. "}, {'D', "-.. "}, {'E', ". "}, {'F', "..-. "}, {'G', "--. "}, {'H', ".... "},
            {'I', ".. "}, {'J', ".--- "}, {'K', "-.- "}, {'L', ".-.. "}, {'M', "-- "}, {'N', "-. "}, {'O', "--- "}, {'P', ".--. "},
            {'Q', "--.- "}, {'R', ".-. "}, {'S', "... "}, {'T', "- "}, {'U', "..- "}, {'V', "...- "}, {'W', ".-- "}, {'X', "-..- "},
            {'Y', "-.-- "}, {'Z', "--.. "}, {'0', "----- "}, {'1', ".---- "}, {'2', "..--- "}, {'3', "...-- "}, {'4', "....- "},
            {'5', "..... "}, {'6', "-.... "}, {'7', "--... "}, {'8', "---.. "}, {'9', "----. "}, {' ', "  "}
        };

        foreach (var letter in message)
            if (morseDictionary.TryGetValue(letter, out var morseCode))
                result.Append(morseCode);
        
        Console.WriteLine(result);
    }
}
*/

/*
//3
public abstract class StringPart5
{
    private static string GetMessage() => Console.ReadLine()!.Trim();

    private static void Main()
    {
        var message = GetMessage().Split("   ");
        var result = new StringBuilder();
        var morseDictionary = new Dictionary<string, char>
        {
            {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'}, {"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'},
            {"..", 'I'}, {".---", 'J'}, {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'}, {".--.", 'P'},
            {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'}, {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'},
            {"-.--", 'Y'}, {"--..", 'Z'}, {"-----", '0'}, {".----", '1'}, {"..---", '2'}, {"...--", '3'}, {"....-", '4'},
            {".....", '5'}, {"-....", '6'}, {"--...", '7'}, {"---..", '8'}, {"----.", '9'}, {" ", ' '}
        };

        foreach (var word in message)
        {
            var letters = word.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var morseCode in letters)
            { 
                if (morseDictionary.TryGetValue(morseCode, out var letter))
                    result.Append(letter);
            }
            
            result.Append(' ');
        }
        
        Console.WriteLine(result);
    }
}
*/

//4
public abstract class StringPart5
{
    private static (string, string) GetText()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (input[0], input[1]);
    }

    private static void Main()
    {
        var (firstWord, secondWord) = GetText();
        
        if (firstWord.Length != secondWord.Length)
            Console.WriteLine(-1);

        else
        {
            var count = 0;
            for (var i = 0; i < firstWord.Length; i++)
                foreach (var letter in secondWord)
                {
                    if (firstWord[i] != letter)
                        count++;

                    i++;
                }
            
            Console.WriteLine(count);
        }
    }
}