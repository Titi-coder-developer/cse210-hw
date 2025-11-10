using System;
using System.Collections.Generic;
using System.IO;

// Represents a collection of journal entries
public class Journal
{
    private List<Entry> entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    // Display all journal entries
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
            return;
        }

        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    // Save all entries to a file
    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (var entry in entries)
        {
            // Use | as a separator
            writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
        }
        Console.WriteLine("Journal saved successfully.\n");
    }

    // Load entries from a file
    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                entries.Add(new Entry(parts[1], parts[2], parts[0]));
            }
        }
        Console.WriteLine("Journal loaded successfully.\n");
    }

    // Display a summary of the journal
    public void DisplaySummary()
    {
        Console.WriteLine($"You have {entries.Count} journal entries.\n");
    }
}
