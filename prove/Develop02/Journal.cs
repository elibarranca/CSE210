using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries = new List<Entry>();
    public Prompts promptGen = new Prompts();
    public void StartJournal()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome back to your Journal! Please choose an option: ");
            Console.WriteLine("");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Console.Write("Mood (1-5): ");
                string mood = Console.ReadLine();

                Entry e = new Entry();
                e.Date = DateTime.Now.ToShortDateString();
                e.Prompt = prompt;
                e.Response = response;
                e.Mood = mood;

                entries.Add(e);
                Console.WriteLine("Entry saved!\n");
            }
            else if (choice == "2")
            {
                for (int i = 0; i < entries.Count; i++)
                {
                    entries[i].Display();
                }
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                StreamWriter writer = new StreamWriter(file);
                foreach (Entry e in entries)
                {
                    writer.WriteLine(e.Date + "|" + e.Prompt + "|" + e.Response + "|" + e.Mood);
                }
                writer.Close();
                Console.WriteLine("File saved!\n");
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                if (File.Exists(file))
                {
                    string[] lines = File.ReadAllLines(file);
                    entries.Clear();

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split('|');
                        Entry e = new Entry();
                        e.Date = parts[0];
                        e.Prompt = parts[1];
                        e.Response = parts[2];
                        e.Mood = parts[3];
                        entries.Add(e);
                    }
                    Console.WriteLine("File loaded!\n");
                }
                else
                {
                    Console.WriteLine("File not found.\n");
                }
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("That’s not a valid option.\n");
            }
        }
    }
}