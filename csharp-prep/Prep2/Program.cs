using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        int percentage = int.Parse(valueFromUser);

        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;

        string letter = "";

        if (percentage >= a)
        {
            letter = ("A");
        }
        else if (percentage >= b)
        {
            letter = ("B");
        }
        else if (percentage >= c)
        {
            letter = ("C");
        }
        else if (percentage >= d)
        {
            letter = ("D");
        }
        else
        {
            letter = ("F");
        }
            
            Console.WriteLine($"Your grade is a '{letter}'."); 

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass. Don't give up! Try again!");
        }
    }
}
