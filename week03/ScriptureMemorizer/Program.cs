using System;

class Program
{
    static void Main(string[] args)
    {
        // Create reference
        Reference reference = new Reference("John", 3, 16);

        // Scripture text
        string text = "For God so loved the world that he gave his one and only Son, " +
                      "that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, text);

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(); // hide words each enter
        }

        Console.WriteLine("\nAll words are hidden. Program ended.");
    }
}
