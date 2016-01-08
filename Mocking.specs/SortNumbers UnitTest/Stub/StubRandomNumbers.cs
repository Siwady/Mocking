using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockingExercises.SortNumbers;

namespace Mocking.specs.SortNumbers_UnitTest.Stub
{
    class StubRandomNumbers:IRandomNumbers
    {
        public List<int> GetRandomNumbers(int amount)
        {
            return new List<int>(){1,7,2,9,5};
        }
    }
}
