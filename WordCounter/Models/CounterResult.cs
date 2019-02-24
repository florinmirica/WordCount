using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordCounter.Models
{
    public class CounterResult
    {
        private int _result;

        public int GetResult()
        {
            return _result;
        }

        public void SetResult(int result)
        {
            _result = result;
        }
    }
}
