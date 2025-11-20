using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // PART A: Create the list to hold all videos
        List<Video> videos = new List<Video>();

        // Part B: Create the first video
        Video video1 = new Video();
        video1._title = "Cooking Jollof Rice";
        video1._author = "Kitchen Master";
        video1._length = 480;

        // Part C: Add comment to the first video
        video1._comments.Add(new Comment { _name = "Tina", _text = "Nice recipe!" });
        video1._comments.Add(new Comment { _name = "Wisdom", _text = "I will try this." });
        video1._comments.Add(new Comment { _name = "John", _text = "Looks delicious" });

        // Part D: Add first video of the list
        videos.Add(video1);

        // Part E: Repeat for more videos
        //Example
        Video video2 = new Video();
        video2._title = "How to fix a Laptop";
        video2._author = "NIIT Tech";
        video2._length = 720;

        video2._comments.Add(new Comment { _name = "Chidi", _text = "Very helpful tutorial" });
        video2._comments.Add(new Comment { _name = "Chizzy", _text = "My laptop is working now." });
        video2._comments.Add(new Comment { _name = "Mike", _text = "Please make more videos." });

        videos.Add(video2);

        // Display all the videos

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v._title}");
            Console.WriteLine($"Author: {v._author}");
            Console.WriteLine($"Length: {v._length} seconds");
            Console.WriteLine($"Number of comments: {v.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in v._comments)
            {
                Console.WriteLine($" - {c._name}: {c._text}");
            }

            Console.WriteLine(); // empty line for spacing
        }


    }
}