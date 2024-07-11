
public class Video {
    private string _title;
    private string _author;
    private string _length;
    private List<List<String>> videos = new List<List<String>>();

    public void AddVideo(string title, string author, string length, int videoCount) {
        videos.Add(new List<String>());
        videoCount = videoCount - 1;
        _title = title;
        _author = author;
        _length = length;
        videos[videoCount].Add(_title);
        videos[videoCount].Add(_author);
        videos[videoCount].Add(_length);
    }

    
    public void DisplayVidInfo(int vidNum)
    {
        vidNum = vidNum - 1;

        if (vidNum >= 0 && vidNum < videos.Count)
        {
            Console.WriteLine($"Video number {vidNum + 1}:");
            for (int j = 0; j < videos[vidNum].Count; j++)
            {
                Console.WriteLine($"Video Info {j + 1}: {videos[vidNum][j]}");
            }
        }
        else
        {
            Console.WriteLine($"Video number {vidNum + 1} does not exist.");
        }
    }
}