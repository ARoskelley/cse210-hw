using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int close = 1;
        string answer;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers. Type 0 when finished");

        while (close != 0)
        {
            Console.WriteLine("Enter a number:");
            answer = Console.ReadLine();
            close = int.Parse(answer);
            if (close != 0)
            {
                numbers.Add(close);
            }
            
        }

        int sum = Sum(numbers);
        float ave = Average(numbers);
        int lar = Largest(numbers);

        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {ave}");
        Console.WriteLine($"The largest number is: {lar}");
    }

    static int Sum(List<int> numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    static float Average(List<int> numbers)
    {
        float ave = 0;
        int index = 0;

        foreach (int number in numbers)
        {
            ave += number;
            index += 1;
        }

        ave /= index;

        return ave;
    }
    
    static int Largest(List<int> numbers) {
        int lar = 0;

        foreach (int number in numbers)
        {
            if (number > lar)
            {
                lar = number;
            }
        }

        return lar;
    }
}