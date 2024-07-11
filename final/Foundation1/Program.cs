using System;

class Program
{
    static void Main(string[] args)
    {
        Video newVideo = new Video();
        Comment newComment = new Comment();
        newVideo.AddVideo("Learn Adobe Illustrator in 5 Min", "Envato Tuts", "300", 1);
        newComment.AddSubsection();
        newComment.AddComment("So useful!", "Martha", 1);
        newComment.AddComment("Wow! Illustrator is so cool!", "Will", 1);
        newComment.AddComment("You explain this topic so well!", "Damien", 1);
        newVideo.AddVideo("I am not who I was", "Marianne", "135", 2);
        newComment.AddSubsection();
        newComment.AddComment("This is so beautiful!", "Hayden", 2);
        newComment.AddComment("Such a vibe!", "Ann", 2);
        newComment.AddComment("Lovely as always!", "Jane", 2);
        newVideo.AddVideo("Glitter Bomb 6.0", "Mark Rober", "1225", 3);
        newComment.AddSubsection();
        newComment.AddComment("This is hilarious!", "Aiden", 3);
        newComment.AddComment("I wish this would never end", "Mitch", 3);
        newComment.AddComment("Best EVER!!", "Kate", 3);

        for (int i = 0; i < 3; i++) {
            Console.WriteLine();
            newVideo.DisplayVidInfo(i + 1);
            newComment.ReturnCommentNum(i + 1);
            newComment.ListComments(i + 1);
        }


    }
}