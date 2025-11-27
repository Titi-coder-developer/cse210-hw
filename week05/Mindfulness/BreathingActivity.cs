using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by guiding you through slow breathing.")
    { }

    public override void Run()
    {
        Start();
        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);
            elapsed += 3;
            if (elapsed >= duration) break;

            Console.WriteLine("Breathe out...");
            Countdown(3);
            elapsed += 3;
        }

        End();
    }
}
