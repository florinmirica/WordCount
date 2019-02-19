using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word_counter;
namespace Word_counter.Tests
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
    }
}
