using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите свой любимый цвет с маленькой буквы");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Iteration {0}", i);
            switch (Console.ReadLine())
            {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;

            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;

            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is yellow!");
                break;
            }
        }

        Console.WriteLine("Напишите ваше имя: ");
        var name = Console.ReadLine();

        for (int i = name.Length - 1; i >= 0; i--)
            Console.Write(name[i] + " ");

        Console.WriteLine();


        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

        for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
        {
            for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                Console.Write(array[k, i] + " ");

            Console.WriteLine();
        }
    }
}