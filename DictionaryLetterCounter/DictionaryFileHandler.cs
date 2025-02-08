namespace DictionaryLetterCounter
{
    public class DictionaryFileHandler
    {
        public readonly string FullPath = Configuration.fullPathToDict;

        public void SaveToFile(List<string> words)
        {
            using (StreamWriter file = new StreamWriter(FullPath, false))
            {
                foreach (string word in words)
                {
                    file.WriteLine(word);
                }
            }
        }

        public List<string> GetAllWordsFromFile() {
            return File.ReadAllLines(FullPath).ToList();
        }

        public bool IsWordsCollectionFileExist() {
            return File.Exists(FullPath);
        }
    }
}
