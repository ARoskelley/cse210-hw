using System;
using System.Threading;

namespace MindfulnessApp
{
    abstract class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        protected Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void StartActivity()
        {
            Console.Clear();
            Console.WriteLine($"--- {_name} ---");
            Console.WriteLine(_description);
            Console.Write("\nEnter duration (in seconds): ");
            if (!int.TryParse(Console.ReadLine(), out _duration))
                _duration = 30;

            Console.WriteLine("\nPrepare to begin...");
            DotPulse(3);
            Console.Clear();

            Run();

            EndActivity();
        }

        protected abstract void Run();

        private void EndActivity()
        {
            Console.WriteLine("\nGood job!");
            DotPulse(2);
            Console.WriteLine($"You completed {_name} for {_duration} seconds.");
            DotPulse(3);
        }

        // Shared helper animations
        protected void DotPulse(int seconds)
        {
            string[] frames = { ".", "..", "...", ".." };
            DateTime end = DateTime.Now.AddSeconds(seconds);
            int i = 0;

            Console.WriteLine();
            while (DateTime.Now < end)
            {
                Console.Write($"\r{frames[i++ % frames.Length]}   ");
                Thread.Sleep(500);
            }
            Console.Write("\r    \r");
        }

        protected int GetDuration()
        {
            return _duration;
        }
    }
}
