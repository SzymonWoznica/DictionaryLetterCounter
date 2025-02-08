using HtmlAgilityPack;

namespace DictionaryLetterCounter
{
    public class WordsCollector
    {
        private readonly HttpClient _client;
        private readonly string url = "https://sjp.pl/sl/growe/?p=";
        private readonly List<char> letters = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'y', 'z' };
        private readonly DictionaryFileHandler dictionaryFileHandler = new DictionaryFileHandler();

        public WordsCollector(HttpClient httpClient)
        {
            _client = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<List<string>> GetWordsToList()
        {
            if (!dictionaryFileHandler.IsWordsCollectionFileExist())
                await SaveDictionaryToFileAsync();

            return dictionaryFileHandler.GetAllWordsFromFile();
        }

        private async Task SaveDictionaryToFileAsync()
        {
            List<string> foundWordsList = await GetAllWordsFromSourceAsync();
            dictionaryFileHandler.SaveToFile(foundWordsList);
        }

        private async Task<List<string>> GetAllWordsFromSourceAsync()
        {
            List<string> foundWordsList = new List<string>();

            try
            {
                foreach (char letter in letters)
                {
                    string fullUrl = url + letter;

                    var html = await GetHtml(fullUrl);

                    HtmlDocument htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(html);

                    var nodes = htmlDocument.DocumentNode.SelectNodes("//div[@style[contains(., 'text-transform: uppercase')]]//a");

                    if (nodes != null)
                    {
                        foreach (var node in nodes)
                        {
                            string word = node.InnerText.Trim().ToLower();
                            foundWordsList.Add(word);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while collecting words from SJP. Details: {ex}");
            }

            return foundWordsList;
        }

        private async Task<string> GetHtml(string url)
        {
            HtmlHttp tc = new HtmlHttp(_client);
            var html = await tc.GetHtmlAsStringAsync(url);

            return html;
        }
    }
}

