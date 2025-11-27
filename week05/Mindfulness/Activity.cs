using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write("\nEnter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        Spinner(3);
    }

    public void End()
    {
        Console.WriteLine("\nGreat job! You completed the activity.");
        Console.WriteLine($"You spent {_duration} seconds on the {_name}.");
        Spinner(3);
    }

    public int GetDuration()
    {
        return _duration;
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void Spinner(int seconds)
    {
        string[] symbols = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(symbols[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % symbols.Length;
        }
    }

    public abstract void Run();
}
