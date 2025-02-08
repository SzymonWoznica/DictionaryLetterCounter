

using DictionaryLetterCounter;

namespace UnitTests
{
    public class CountingTests
    {
        [Fact]
        public void CountLetter_OK()
        {
            // Arrange
            Countings countings = new Countings();
            List<string> words = new List<string>() { "ABCDEFGHIJKLMNOPRSTUWVXYZ?" };
            Dictionary<char, int> expected = new Dictionary<char, int>()
            {
                {'a',1 }, {'b', 1}, {'c',1},  {'d', 1}, {'e', 1}, {'f', 1 }, {'g', 1 }, {'h', 1 }, {'i', 1}, {'j', 1}, {'k', 1}, {'l', 1}, {'m', 1}, {'n', 1}, {'o', 1}, {'p', 1}, {'r', 1}, {'s', 1}, {'t', 1}, {'u', 1}, {'w', 1}, {'v', 1}, {'x', 1}, {'y', 1}, {'z', 1}, {'?', 1},
            };


            // Act
            countings.CountLetter(words);

            // Assert
            foreach (var collection in expected)
            {
                Assert.Equal(collection.Value, countings.LetterCounters[collection.Key]);
            }
        }


        [Fact]
        public void CountFirstLetter_OK()
        {
            // Arrange
            Countings countings = new Countings();
            List<string> words = new List<string>() { "Agrafka", "Baran", "Cel", "Dom", "Era", "Film", "Gra", "Hak", "Inaczej", "Jak", "Kto", "Latarnia", "Motyl", "Noga", "Olbrzym", "Prosty", "Różny", "Stary", "Twój", "Uwaga", "Wygodny", "Volvo", "Xero", "York", "Zebra", "?Nieznany" };
            Dictionary<char, int> expected = new Dictionary<char, int>()
            {
                {'a',1 }, {'b', 1}, {'c',1},  {'d', 1}, {'e', 1}, {'f', 1 }, {'g', 1 }, {'h', 1 }, {'i', 1}, {'j', 1}, {'k', 1}, {'l', 1}, {'m', 1}, {'n', 1}, {'o', 1}, {'p', 1}, {'r', 1}, {'s', 1}, {'t', 1}, {'u', 1}, {'w', 1}, {'v', 1}, {'x', 1}, {'y', 1}, {'z', 1}, {'?', 1},
            };

            // Act
            countings.CountFirstLetterInWord(words);

            // Assert
            foreach (var collection in expected)
            {
                Assert.Equal(collection.Value, countings.FirstLetterCounter[collection.Key]);
            }
        }
    }
}