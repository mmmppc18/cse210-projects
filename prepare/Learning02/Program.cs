using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        
        {
           Job job1 = new Job();
           job1._jobTitle = "Cart Pusher";
           job1._company = "Costco";
           job1._startYear = 2000;
           job1._endYear = 2010;
           job1.Display();

        }
    }
}