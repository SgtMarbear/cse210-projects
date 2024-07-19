public class Video {
    private string _title;
    private string _author;
    private string _length;

    public Video(string title, string author, string length) {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetTitle() {
        return _title;
    }

    public string GetAuthor() {
        return _author;
    }

    public string GetLength() {
        return _length;
    }
}
