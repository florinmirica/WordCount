using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        
        [Route("/wordcounter")]
        public ViewResult Index() { return View(); }

        [Route("/countwords")]
        public ActionResult Result(string word, string sentence)
        {
            WordCounter wordCounter = new WordCounter();
            string[] Words = wordCounter.SplitSentence(sentence);
            int number = wordCounter.CountOccurences(Words, word);
            CounterResult result = new CounterResult();
            result.SetResult(number);

            return View(result);

            //return string.Format("I found your word {0} time(s)", number);
        }
    }
}
