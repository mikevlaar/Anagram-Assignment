using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram_Assignment
{
    class AnagramFinder
    {
        Dictionary<String, List<String>> anagrams;

        /* This method searches for all anagrams of the input in the given wordList.
         * @param wordList :The list of words to search through.
         * @param input :The word that is entered.
         */
        public void searchAnagrams(List<String> wordList, string input)
        {
            anagrams = new Dictionary<String, List<String>>();

            int i = wordList.Count - 1;
            string alfabeticalInput = sortStringByAlfabeticalOrder(input);

            while (wordList.Count != 0)
            {
                string key = sortStringByAlfabeticalOrder(wordList[i]);

                if(alfabeticalInput.Equals(key))
                {
                    addAnagramToDictionary(key, wordList[i]);
                }
                wordList.Remove(wordList[i]);

                i--;
            }

            printAnagrams(anagrams);
        }

        /* This method sorts the given word by alfabetical order.
         * @param word :The word to sort.
         * @return String :Returns a string that was arranged by alfabetical order.
         */
        private String sortStringByAlfabeticalOrder(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Sort<char>(chars);

            return new string(chars);
        }

        /* This method adds the anagram to the dictionary.
         * @param key :The key of the anagram to add to the dictionary.
         * @param word :The anagram to add to the dictionary.
         */
        private void addAnagramToDictionary(string key, string word)
        {
            if (!anagrams.ContainsKey(key))
            {
                anagrams.Add(key, new List<String>());
            }
            anagrams[key].Add(word);
        }

        /* This method prints each unique anagram.
         * @param anagrams :The dictionary containing all anagrams.
         */
        private void printAnagrams(Dictionary<String, List<String>> anagrams)
        {
            foreach (List<String> ana in anagrams.Values)
            {
                Console.WriteLine("\nNumber of Occurrences: " + ana.Count);
                Console.WriteLine("Unique values: ");
                List<String> duplicateFreeAna = ana.Distinct().ToList();
                for (int j = 0; j < duplicateFreeAna.Count; j++)
                {
                    Console.WriteLine(duplicateFreeAna[j]);
                }
            }
        }
    }
}
