
public class Word {
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHiddenWord()
    {
        return _isHidden;
    }

    public string GetRenderedText()
    {
        string hiddenText = "";
        foreach (char c in _text)
        {
            hiddenText += "_";
        }
        return hiddenText;
    }


}

