using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        //Console.Write("What is the magic number?");
        //string smart = Console.ReadLine();
        //int number = int.Parse(smart);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = -1;
        
        while (number != guess)
        {
            Console.Write("What is your guess?");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (number==guess)
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}