using System;
using System.Collections.Generic;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader fileReader = new FileReader();

           string[] allWords = fileReader.GetWords("./TestText.txt");

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
