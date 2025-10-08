using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    
    static void Main(string[] args)
    {
        bool run = true;

        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("If today were a flavor of gatorade, what would it be?");
        prompts.Add("Which cryptid do you identify with most today?");
        prompts.Add("What crime was most tempting today?");
        prompts.Add("Is hate speech still hate speech if you love saying it?");
        prompts.Add("Pickles or mayo?");

        while (run = true)
        {
            Entry myEntry = new Entry();
            Console.WriteLine("Welcome to your Journal. What would you like to do today?");
            Console.WriteLine("     - Write (press 1)");
            Console.WriteLine("     - Display (press 2)");
            Console.WriteLine("     - Save (press 3)");
            Console.WriteLine("     - Load (press 4)");
            Console.WriteLine("     - Quit (press 5)");

            string answer = Console.ReadLine();
            int response = int.Parse(answer);

            if (response == 1)
            {
                Random rnd = new Random();
                
                string instancePrompt = prompts[rnd.Next(0, 9)];

                myEntry._givenPrompt = instancePrompt;
                myEntry._entryDateTime = DateTime.Today;

                Console.Write($"{instancePrompt}: ");
                myEntry._entryText.Add() = Console.ReadLine();
            }
        }

    }
}