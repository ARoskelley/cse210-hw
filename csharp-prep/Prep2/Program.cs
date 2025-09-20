using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade?");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);
        string letter = "";

        if (grade > 90 || grade == 90)
        {
            letter = "A";
        }
        else if (grade > 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade > 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade > 60 && grade < 70)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your have an {letter}");

        if (grade > 70 || grade == 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time ):");
        }

    }
}