using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {

    //Ask user for grade percentage 

        Console.WriteLine("What is your grade percentage?");
        string answer = Console.ReadLine();

    //Change to integer
        
        int percent = int.Parse(answer);

        string letter = "";

    //determine letter grade from integer

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        //Determine if percent is passing
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Try again! You'll get there!");
        }
    }
}