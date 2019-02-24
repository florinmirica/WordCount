using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void SplitSentence_FiveWords_Test()
        {
            WordCounter wordCounter = new WordCounter();
            string sentence = "These are my five words";
            string[] result = wordCounter.SplitSentence(sentence);
            Assert.IsTrue(result.Length == 5);
            Assert.AreEqual(result.Length, 5);
        }

        [TestMethod]
        public void SplitSentence_Punctuation_Test()
        {
            WordCounter wordCounter = new WordCounter();
            string sentence = "These, are my, five words!!";
            string[] result = wordCounter.SplitSentence(sentence);
            Assert.IsTrue(result.Length == 5);
            Assert.AreEqual(result.Length, 5);
        }

        [TestMethod]
        public void SentenceNotEntered_Test()
        {
            WordCounter wordCounter = new WordCounter();
            string sentence = "";
            string[] result = wordCounter.SplitSentence(sentence);
            Assert.IsTrue(result.Length == 0);
            Assert.AreEqual(result.Length, 0);
        }

        [TestMethod]
        public void CountOccurrences_Test()
        {
            WordCounter wordCounter = new WordCounter();
            string[] words = new string[] { "pizza", "pizza", "pizza" };
            string theWord = "pizza";
            int result = wordCounter.CountOccurences(words, theWord);
            Assert.IsTrue(result == 3);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void CountOccurrences_Test2()
        {
            WordCounter wordCounter = new WordCounter();
            string[] words = new string[] { "cathedral" };
            string theWord = "cat";
            int result = wordCounter.CountOccurences(words, theWord);
            Assert.IsTrue(result == 0);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void CountOccurrences_Test3()
        {
            WordCounter wordCounter = new WordCounter();
            string[] words = new string[] { "pizza", "PiZza", "pizza" };
            string theWord = "pizza";
            int result = wordCounter.CountOccurences(words, theWord);
            Assert.IsTrue(result == 3);
            Assert.AreEqual(result, 3);
        }
    }
}
