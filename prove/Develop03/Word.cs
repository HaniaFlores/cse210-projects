class Word {
    //Member Variable
    private string _word;
    private bool _isHidden;

    //Constructors
    public Word(string word) {
        _word = word;
        _isHidden = false;
    }

    //Behaviors
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetRenderedText()
    {
        if(_isHidden)
        {
            return "___";
        }
        else { return _word; }
    }
}