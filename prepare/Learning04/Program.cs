using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create new list
        List<int> numbers = new List<int>();
        int newNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.WriteLine("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());
            numbers.Add(newNumber);
        }
        while (newNumber != 0);

        // add the sum of the number list

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}.");


        //Return the average of the numbers on the list
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is {average}.");
        

    }



}