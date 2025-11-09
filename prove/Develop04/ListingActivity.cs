using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    class ListingActivity : Activity
    {
        private readonly List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
            : base("Listing Activity",
                   "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        protected override void Run()
        {
            int duration = GetDuration();
            Random rand = new Random();

            Console.WriteLine();
            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");

            Console.WriteLine("\nYou may begin in: ");
            Countdown(3);
            Console.WriteLine();

            // Start the timed listing session
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            int count = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string? response = Console.ReadLine();

                // If user just presses enter with no input, ignore it
                if (!string.IsNullOrWhiteSpace(response))
                    count++;
            }

            Console.WriteLine($"\nYou listed {count} items!");
            DotPulse(3);
        }

        private void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"\r{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
