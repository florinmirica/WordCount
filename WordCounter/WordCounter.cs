using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    public class WordCounter
    {
        public string[] SplitSentence(string sentence)
        {
            // defines variable named separator of type array of characters(char[]) and initializes with vslues between curly brack.
            char[] separator = new char[] { ',', '!', ' ', '?', '.', ';', ':' };
            // define var named words of type array of strings because tha is what string.split returns. init with the value returned by sentence.split method
            // var words now contains all the words in sentence
            string[] words = sentence.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            // returns the variable containing the words in the string array
            return words;
        }

        public int CountOccurences(string[] words, string theWord)
        {
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (theWord.ToLower() == words[i].ToLower())
                {
                    count++;
                }
            }
            return count;
        }
    }
}
