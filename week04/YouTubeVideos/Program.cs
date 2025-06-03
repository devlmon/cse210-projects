using System;

class Program
{
    static void Main(string[] args)
    {
        // Main class.
        // Create 4 Instances of the Video Class.
        Video video1 = new Video("How to cook", "Master Chef", 450, "Mario123|Love It!\nLuigi321|Thanks!\nGanon789|I've seen better");
        Video video2 = new Video("Mysteries of Venezuela", "Anonymous", 1250, "Link404|I want to go!\nNess503|Interesting.\nGiovanni|All lies...");
        Video video3 = new Video("24/7 Retro music", "RetroLover", 604713, "Red101|... Good...\nLucas333|Listening all day long!\nLockeFF6|Subscribed");
        // Create a list of videos.
        List<Video> videoList = new List<Video>();
        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);
        // Loop to display all video information.
        Console.WriteLine("Video List:");
        foreach (Video video in videoList)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}\nAuthor: {video.GetAuthor()}\nLength: {video.GetLengthInSeconds()} Seconds\nNumber of Comments: {video.GetNumberOfComments()}\n");

            Console.WriteLine($"{video.GetComments()}");
        }
    }
}