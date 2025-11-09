class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    // Constructor
    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words
        string[] wordArray = text.Split(' ');

        // Create Word objects for each word
        foreach (string word in wordArray)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    
    public void Display()
    {
        // Show the reference
        Console.WriteLine(_reference.GetReferenceText());
        
        // Show each word
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        
        Console.WriteLine();
    }
    
    // Hide random words
    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = 3; // Hide 3 words at a time
        int hiddenCount = 0;
        
        while (hiddenCount < wordsToHide)
        {
            // Pick a random word
            int index = random.Next(_words.Count);
            
            // If it's not already hidden, hide it
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
            
            // Stop if all words are hidden
            if (AllWordsHidden())
            {
                break;
            }
        }
    }
    
    // Check if all words are hidden
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}