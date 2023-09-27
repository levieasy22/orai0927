using System;

namespace tavesz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            string name = "Anna";
            int age = 34;
            float height = 165.7F;
            float weight = 62;
            decimal money = 1000;

            string name = "Márk";
            int age = 17;
            float height1 = 167F;
            float weight1 = 64;
            decimal money1 = 1000000;

            string name = "Dominik";
            int age = 117;
            float height1 = 165F;
            float weight1 = 640;
            decimal money2 = 6400000000;

            // <name> nevű felhasználó kora: <age>
            Console.Write(name);
            Console.Write(" nevű felhasználó kora:");
            Console.WriteLine(age);

            Console.WriteLine(name + " nevű felhasználó kora: " + age);

            //interpolation
            Console.WriteLine($"{name} nevű felhasználó kora: {age}");

            //String.Format(text, varibales)
            Console.WriteLine("{0} nevű felhasználó kora: {1}", name, age);

            Console.WriteLine("/------------------------------------------------------------------\\");
            Console.WriteLine("| Név       |    Kor |       Magasság |      Súly |         Zsebpénz|");
            Console.WriteLine("*-------------------------------------------------------------------*");
            Console.WriteLine($"| {name, 10} | {age, 4} | {height, 8} | {weight, 5} | {money, 20:C2}");
            Console.WriteLine($"| {name1,10} | {age1,4} | {height1,8} | {weight1,5} | {money1,12:C2}");
            Console.WriteLine($"| {name2,10} | {age2,4} | {height2,8} | {weight2,5} | {money2,12:C2}");
            Console.WriteLine("\-------------------------------------------------------------------/");

            Console.WriteLine("Formázási minták vége");
            Console.ReadLine();

            int x = 10;
            int y = 20;

            Console.CursorLeft = x;
            Console.Write("X");

            Console.ReadLine();
            Console.WriteLine("Pozícióra írás vége");
            Console.Readline();

            while (true)
            {
                Console.Clear();
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write("X");
                Console.Write("X");

                Console.ReadKey();
                switch (Console.ReadKey());
                {
                    case ConsoleKey.LeftArrow;
                        x--;
                        break;
                    case ConsoleKey.RightArrow;
                        x++;
                        break;
                    case ConsoleKey.UpArrow;
                        y--;
                        break;
                    case ConsoleKey.DownArrow;
                        y++;
                        break;
                    default:

                        break;
                }
            }


        }
    }
}