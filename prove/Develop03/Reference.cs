class Reference
{
    //Member Variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    //Setters and Getters
    public string GetBook() { return _book; }
    public int GetChapter() { return _chapter; }
    public int GetVerse() { return _verse; }
    public int GetEndVerse() { return _endVerse; }

    //Method
    public string GetReferenceString()
    {
        if(_endVerse == _verse) {
            return _book + " " + _chapter + ":" + _verse;
        } else {
            return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
        }
    }
}