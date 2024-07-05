
public class Reference {
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;
    private string _verseContent;

    public Reference() {
        _book = "Proverbs";
        _chapter = 3;
        _startVerse = 5;
        _verseContent = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
    }
    public Reference(string book, int chapter, int verse, string content) {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _verseContent = content;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse, string content) {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _verseContent = content;
    }

    public string displayReference() {
        if (_endVerse == null) {
            return _book + " " + _chapter + ":" + _startVerse + " " + _verseContent;
        }
        else {
            return _book + " " + _chapter + ":" + _startVerse + "-" + _endVerse + " " + _verseContent;
        }
        
    }
    public string VerseContent
    {
        get { return _verseContent; }
    }

}
