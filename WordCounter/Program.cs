using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a word to be counted");
            string TheWord = Console.ReadLine();
            
            Console.WriteLine("Please write a sentence where the app should look for your word");
            string Sentence = Console.ReadLine();
            WordCounter wordCounter = new WordCounter();
            string[] Words = wordCounter.SplitSentence(Sentence);
            int number = wordCounter.CountOccurences(Words, TheWord);
            
            Console.WriteLine("I found your word {0} time(s)", number);
            Console.ReadLine(); 
        }
    }
}
