using System;
using System.Collections.Generic;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new UrlReader();

            string content = reader.ReadContent("https://raw.githubusercontent.com/SzlukaEszter/WordCounter/master/TestText.txt");

            string[] allWords = GetWordsFromText(content);

            Console.WriteLine("All words in file :");
            foreach (string word in allWords)
            {
                Console.WriteLine(word);
            }

            Dictionary<string, int> wordCounts = CountWords(allWords);
            Console.WriteLine("The count of words:");
            foreach (var keyValue in wordCounts)
            {
                Console.WriteLine("{0} : {1}", keyValue.Key, keyValue.Value);
            }

            Console.ReadKey();

        }

        private static string[] GetWordsFromText(string text)
        {
            string[] separators = { " ", ".", ",", "!", ":", ";", "-", "?", "(", ")", "{", "}", "[", "]", "\'", "\r\n", "\t" };
            string[] wordArr = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return wordArr;
        }

        static Dictionary<string, int> CountWords(string [] words) 
        {
            Dictionary<string, int> counter = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (counter.ContainsKey(word))
                {
                    counter[word] += 1;
                }
                else
                {
                    counter.Add(word, 1);
                }

            }
            return counter;
        }
    }
}
