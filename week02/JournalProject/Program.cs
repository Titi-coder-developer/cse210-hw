using System;

class Program
{
    public static string ReadInput()
    {
        string? input = Console.ReadLine();
        return input ?? "";
    }

    static void Main(string[] args)
    {
        Journal journal = new Journal();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string input = ReadInput();
            if (int.TryParse(input, out choice) == false)
            {
                choice = 0;
            }

            if (choice == 1)
            {
                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();

                Console.Write("Enter prompt: ");
                entry._promptText = ReadInput();

                Console.Write("Enter entry text: ");
                entry._entryText = ReadInput();

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Filename: ");
                string filename = ReadInput();
                journal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Filename: ");
                string filename = ReadInput();
                journal.LoadFromFile(filename);
            }
        }
    }
}
