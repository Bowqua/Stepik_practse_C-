using System.Text;

namespace lecture_C_;
/*
// 1
public abstract class ManagedStructures
{
        private static int ReadInput() => int.Parse(Console.ReadLine()!);

        private static int Disorder(int number)
        {
                if (number is 1 or 2) return number - 1;
                return (number - 1) * (Disorder(number - 1) + Disorder(number - 2));
        }

        public static void Main() => Console.WriteLine(Disorder(ReadInput()));
}
*/

/*
// 2
public abstract class ManagedStructures
{
    private static Tuple<int, int, int> ReadInput()
    {
        var inputs = Console.ReadLine()!.Trim().Split(" | ");
        return Tuple.Create(int.Parse(inputs[0]), int.Parse(inputs[1]), int.Parse(inputs[2]));
    }

    private static void Main()
    {
        var countAttack = 0;
        var (countKill, countHeads, countGrowingHeads) = ReadInput();
        var step = 0;

        while (countHeads > 0)
        {
            countAttack += 1;
            countHeads -= countKill;

            if (countHeads is < 0 or 0)
            {
                Console.WriteLine(countAttack);
                break;
            }

            countHeads += countGrowingHeads;
            step += 1;

            if (step <= 20) continue;
            Console.WriteLine(-1);
            break;
        }
    }
}
*/

/*
//3
public abstract class ManagedStructures
{
    private static Tuple<string, int> GetInput()
    {
        var inputs = Console.ReadLine()!.Trim().Split(" | ");
        return Tuple.Create(inputs[0], int.Parse(inputs[1]));
    }

    public static void Main()
    {
        var (message, number) = GetInput();
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(message);
        
        if (number > 0)
        {
            for (var i = 1; i < number; i++)
               stringBuilder.Append(message);
            
            Console.WriteLine(stringBuilder);
        }
        
        else if (number < 0 && message.Length % Math.Abs(number) == 0)
        {
            var step = message.Length / Math.Abs(number);
            for (var i = 1; i <= step; i++)
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
            
            Console.WriteLine(stringBuilder);
        }
        
        else if (number < 0 && message.Length % Math.Abs(number) != 0)
            Console.WriteLine("NO SOLUTION");
        
        else 
            Console.WriteLine("");
    }
}
*/

/*
//4
public abstract class ManagedStructures
{
    private static int ReadInput() => int.Parse(Console.ReadLine()!);

    private static bool HasBreakPoint(int number)
    {
        var numberToText = number.ToString();
        var deleted = new StringBuilder();
        
        for (var i = 0; i < numberToText.Length; i++)
        {
            var deletedLetter = deleted.Append(numberToText[i]).ToString();
            var part = numberToText[(i + 1)..];

            var partSum = part.Sum(t => int.TryParse(t.ToString(), out var resultPart) ? resultPart : 0);
            var deletedLetterSum = deletedLetter.Sum(k => int.TryParse(k.ToString(), out var resultDeleted) ? resultDeleted : 0);

            if (deletedLetterSum == partSum)
                return true;
        }

        return false;
    }

    public static void Main()
    {
        var number = ReadInput();
        Console.WriteLine(HasBreakPoint(number).ToString().ToLower());
    }
}
*/

//5
public abstract class ManagedStructures
{
    private static int ReadInput() => int.Parse(Console.ReadLine()!);

    private static void Main()
    {
        var headsCount = ReadInput();
        switch (headsCount % 3)
        {
            case 0:
            {
                Console.WriteLine(Math.Pow(3, headsCount / 3));
                break;
            }
            case 1:
                Console.WriteLine(Math.Pow(3, headsCount / 3 - 1) * 2 * 2);
                break;
            case 2:
            {
                Console.WriteLine(Math.Pow(3, headsCount / 3) * 2);
                break;
            }
        }
    }
}


