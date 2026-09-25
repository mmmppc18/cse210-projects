using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = -1;
        while (guess != number)
        {

            Console.WriteLine("What is the magic number?");
            answer = int.Parse(Console.readline());

            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (number > compare)
            {
                Console.Write("Higher.");
            }
            else if (number < compare)
            {
                Console.Write("Lower.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }



}