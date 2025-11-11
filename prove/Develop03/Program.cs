using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        // Create a scripture reference
        Reference reference = new Reference("Proverbs", "3", 5, 6);

        // Create the scripture text
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths";

        // Create a scripture object
        Scripture scripture = new Scripture(text, reference);

        // Main loop
        while (true)
        {
            // Clear the console
            Console.Clear();

            // Display the scripture
            scripture.Display();

            // Check if all words are hidden
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are now hidden. Good job!");
                break;
            }

            // Prompt the user
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            // Check if user wants to quit
            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide some random words
            scripture.HideRandomWords();
        }
    }
}