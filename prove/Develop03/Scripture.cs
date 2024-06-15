public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string verseContent)
    {
        _reference = reference;
            _words = verseContent.Split(' ')
                                 .Select(word => new Word(word))
                                 .ToList();
    }

    // This method hides a specific number of unhidden words
    public void HideRandomWord(int count)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHiddenWord()).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(0, visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Remove the word from the list after hiding it
        }
    }

    // Check if all words are hidden
    public bool AreAllWordsHidden()
    {
        return _words.All(word => word.IsHiddenWord());
    }

    // This method constructs the text with hidden words replaced by underscores
    public string GetRenderedText()
    {
        return string.Join(" ", _words.Select(word => word.GetRenderedText()));
    }

    // This method clears the console and displays the scripture and reference
    public void ClearConsoleAndDisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(_reference.DisplayReference());
        Console.WriteLine(GetRenderedText());
    }
}
