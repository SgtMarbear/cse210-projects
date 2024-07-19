using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        List<List<Comment>> comments = new List<List<Comment>>();

        videos.Add(new Video("Learn Adobe Illustrator in 5 Min", "Envato Tuts", "300"));
        comments.Add(new List<Comment>());
        comments[0].Add(new Comment("So useful!", "Martha"));
        comments[0].Add(new Comment("Wow! Illustrator is so cool!", "Will"));
        comments[0].Add(new Comment("You explain this topic so well!", "Damien"));

        videos.Add(new Video("I am not who I was", "Marianne", "135"));
        comments.Add(new List<Comment>());
        comments[1].Add(new Comment("This is so beautiful!", "Hayden"));
        comments[1].Add(new Comment("Such a vibe!", "Ann"));
        comments[1].Add(new Comment("Lovely as always!", "Jane"));

        videos.Add(new Video("Glitter Bomb 6.0", "Mark Rober", "1225"));
        comments.Add(new List<Comment>());
        comments[2].Add(new Comment("This is hilarious!", "Aiden"));
        comments[2].Add(new Comment("I wish this would never end", "Mitch"));
        comments[2].Add(new Comment("Best EVER!!", "Kate"));

        for (int i = 0; i < videos.Count; i++) {
            Console.WriteLine();
            Console.WriteLine($"Video number {i + 1}:");
            Console.WriteLine($"Video Info 1: {videos[i].GetTitle()} by {videos[i].GetAuthor()} ({videos[i].GetLength()}s)");
            Console.WriteLine($"Number of comments: {comments[i].Count}");

            for (int j = 0; j < comments[i].Count; j++) {
                Console.WriteLine($"Comment {j + 1}: {comments[i][j].GetCommentText()} by {comments[i][j].GetCommenterName()}");
            }
        }

    }
}