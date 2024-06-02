
public class Scripture {
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }


    public void HideRandomWord(int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(0, _words.Count);
            _words[index].Hide();
        }
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(word => word.IsHiddenWord());
    }

    // public string GetRenderedText()
    // {
    //     string renderedText = "";
    //     foreach (Word word in _words)
    //     {
    //         renderedText += word.GetRenderedText() + " ";
    //     }
    //     return renderedText.Trim();
    // }
    public string GetRenderedText()
    {
        string renderedText = "";
        foreach (Word word in _words)
        {
            renderedText += word.GetRenderedText() + " ";
        }
        return renderedText.Trim();
    }


    public void ClearConsoleAndDisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(_reference.displayReference());
        Console.WriteLine(GetRenderedText());
    }
}
 