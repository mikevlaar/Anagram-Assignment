using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram_Assignment
{
    class TextSplitter
    {
        /* This method splits the given text to a List with words in lowercase.
         * @param text :The text to split.
         * @return List<String> :Returns list of strings containing the splitted words.
         */
        public List<String> splitToLower(string text)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', ';', '?', '!' };
            List<String> words = text.ToLower().Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries).ToList<String>();

            return words;
        }
    }
}
