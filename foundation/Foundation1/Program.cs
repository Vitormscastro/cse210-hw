using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("I got ADDICTED to Coding", "Kedrigern", 1193);
        video1.AddComment(new Comment("@ariagerber", "This game is really cool for learning basics of algorithms and data structures, you slowly progressing from simple 2d navigation and states to sorting and maze solving problems"));
        video1.AddComment(new Comment("@gametec_live", "The Farmer wasnt replaced, hes been promoted to software developer XD"));
        video1.AddComment(new Comment("@darkreaper4990", "Wish there was a game like bloons TD 6 but programming focused like this. It would be SOOOOO much fun"));
        _videos.Add(video1);

        Video video2 = new Video("Jim & Kevin being an UNDERRATED duo for 10 minutes straight - The Office US", "The Office", 642);
        video2.AddComment(new Comment("@Himothy108", "Been saying this. They’re the most realistic work friendship in early seasons fr act like coworkers would"));
        video2.AddComment(new Comment("@duarlop570", "Hi Angela-You need a HaircutBye Angela"));
        video2.AddComment(new Comment("@mathlearningss", "I love how Jim calls Kevin Kev"));
        _videos.Add(video2);

        Video video3 = new Video("The Office Cold Opens that brought everyone together - The Office US", "The Office", 1238);
        video3.AddComment(new Comment("@Shoaboi8", "My personal theory for Stanley not noticing anything, is the fact that he saw it and just didn’t care."));
        video3.AddComment(new Comment("@wyethpurkiss7393", "I love the rare moments when Jim and Dwight team up"));
        video3.AddComment(new Comment("@hnycks", "12:05 creed being upset at being disqualified for not even attempting it is my favorite creed moment"));
        _videos.Add(video3);

        foreach (var video in _videos)
        {
            Console.WriteLine(video.GetVideoInfo());
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}