using DictionaryLetterCounter;

public class Program
{
    private static readonly HttpClient _client = new HttpClient();

    public static async Task Main(string[] args)
    {
        DictionaryFileHandler dictionaryHandler = new DictionaryFileHandler();
        WordsCollector wordCollector = new WordsCollector(_client);

        List<string> allWords = await wordCollector.GetWordsToList();

        Countings counters = new Countings();
        counters.ExecuteAllCounting(allWords);

        // Display result
        DisplayWordCount(allWords);
        DisplayLetterOccurrences(counters.LetterCounters);
        DisplayFirstLetterOccurrences(counters.FirstLetterCounter);
    }

    // Display counter words in dictionary 
    private static void DisplayWordCount(List<string> allWords)
    {
        Console.WriteLine($"W słowniku znajduje się {allWords.Count} słów.\n");
    }

    // Display the number of occurrences of letters
    private static void DisplayLetterOccurrences(Dictionary<char, int> letterCounters)
    {
        Console.WriteLine("Ilość wystąpień danej litery: ");
        foreach (var dict in letterCounters)
        {
            Console.WriteLine($"{dict.Key} - {dict.Value}");
        }
        Console.WriteLine();
    }

    // Display the number of words beginning with a given letter
    private static void DisplayFirstLetterOccurrences(Dictionary<char, int> firstLetterCounters)
    {
        Console.WriteLine("Ilość słów rozpoczynających się na daną literę: ");
        foreach (var firstLetter in firstLetterCounters)
        {
            Console.WriteLine($"{firstLetter.Key} - {firstLetter.Value}");
        }
        Console.WriteLine();
    }
}
