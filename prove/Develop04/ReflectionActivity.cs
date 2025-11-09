using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    class ReflectionActivity : Activity
    {
        private readonly List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private readonly List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectionActivity()
            : base("Reflection Activity",
                   "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
                   "This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
        }

        protected override void Run()
        {
            int duration = GetDuration();
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            Random rand = new Random();

            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");
            Console.WriteLine("\nWhen you have something in mind, press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");
            Console.WriteLine("You may begin in: ");
            Countdown(3);

            Console.Clear();

            while (DateTime.Now < endTime)
            {
                string question = _questions[rand.Next(_questions.Count)];
                Console.WriteLine($"> {question}");
                DotPulse(3);
                Console.WriteLine();
            }
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
