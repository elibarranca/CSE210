public class Reference
{
    private string _book;
    private string _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructor 1 for single verse
    public Reference(string book, string chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse; //the same verse for start and end
    }

    // Constructor 2 for verse range
    public Reference(string book, string chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse; //different end verse
    }

    // Display the reference
    public string GetReferenceText()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}
