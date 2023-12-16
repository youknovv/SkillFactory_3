using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.Write("Enter your age: ");
        var age = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Your name is {name} and age is {age} \n");
        Console.Write("Enter your birthdate: ");
        var birthdate= Console.ReadLine();
        Console.Write($"Your birthdate is {birthdate}");

        Console.ReadKey();
    }

}