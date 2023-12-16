using System;

class MainClass
{
    public static void Main(string[] args)
    {
        const string MyName = "Daniil";

        Console.WriteLine(MyName);

        Console.WriteLine("\t Привет, мир!");
        Console.WriteLine("\t Мне 20 лет");
        Console.WriteLine("\t My name is \n {0}", MyName);
        Console.WriteLine("\u0040");
        Console.ReadKey();

    }
}