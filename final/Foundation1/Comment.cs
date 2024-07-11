
public class Comment {
    private string _commentText;
    private string _commenterName;
    
    private List<List<String>> comments = new List<List<String>>();

    public void AddComment(string text, string name, int videoNum) {
        _commentText = text;
        _commenterName = name;
        videoNum = videoNum - 1;
        comments[videoNum].Add(_commentText);
        comments[videoNum].Add(_commenterName);
    }

    public void AddSubsection() {
        comments.Add(new List<String>());
    }

    public void ReturnCommentNum(int videoNum) {
        videoNum = videoNum - 1;

        if (videoNum >= 0 && videoNum < comments.Count) {
            int commentCount = comments[videoNum].Count / 2;
            Console.WriteLine($"Number of comments: {commentCount}");

        }
        else {
            Console.WriteLine("Number of comments: 0");
        }

    }
    public void ListComments(int videoNum) {
        videoNum = videoNum - 1;

        if (videoNum >= 0 && videoNum < comments.Count) {
            for (int j = 0; j < comments[videoNum].Count; j += 2) {
                string comment = comments[videoNum][j];
                string commenter = comments[videoNum][j + 1];
                Console.WriteLine($"Comment {j / 2 + 1}: {comment} by {commenter}");
            }
        }


    }

}