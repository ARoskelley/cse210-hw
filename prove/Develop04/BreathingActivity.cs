using System;
using System.Threading;

namespace MindfulnessApp
{
    class BreathingActivity : Activity
    {
        public BreathingActivity()
            : base("Breathing Activity",
                   "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        protected override void Run()
        {
            int duration = GetDuration();
            int elapsed = 0;
            int breathDuration = 4; // seconds per inhale/exhale

            while (elapsed < duration)
            {
                Console.Write("Breathe in... ");
                Countdown(breathDuration);
                elapsed += breathDuration;

                if (elapsed >= duration) break;

                Console.Write("Breathe out... ");
                Countdown(breathDuration);
                elapsed += breathDuration;
            }
        }

        private void Countdown(int seconds)
        {
            int startLeft = Console.CursorLeft;
            for (int i = seconds; i > 0; i--)
            {
                Console.SetCursorPosition(startLeft, Console.CursorTop);
                Console.Write($"{i}   ");
                Thread.Sleep(1000);
            }

            // soft pacing between breaths
            DotPulse(2);
            Console.WriteLine();
        }
    }
}
