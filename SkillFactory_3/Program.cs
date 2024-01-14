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

        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int temp;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        foreach (var item in arr)
        {
            Console.Write(item);
        }
        Console.WriteLine();

        var arr2 = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int sum = 0;

        for (int i = 0; i < arr2.Length; i++)
        {
            sum += arr2[i];
        }

        Console.WriteLine(sum);

        int[][] array2 = new int[3][];

        array2[0] = new int[2] { 1, 2 };
        array2[1] = new int[3] { 1, 2, 3 };
        array2[2] = new int[5] { 1, 2, 3, 4, 5 };

        foreach (var num in array2)
        {
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }
        }
        Console.WriteLine();

        int[] array3 = { -1, 2, 3, -5, 6, 7, 8, 9, -8, 11, 0, -13 };
        var number1 = 0;

        for (int i = 0; i < array3.Length; i++)
        {
            if (array3[i] > 0)
                number1++;
        }
        Console.WriteLine(number1);

        (string Name, string Type, double Age, int NameCount) Pet;
        Pet.Name = Console.ReadLine();
        Pet.Type = Console.ReadLine();
        Pet.Age = Convert.ToDouble(Console.ReadLine());
        Pet.NameCount = Pet.Name.Length;
        Console.WriteLine("Имя питомца: {0}", Pet.Name);
        Console.WriteLine("Тип питомца: {0}", Pet.Type);
        Console.WriteLine("Возраст питомца: {0}", Pet.Age);
        Console.WriteLine("Длина имени питомца: {0}", Pet.NameCount);

            (string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] FavColor) User;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите имя пользователя: ");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию пользователя: ");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин: ");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;
                Console.WriteLine("Длина логина: {0}", User.LoginLength);

                Console.WriteLine("Есть ли у вас животные? Да или нет");
                var pet = Console.ReadLine();
                if (pet == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.WriteLine("Введите возраст пользователя: ");
                User.Age = double.Parse(Console.ReadLine());

                User.FavColor = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int j = 0; j < User.FavColor.Length; j++)
                {
                    User.FavColor[j] = Console.ReadLine();
                }
            }
    }
}
