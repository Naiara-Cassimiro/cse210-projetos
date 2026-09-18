public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] palavras = text.Split(' ');

        foreach (string palavra in palavras)
        {
            _words.Add(new Word(palavra));
        }
    }

    public string GetDisplayText()
    {
        string texto = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            texto += word.GetDisplayText() + " ";
        }

        return texto;
    }

    public bool IsCompletelyHidden()
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

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int quantidade = Math.Min(numberToHide, visibleWords.Count);
        Random random = new Random();

        for (int i = 0; i < quantidade; i++)
        {
            int indice = random.Next(visibleWords.Count);

            visibleWords[indice].Hide();
            visibleWords.RemoveAt(indice);
        }
    }
}