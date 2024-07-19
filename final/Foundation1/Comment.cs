public class Comment {
    private string _commentText;
    private string _commenterName;

    public Comment(string text, string name) {
        _commentText = text;
        _commenterName = name;
    }

    public string GetCommentText() {
        return _commentText;
    }

    public string GetCommenterName() {
        return _commenterName;
    }
}
