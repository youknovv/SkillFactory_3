using System;

class MainClass
{
    public static void Main(string[] args)
    {
        const string MyName = "Daniil";
        byte MyAge = 20;
        bool Pet = true;
        double ShoeSize = 44.5;

        Console.WriteLine("My name is " + MyName);
        Console.WriteLine("My age is " + MyAge);
        Console.WriteLine("Do I have a pet? " + Pet);
        Console.WriteLine("My shoe size is " + ShoeSize);

        Console.ReadKey();

    }
}