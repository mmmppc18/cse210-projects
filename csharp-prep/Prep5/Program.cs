using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int favNum = PromptUserNumber();

        int squareFav = SquareNumber(favNum);

        DisplayResult(name, squareFav);


    }
    static void DisplayWelcome() 
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);

        return number;
    }
    static int SquareNumber(int number)
    {
        int answer = number*number;

        return answer;
    }

    static void DisplayResult(string name, int answer)
    {
        Console.WriteLine($"{name}, the square of your number is {answer}.");

    }
}