using System.Text;
using System.Text.Json;

namespace lecture_C_;

/*
//1
public class ListTask6
{
    private static List<int> GetDigits()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!).ToList();
    }

    private static void Main()
    {
        var coordinates = GetDigits();
        var x = coordinates[0];
        var y = coordinates[1];

        if ((Math.Abs(x) + Math.Abs(y)) % 5 != 0 && Math.Abs(x) + Math.Abs(y) < 10)
            Console.WriteLine(Math.Abs(x) + Math.Abs(y) + (Math.Abs(x) + Math.Abs(y)) / 5);
        
        else switch ((Math.Abs(x) + Math.Abs(y)) % 5)
        {
            case 0 when Math.Abs(x) + Math.Abs(y) < 10:
                Console.WriteLine(Math.Abs(x) + Math.Abs(y));
                break;
            case 0 when Math.Abs(x) + Math.Abs(y) > 10:
                Console.WriteLine(Math.Abs(x) + Math.Abs(y) + (Math.Abs(x) + Math.Abs(y)) / 5 - 1);
                break;
            default:
                Console.WriteLine(Math.Abs(x) + Math.Abs(y) + (Math.Abs(x) + Math.Abs(y)) / 5);
                break;
        }
    }
}
*/

/*
//2
public class ListTask6
{
    private static List<List<int>> GetMatrix()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<List<int>>>(input!);
    }

    private static void Main()
    {
        var matrix = GetMatrix();
        var isValidUp = matrix[0].Contains(0);
        var isValidDown = matrix[^1].Contains(0);
        
        var result = new List<bool>
        {
            isValidUp,
            isValidDown
        };

        for (var i = 1; i < matrix.Count; i++)
        {
            var row = matrix[i];
            if (row[0] == 0 && row[^1] == 0)
                result.Add(true);
            
            else 
                result.Add(false);
        }

        Console.WriteLine(result.All(x => x) ? "true" : "false");
    }
}
*/

/*
//3
public class ListTask6
{
    private static (List<List<int>> intervals, int point) GetInput()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (JsonSerializer.Deserialize<List<List<int>>>(input[0]), int.Parse(input[1]))!;
    }

    private static void Main()
    {
        var (intervals, point) = GetInput();
        var count = intervals.Count(interval => interval.Contains(point) || (point >= interval[0] && point <= interval[1]));

        Console.WriteLine(count);
    }
}
*/

/*
//4
public class ListTask6
{
    private static (List<string>, List<int>) GetInput()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (JsonSerializer.Deserialize<List<string>>(input[0]),
            JsonSerializer.Deserialize<List<int>>(input[1]))!;
    }

    private static void Main()
    {
        var (classifications, prices) = GetInput();
        var dictionary = new Dictionary<string, List<int>>();

        for (var i = 0; i < classifications.Count; i++)
        {
            if (!dictionary.TryGetValue(classifications[i], out var list))
            {
                list = [];
                dictionary[classifications[i]] = list;
            }

            list.Add(prices[i]);
        }
        
        if (dictionary.TryGetValue("S", out var valueFirst) && dictionary.TryGetValue("N", out var valueSecond))
            Console.WriteLine($"[{valueFirst.Sum() + valueSecond.Sum() / 2},{valueSecond.Sum() / 2}]");
        
        else
            Console.WriteLine($"[{valueSecond.Sum() / 2},{valueSecond.Sum() / 2}]");
    }
}
*/

/*
//5
public class ListTask6
{
    private static int GetNumber()
    {
        var input = Console.ReadLine();
        return int.Parse(input!);
    }

    private static void Main()
    {
        var number = GetNumber();
        var square = new List<string>();

        if (number == 1)
            square.Add("#");
        
        else if (number == 2)
        {
            square.Add("##");
            square.Add("##");
        }
        
        else
        {
            var text = new StringBuilder();
            var count = 0;
            
            for (var i = 1; i <= number * number; i++)
            {
                text.Append('#');
                count++;
                
                if (i % number == 0 && (count == number || count == number * number))
                {
                    square.Add(text.ToString());
                    text.Clear();
                }

                else if (i % number == 0 && (count != number || count != number * number))
                {
                    var spaces = new string(' ', text.Length - 2);
                    
                    text.Remove(1, number - 2);
                    text.Insert(text.Length - 1, spaces);
                    square.Add(text.ToString());
                    text.Clear();
                }
            }
        }
        
        Console.WriteLine(JsonSerializer.Serialize(square));
    }
}
*/

/*
//6
public abstract class ListTask6
{
    private static List<int> GetNumbers()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var numbers = GetNumbers();
        for (var i = 1; i <= 26; i++)
            if (!numbers.Contains(i))
                Console.WriteLine((char)('A' + i - 1));
    }
}
*/

/*
//7
public abstract class ListTask6
{
    private static List<int> GetNumbers()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var numbers = GetNumbers();
        var current = numbers[0];
        var dictionary = new Dictionary<int, int>();
        
        for (var i = 0; i < numbers.Count; i++)
            dictionary.Add(i, numbers[i]);

        for (var i = 0; i < numbers.Count; i++)
            if (dictionary.TryGetValue(current, out var value))
                current = value;

        Console.WriteLine(current == numbers[0] ? "true" : "false");
    }
}
*/

//8
public abstract class ListTask6
{
    private static List<List<string>> GetGame()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<List<string>>>(input!);
    }

    private static void Main()
    {
        var game = GetGame();
        var number = game.Count;
        var rowSum = new int[number];
        var columnSum = new int[number];
        int leftDiagonal = 0, rightDiagonal = 0;
        
        for (var row = 0; row < number; row++)
            for (var column = 0; column < number; column++)
            {
                var cell = game[row][column];
                var delta = cell == "X" ? 1 : cell == "O" ? -1 : 0;
                
                rowSum[row] += delta;
                columnSum[column] += delta;
                
                if (row == column)
                    leftDiagonal += delta;
                
                if (row + column == number - 1)
                    rightDiagonal += delta;
            }
        
        var xWins = rowSum.Any(x => x == number) 
                    || columnSum.Any(x => x == number)
                    || leftDiagonal == number || rightDiagonal == number;
        
        var oWins = rowSum.Any(x => x == -number) 
                    || columnSum.Any(x => x == -number)
                    || leftDiagonal == -number || rightDiagonal == -number;
        
        if (xWins && !oWins)
            Console.WriteLine("Игрок 1 победил");
        else if (oWins && !xWins)
            Console.WriteLine("Игрок 2 победил");
        else 
            Console.WriteLine("Ничья");
    }

    // private static void Main()
    // {
    //     var game = GetGame();
    //     
    //     var upRow = game[0];
    //     var downRow = game[^1];
    //     var leftSideCross = game.Select(t => t[0]).ToList();
    //     var rightSideCross = game.Select(t => t[^1]).ToList();
    //     var diagonalLeft = game.Select((t, i) => t[i]).ToList();
    //     
    //     var diagonalRight = new List<string>();
    //     for (var i = game.Count - 1; i >= 0; i--)
    //         diagonalRight.Add(game[i][game.Count - i - 1]);
    //     
    //     var areAllCross = upRow.All(x => x == "X") || downRow.All(x => x == "X");
    //     var areAllCrossLeftRight = leftSideCross.All(x => x == "X") || rightSideCross.All(x => x == "X");
    //     var areAllCrossDiagonalLeft = diagonalLeft.All(x => x == "X");
    //     var areAllCrossDiagonalRight = diagonalRight.All(x => x == "X");
    //     
    //     var areAllZero = upRow.All(x => x == "O") || downRow.All(x => x == "O");
    //     var areAllZeroLeftRight = leftSideCross.All(x => x == "O") || rightSideCross.All(x => x == "O");
    //     var areAllZeroDiagonalLeft = diagonalLeft.All(x => x == "O");
    //     var areAllZeroDiagonalRight = diagonalRight.All(x => x == "O");
    //     
    //     if (areAllCross || areAllCrossLeftRight || areAllCrossDiagonalLeft || areAllCrossDiagonalRight)
    //         Console.WriteLine("Игрок 1 победил");
    //     else if (areAllZero || areAllZeroLeftRight || areAllZeroDiagonalLeft || areAllZeroDiagonalRight)
    //         Console.WriteLine("Игрок 2 победил");
    //     else 
    //         Console.WriteLine("Ничья");
    // }
}