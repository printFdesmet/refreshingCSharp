using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Frederik's Grade Book");
            
            while (true)
            {
                Console.WriteLine("enter a grade or enter 'q' to quit:\n");
                var input = Console.ReadLine();
                
                if (input == "q")
                {
                    break;
                }
                else
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
            }


            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low:N1}");
            Console.WriteLine($"The highest grade is {stats.High:N1}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

        }
    }
}
