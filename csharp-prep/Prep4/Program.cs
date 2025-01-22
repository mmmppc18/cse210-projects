using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int mathNumber = -1;
        int count = -1;

        while (mathNumber != 0)
        {
            Console.Write("Enter a number or enter 0 to quit: ");
            mathNumber = int.Parse(Console.ReadLine());

            if(mathNumber !=0)
            {
            numbers.Add(mathNumber);
            }
        }
        int add = 0;
        foreach (int number in numbers)
        {
            add += number;
        }

        Console.WriteLine($"The sum is: {add}");

        float average = ((float)add) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int high = numbers[0];

        foreach (int number in numbers)
        {
            if (number > high)
            {
                high = number;
            }
        }
        Console.WriteLine ($"the max is: {high}");
    }
}