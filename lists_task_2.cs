using System.Text;
using System.Text.Json;

namespace lecture_C_;

/*
//1, 2
public abstract class ListsTask2
{
    private static (int, List<string>) ReadInput()
    {
        var parts =  Console.ReadLine()!.Split(" | ");
        var power = int.Parse(parts[0]);
        var items = JsonSerializer.Deserialize<List<string>>(parts[1]);
        
        return (power, items)!;
    }

    public static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var (power, items) = ReadInput();
        foreach (var item in items)
        {
            if (item.Contains("Энергетик"))
                power += 5;
            else if (item.Contains("Кофе"))
                power += 10;
        }
       
        if (power > 100)
            power = 100;
       
        Console.WriteLine(power);
    }
}
*/

/*
//3, 4
public abstract class ListsTask2
{
    private static List<List<int>> ReadInput()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<List<int>>>(input!);
    }

    private static void Main()
    {
        var numbers = ReadInput();
        var digits = numbers.SelectMany(number => number).ToList();

        Console.WriteLine(digits.Min()); //.Max()
    }
}
*/

/*
//5 
public abstract class ListsTask2
{
    private static (int, List<int>) ReadInput()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (int.Parse(input[0]), JsonSerializer.Deserialize<List<int>>(input[1]))!;
    }

    private static void Main()
    {
        var (number, elementsList) = ReadInput();
        var deletedLetters = new List<int>();
        
        for (var i = 0; i < number; i++)
            deletedLetters.Add(elementsList[i]);

        while (number != 0)
        {
            elementsList.RemoveAt(0);
            number--;
        }
        
        foreach (var digits in deletedLetters)
            elementsList.Add(digits);
        
        Console.WriteLine(string.Join(", ", elementsList));
    }
}
*/

/*
//6
public abstract class ListsTask2
{
    private static (int, List<int>) ReadInput()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (int.Parse(input[0]), JsonSerializer.Deserialize<List<int>>(input[1]))!;
    }

    private static void Main()
    {
        var (number, elementsList) = ReadInput();
        for (var i = 0; i < elementsList.Count; i++)
            elementsList[i] *= number;
        
        elementsList.Sort();
        
        Console.WriteLine(string.Join(", ", elementsList));
    }
}
*/

/*
//7
public abstract class ListsTask2
{
    private static (int, List<int>) ReadInput()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (int.Parse(input[0]), JsonSerializer.Deserialize<List<int>>(input[1]))!;
    }

    private static void Main()
    {
        var (number, elementsList) = ReadInput();
        for (var i = 0; i < number; i++)
            elementsList.Add(elementsList[i]);
        
        Console.WriteLine(string.Join(", ", elementsList));
    }
}
*/

/*
//8
public abstract class ListsTask2
{
    private static List<bool> ReadInput()
    {
        var input = Console.ReadLine();
        return [..JsonSerializer.Deserialize<List<bool>>(input)!];
    }

    private static void Main()
    {
        var list = ReadInput();
        Console.WriteLine(list.All(l => l == false) ? "true" : "false");
    }
}
*/

/*
//9
public abstract class ListsTask2
{
    private static (int, string, List<int>) ReadInput()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (int.Parse(input[0]), input[1], JsonSerializer.Deserialize<List<int>>(input[2])!);
    }

    private static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        var (size, position, elementsList) = ReadInput();
        if (size < elementsList.Count)
            Console.WriteLine("Неверный размер");
        
        else 
        {
            if (position != "left" && position == "right")
            {
                while (elementsList.Count != size)
                    elementsList.Add(0);
            
                Console.Write(string.Join(", ", elementsList));
            }
            
            else if (position == "left" && position != "right")
            {
                while (elementsList.Count != size)
                    elementsList.Insert(0, 0);
            
                Console.Write(string.Join(", ", elementsList));
            }
            
            else 
                Console.WriteLine("Неверная позиция");
        }
    }
}
*/

/*
//10
public abstract class ListsTask2
{
    private static (int number, List<List<int>> data) ReadInput()
    {
        var input = Console.ReadLine()!.Split(" | ");
        return (int.Parse(input[0]), JsonSerializer.Deserialize<List<List<int>>>(input[1])!);
    }

    private static void Main()
    {
        var (number, elementsList) = ReadInput();
        Console.WriteLine(elementsList.SelectMany(array => array)
            .Any(element => elementsList.Any(_ => number == element))
            ? "true"
            : "false");
    }
}
*/

//11
public abstract class ListsTask2
{
    private static List<int> ReadInput()
    {
        var input = Console.ReadLine();
        return JsonSerializer.Deserialize<List<int>>(input!);
    }

    private static void Main()
    {
        var elementsList = ReadInput();
        var even = elementsList.Where(x => x % 2 == 0).ToList();
        var odd = elementsList.Where(x => x % 2 != 0).ToList();
        
        even.Sort();
        odd.Sort();
        
        Console.Write("(" + string.Join(", ", even) + ")" + 
                      " " + "(" + string.Join(", ", odd) + ")");
    }
}