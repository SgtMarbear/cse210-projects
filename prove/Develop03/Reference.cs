public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;
    private string _verseContent;

    public Reference(string book, int chapter, int startVerse, string content)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _verseContent = content;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse, string content)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _verseContent = content;
    }

    public string DisplayReference()
    {
        if (_endVerse == null)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }

    public string VerseContent => _verseContent;
}
