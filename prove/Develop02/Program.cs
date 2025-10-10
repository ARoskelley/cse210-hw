using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        Journal myJournal = new Journal();

        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "If today were a flavor of Gatorade, what would it be?",
            "Which cryptid do you identify with most today?",
            "What crime was most tempting today?",
            "Is hate speech still hate speech if you love saying it?",
            "Pickles or mayo?"
        };

        while (run)
        {
            Console.WriteLine("\nWelcome to your Journal! What would you like to do?");
            Console.WriteLine("1 - Write");
            Console.WriteLine("2 - Display");
            Console.WriteLine("3 - Save");
            Console.WriteLine("4 - Load");
            Console.WriteLine("5 - Quit");
            Console.Write("Enter your choice: ");

            string answer = Console.ReadLine();
            if (!int.TryParse(answer, out int response))
            {
                Console.WriteLine("Invalid input. Please enter a number 1–5.\n");
                continue;
            }

            if (response == 1)
            {
                Entry myEntry = new Entry();

                Console.Write("What is the date? ");
                myEntry._entryDateTime = Console.ReadLine();

                bool addMore = true;
                Random rnd = new Random();

                while (addMore)
                {
                    string instancePrompt = prompts[rnd.Next(prompts.Count)];
                    Console.WriteLine($"\n{instancePrompt}");
                    Console.WriteLine("Write your response below. (Press ENTER on an empty line to finish this prompt):");

                    List<string> currentResponse = new List<string>();
                    while (true)
                    {
                        string line = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(line)) break;
                        currentResponse.Add(line);
                    }

                    string combined = $"{instancePrompt}\n{string.Join("\n", currentResponse)}";
                    myEntry._entryText.Add(combined);

                    Console.Write("\nWould you like to answer another prompt? (y/n): ");
                    string choice = Console.ReadLine().Trim().ToLower();
                    if (choice != "y") addMore = false;
                }

                myJournal.AppendEntry(myEntry);
                Console.WriteLine("\nEntry added successfully!\n");
            }

            else if (response == 2)
            {
                myJournal.Display();
            }

            else if (response == 3)
            {
                Console.Write("Enter filename to save (e.g. journal.txt): ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }

            else if (response == 4)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }

            else if (response == 5)
            {
                Console.WriteLine("Thanks for writing today!");
                run = false;
            }

            else
            {
                Console.WriteLine("Invalid choice, please try again.\n");
            }
        }
    }
}
