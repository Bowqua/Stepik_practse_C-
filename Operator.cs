// namespace lecture_C_;
//
// public abstract class MainClass
// {
//     private static void Main()
//     {
//         var inputValues = ReadInput();
//         Console.WriteLine(inputValues[0] - inputValues[1]);
//     }
//
//     private static int[] ReadInput()
//     {
//         var values = Console.ReadLine()!.Split(' ');
//         return values!.Select(int.Parse).ToArray();
//     }
// }

// public class MainClass
// {
//     public static void Main()
//     {
//         Console.WriteLine(3600 * int.Parse(Console.ReadLine()!));
//     }
// }

// public class MainClass
// {
//     public static void Main()
//     {
//         var num = int.Parse(Console.ReadLine()!);
//         Console.WriteLine(num % 2 == 0 ? "Четное" : "Нечетное");
//     }
// }

// public class MainClass
// {
//     public static void Main()
//     {
//         var inputValues = ReadInput();
//         Console.WriteLine(inputValues[0] == inputValues[1] ? "true" : "false");
//     }
//
//     private static string[] ReadInput()
//     {
//         var inputValues = Console.ReadLine()!.Split(' ');
//         return inputValues;
//     }
// }

// public class MainClass
// {
//     public static void Main()
//     {
//         var role = ReadInput();
//         switch (role)
//         {
//             case 1:
//                 Console.WriteLine("admin");
//                 break;
//             case 2:
//                 Console.WriteLine("moderator");
//                 break;
//             case 3:
//                 Console.WriteLine("user");
//                 break;
//             default:
//                 Console.WriteLine("guest");
//                 break;
//         }
//     }
//
//     private static int ReadInput()
//     {
//         return int.Parse(Console.ReadLine()!);
//     }
// }

// using System.Text;
//
// public class MainClass
// {
//     public static void Main()
//     {
//         // var length = ReadInput().Length;
//         // while (length > 0)
//         // {
//         //     Console.Write("*");
//         //     length--;
//         // }
//         
//         var text = new StringBuilder();
//         Console.WriteLine(text.Append('*', ReadInput().Length));
//     }
//
//     private static string ReadInput()
//     {
//         return Console.ReadLine()!;
//     }
// }


// public class Comparing
// {
//     public static void Main()
//     {
//         var number = ReadInput();
//         Console.WriteLine(number > 0 ? number * 2 : number);
//     }
//
//     private static int ReadInput()
//     {
//         return int.Parse(Console.ReadLine()!);
//     }
// }


// public class MainClass
// {
//     public static void Main()
//     {
//         var n = ReadInput();
//         var sum = 1;
//         
//         for (var i = 1; i <= n; i++)
//             sum *= i % 2 != 0 ? i : 1;
//         
//         Console.WriteLine(sum);
//     }
//
//     private static int ReadInput() => int.Parse(Console.ReadLine() ?? string.Empty);
// }

// public class MainClass
// {
//     public static void Main()
//     {
//         var number = int.Parse(Console.ReadLine()!);
//         
//     }
// }

// public class Operator
// {
//     public static void Main()
//     {
//         var number = int.Parse(Console.ReadLine()!);
//         if (number % 2 == 0 && number % 6 == 0) Console.WriteLine("true");
//         else Console.WriteLine("false");
//     }
// }

// public class Operator
// {
//     private static void Main()
//     {
//         var numbersInArray = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
//         Console.WriteLine($"минимальное: {numbersInArray.Min()}, максимальное: {numbersInArray.Max()}");
//     }
// }

// using System.Text;
//
// public class Operator
// {
//     public static void Main()
//     {
//         var count = int.Parse(Console.ReadLine()!);
//         var stars = new StringBuilder();
//         Console.WriteLine(stars.Append('\u2605', count));
//     }
// }

// public class Direction
// {
//     public static void Main()
//     {
//         var numbersWithDirection = Console.ReadLine()!.Split(' ');
//         if (int.Parse(numbersWithDirection[0]) > 100 || int.Parse(numbersWithDirection[0]) < 0 || int.Parse(numbersWithDirection[1]) > 100 || int.Parse(numbersWithDirection[1]) < 0) 
//             Console.WriteLine("Invalid input!");
//         else switch(numbersWithDirection[2])
//         { 
//             case "down":
//                 Console.WriteLine(int.Parse(numbersWithDirection[1]) + 1 > 100
//                     ? $"x: {numbersWithDirection[0]}, y: 100, direction: {numbersWithDirection[2]}"
//                     : $"x: {numbersWithDirection[0]}, y: {int.Parse(numbersWithDirection[1]) + 1}, direction: {numbersWithDirection[2]}");
//                 return;
//             case "up":
//                 Console.WriteLine(int.Parse(numbersWithDirection[1]) - 1 < 0
//                     ? $"x: {numbersWithDirection[0]}, y: 0, direction: {numbersWithDirection[2]}"
//                     : $"x: {numbersWithDirection[0]}, y: {int.Parse(numbersWithDirection[1]) - 1}, direction: {numbersWithDirection[2]}");
//                 return;
//             case "left":
//                 Console.WriteLine(int.Parse(numbersWithDirection[0]) - 1 < 0
//                     ? $"x: 0, y: {numbersWithDirection[1]}, direction: {numbersWithDirection[2]}"
//                     : $"x: {int.Parse(numbersWithDirection[0]) - 1}, y: {numbersWithDirection[1]}, direction: {numbersWithDirection[2]}");
//                 return;
//             case "right":
//                 Console.WriteLine(int.Parse(numbersWithDirection[0]) + 1 > 100
//                     ? $"x: 100, y: {numbersWithDirection[1]}, direction: {numbersWithDirection[2]}"
//                     : $"x: {int.Parse(numbersWithDirection[0]) + 1}, y: {numbersWithDirection[1]}, direction: {numbersWithDirection[2]}");
//                 return;
//         }
//     }
// }

namespace lecture_C_;

public abstract class PositiveOrNegative
{
    public static void Main()
    {
        switch (int.Parse(Console.ReadLine()!))
        {
            case < 0:
                Console.WriteLine("Число негативное");
                break;
            case 0:
                Console.WriteLine("Число равно 0");
                break;
            default:
                Console.WriteLine("Число позитивное");
                break;
        }
    }
}