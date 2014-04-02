using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anagram_Assignment
{
    class Program
    {
        public string text = "Op het kinderstoeltje zitten drie troetelkindjes. Deze troetelkindjes wilden graag een beetje pap. De moeder zei nee en vroeg om een wetsverklaring voor de walversterking.";

        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.text);
            program.searchAnagramsOfAWord();

            Console.ReadLine();
        }

        /* This method searches the anagrams of a word entered by the user.
         */
        public void searchAnagramsOfAWord()
        {
            TextSplitter textSplitter = new TextSplitter();
            AnagramFinder anagramFinder = new AnagramFinder();

            List<string> listOfWords2 = textSplitter.splitToLower(text);
            Console.WriteLine("\nEnter a word to search the anagrams of in the text and press 'Enter': ");
            string input = Console.ReadLine();
            input.ToLower();

            Regex regex = new Regex("^[A-Za-z]+$");

            if (regex.IsMatch(input))
            {
                anagramFinder.searchAnagrams(listOfWords2, input);
            }
            else
            {
                Console.WriteLine("Too many words were entered!");
            }

            searchAnagramsOfAWord();
        }
    }
}
