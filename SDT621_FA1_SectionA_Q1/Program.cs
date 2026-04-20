using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Get student name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        double mark1 = GetMark("Subject 1");
        double mark2 = GetMark("Subject 2");
        double mark3 = GetMark("Subject 3");

        //Total is the 3 marks together
        double total = mark1 + mark2 + mark3;
        double average = total / 3;
        string result = average >= 50 ? "PASS" : "FAIL";

        DisplayInfo(name, total, average, result);
    }




    static void DisplayInfo(string name, double total, double average, string result)
    {
        Console.WriteLine("==== STUDENT RESULTS ====");
        Console.WriteLine($"Student name: {name}");
        Console.WriteLine($"Total marks: {total}");
        Console.WriteLine($"Average marks: {average:F1}");
        Console.WriteLine($"Result: {result}");
        Console.WriteLine($"Results issued on: {DateTime.Now: dd MMM yyyy HH:mm:ss}");
    }
    // Method to get the mark from user
    static double GetMark(string subject)
    {
        double mark;
        while (true)
        {
            Console.Write($"Enter mark for {subject}: ");
            if (double.TryParse(Console.ReadLine(), out mark))
                break;
            else
                Console.WriteLine("Invalid input....Please Enter a Number.");

        }

        return mark;

    }

   
}
