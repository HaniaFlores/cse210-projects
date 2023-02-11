class Scripture
{
    //Member Variables
    private Reference _reference;
    private List<Word> _words;

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
        //randomly select only those words that are not already hidden.
        Word wordToHide = _words[random.Next(0, _words.Count)];
        while (wordToHide.IsHidden())
        {
            wordToHide = _words[random.Next(0, _words.Count)];
        }
        wordToHide.Hide();
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
        return _words.All(word => word.IsHidden());
    }
}