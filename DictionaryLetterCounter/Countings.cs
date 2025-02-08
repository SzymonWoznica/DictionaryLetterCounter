namespace DictionaryLetterCounter
{
    public class Countings
    {
        public Dictionary<char, int> LetterCounters = new Dictionary<char, int>()
            {
                {'a',0 }, {'b', 0}, {'c',0},  {'d', 0}, {'e', 0}, {'f', 0 }, {'g', 0 }, {'h', 0 }, {'i', 0}, {'j', 0}, {'k', 0}, {'l', 0}, {'m', 0}, {'n', 0}, {'o', 0}, {'p', 0}, {'r', 0}, {'s', 0}, {'t', 0}, {'u', 0}, {'w', 0}, {'v', 0}, {'x', 0}, {'y', 0}, {'z', 0}, {'?', 0},
            };

        public Dictionary<char, int> FirstLetterCounter = new Dictionary<char, int>()
            {
                {'a',0 }, {'b', 0}, {'c',0},  {'d', 0}, {'e', 0}, {'f', 0 }, {'g', 0 }, {'h', 0 }, {'i', 0}, {'j', 0}, {'k', 0}, {'l', 0}, {'m', 0}, {'n', 0}, {'o', 0}, {'p', 0}, {'r', 0}, {'s', 0}, {'t', 0}, {'u', 0}, {'w', 0}, {'v', 0}, {'x', 0}, {'y', 0}, {'z', 0}, {'?', 0},
            };

        public List<char> LetterUnknown = new List<char>();


        public void ExecuteAllCounting(List<string> words)
        {
            CountLetter(words);
            CountFirstLetterInWord(words);
        }

        public void CountLetter(List<string> words)
        {

            foreach (string word in words)
            {
                foreach (char letter in word.ToLower())
                {
                    switch (letter)
                    {

                        case 'a':
                            LetterCounters['a']++;
                            break;

                        case 'b':
                            LetterCounters['b']++;
                            break;

                        case 'c':
                            LetterCounters['c']++;
                            break;

                        case 'd':
                            LetterCounters['d']++;
                            break;

                        case 'e':
                            LetterCounters['e']++;
                            break;

                        case 'f':
                            LetterCounters['f']++;
                            break;

                        case 'g':
                            LetterCounters['g']++;
                            break;

                        case 'h':
                            LetterCounters['h']++;
                            break;

                        case 'i':
                            LetterCounters['i']++;
                            break;

                        case 'j':
                            LetterCounters['j']++;
                            break;

                        case 'k':
                            LetterCounters['k']++;
                            break;

                        case 'l':
                            LetterCounters['l']++;
                            break;

                        case 'm':
                            LetterCounters['m']++;
                            break;

                        case 'n':
                            LetterCounters['n']++;
                            break;

                        case 'o':
                            LetterCounters['o']++;
                            break;

                        case 'p':
                            LetterCounters['p']++;
                            break;

                        case 'r':
                            LetterCounters['r']++;
                            break;

                        case 's':
                            LetterCounters['s']++;
                            break;

                        case 't':
                            LetterCounters['t']++;
                            break;

                        case 'u':
                            LetterCounters['u']++;
                            break;

                        case 'w':
                            LetterCounters['w']++;
                            break;

                        case 'v':
                            LetterCounters['v']++;
                            break;

                        case 'x':
                            LetterCounters['x']++;
                            break;

                        case 'y':
                            LetterCounters['y']++;
                            break;

                        case 'z':
                            LetterCounters['z']++;
                            break;

                        default:
                            LetterCounters['?']++;
                            LetterUnknown.Add(letter);
                            break;
                    }
                }
            }

        }

        public void CountFirstLetterInWord(List<string> words)
        {
            foreach (string word in words)
            {
                char letter = word.ToLower()[0];
                switch (letter)
                {
                    case 'a':
                        FirstLetterCounter['a']++;
                        break;

                    case 'b':
                        FirstLetterCounter['b']++;
                        break;

                    case 'c':
                        FirstLetterCounter['c']++;
                        break;

                    case 'd':
                        FirstLetterCounter['d']++;
                        break;

                    case 'e':
                        FirstLetterCounter['e']++;
                        break;

                    case 'f':
                        FirstLetterCounter['f']++;
                        break;

                    case 'g':
                        FirstLetterCounter['g']++;
                        break;

                    case 'h':
                        FirstLetterCounter['h']++;
                        break;

                    case 'i':
                        FirstLetterCounter['i']++;
                        break;

                    case 'j':
                        FirstLetterCounter['j']++;
                        break;

                    case 'k':
                        FirstLetterCounter['k']++;
                        break;

                    case 'l':
                        FirstLetterCounter['l']++;
                        break;

                    case 'm':
                        FirstLetterCounter['m']++;
                        break;

                    case 'n':
                        FirstLetterCounter['n']++;
                        break;

                    case 'o':
                        FirstLetterCounter['o']++;
                        break;

                    case 'p':
                        FirstLetterCounter['p']++;
                        break;

                    case 'r':
                        FirstLetterCounter['r']++;
                        break;

                    case 's':
                        FirstLetterCounter['s']++;
                        break;

                    case 't':
                        FirstLetterCounter['t']++;
                        break;

                    case 'u':
                        FirstLetterCounter['u']++;
                        break;

                    case 'w':
                        FirstLetterCounter['w']++;
                        break;

                    case 'v':
                        FirstLetterCounter['v']++;
                        break;

                    case 'x':
                        FirstLetterCounter['x']++;
                        break;

                    case 'y':
                        FirstLetterCounter['y']++;
                        break;

                    case 'z':
                        FirstLetterCounter['z']++;
                        break;

                    default:
                        FirstLetterCounter['?']++;
                        LetterUnknown.Add(letter);
                        break;

                }
            }
        }
    }
}