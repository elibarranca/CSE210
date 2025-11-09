class Word
{
    //I set the words in a private class encapsulated
    private string _word;
    //Set a bool to always check if it is hidden
    private bool _isHidden;
    
    // Start with the constructor
    public Word(string word)
    {
        //each word will be visible
        _word = word;
        _isHidden = false;
    }
    
    // This constructor will hide the word
    public void Hide()
    {
        _isHidden = true;
    }
    
    // Check if word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
    
    // Get the text displayed to disappear with each change of the condition to true
    public string GetDisplayText()
    {    
        if (_isHidden)
        {
            return new string('_', _word.Length); //put underscores instead of the words
        }
        else
        {
            return _word; //the word shows
        }
    }
}