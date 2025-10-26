using System;

public class Entry
{
    public string Date;
    public string Prompt;
    public string Response;
    public string Mood;

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Mood (1-5): {Mood}");
        Console.WriteLine();
    }
}

