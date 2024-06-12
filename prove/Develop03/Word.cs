public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word by setting _isHidden to true
    public void Hide()
    {
        _isHidden = true;
    }

    // Check if the word is hidden
    public bool IsHiddenWord() => _isHidden;

    // This method returns the word with underscores if hidden, or the actual word if not
    public string GetRenderedText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}