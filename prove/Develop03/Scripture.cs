class Scripture
{
    //Member Variables
    private Reference _reference;
    private List<Word> _words;
    private int _hiddenWordsCount;

    //Constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        //Initiates and creates the list of words.
        _words = new List<Word>();
        string[] splitText = text.Split(" ");
        foreach(string word in splitText) {
            _words.Add(new Word(word));
        }

    }

    //Behaviors
    public void HideWords()
    {
        Random random = new Random();
        int wordIndex = random.Next(_words.Count);
        if(!_words[wordIndex].IsHidden())
        {
            _words[wordIndex].Hide();
            _hiddenWordsCount++;
        }
    }

    public string GetRenderedText()
    {
        string renderedText = _reference.GetReferenceString() + "\n";
        foreach(Word word in _words)
        {
            renderedText += word.GetRenderedText() + " ";
        }
        return renderedText;
    }

    public bool IsCompletelyHidden()
    {
        return _hiddenWordsCount == _words.Count;
    }
}