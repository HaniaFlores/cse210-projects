class Word {
    //Member Variable
    private string _word;
    private bool _isHidden;

    //Constructors
    public Word(string word) {
        _word = word;
        _isHidden = false;
    }
    public Word(string word, bool status) {
        _word = word;
        _isHidden = status;
    }

    //Behaviors
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
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
        return _word;
    }

}