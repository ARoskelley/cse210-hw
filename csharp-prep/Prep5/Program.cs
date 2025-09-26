using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();

        string userName = PromptUserName();
        int userNum = PromptUserNumber();

        int birthYear;
        PromptUserBirthYear(out birthYear);

        int squareNumber = SquareNumber(userNum);

        DisplayStuff(userName, birthYear, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        int number;

        Console.Write("Please enter your favorite number: ");
        number = int.Parse(Console.ReadLine());

        return number;
    }
    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter your birth year: ");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int product = number * number;
        return product;
    }

    static void DisplayStuff(string name, int year, int num)
    {
        int age = 2025 - year;

        Console.WriteLine($"{name}, the square of your number is {num}");
        Console.WriteLine($"{name}, you will turn {age} years old this year");
    }
}