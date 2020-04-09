using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WordCounter
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IReader reader = new UrlReader();
            string content;
            try
            {
                content = await reader.ReadContentAsync("https://raw.githubusercontent.com/SzlukaEszter/WordCounter/master/TestText.txt");
            }
            catch (CouldNotReadException e)
            {
                Console.WriteLine("Sorry, could not read: {0}", e.Message);
                return;
            }

            String[] allWords = GetWordsFromText(content);

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
            var counter = new Dictionary<string, int>();

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


        static void Valami(int i)
        {
            int? k = 5;
            k = null;

            int c = (int)k;
        }
    }
}
