using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Reference reference = new Reference("Proverbs", 3, new List<int> { 5, 6 });

            List<Verse> verses = new List<Verse>
            {
                new Verse(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding."),
                new Verse(reference, "In all thy ways acknowledge him, and he shall direct thy paths.")
            };

            Scripture scripture = new Scripture(reference, verses);

            Console.Clear();
            scripture.Display();

            while (true)
            {
                Console.WriteLine("\nPress ENTER to hide more words or type 'quit' to exit:");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "quit")
                    break;

                Console.Clear();
                scripture.HideMoreWords(3);
                scripture.Display();

                if (scripture.FullyHidden())
                {
                    Console.WriteLine("\nAll words are hidden. Good job!");
                    break;
                }
            }
        }
    }

