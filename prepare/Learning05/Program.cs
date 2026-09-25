using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        int square = SquareNumber(number);
        int birthYear;
        PromptUserBirthYear(out birthYear);


        DisplayResult(name, square, birthYear);


        Console.WriteLine("Hello Learning05 World!");
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.WriteLine($"Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int root = number ^ 2;

        return root;
    }

    static void DisplayResult(string name, int root, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {root}.");
        Console.WriteLine($"{name}, you till turn {2026 - birthYear} years old this year.");
    }
}