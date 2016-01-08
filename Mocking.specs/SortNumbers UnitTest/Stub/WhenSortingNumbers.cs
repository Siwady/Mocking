using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;
using MockingExercises.SortNumbers;

namespace Mocking.specs.SortNumbers_UnitTest.Stub
{
    class WhenSortingNumbers
    {
        private static IRandomNumbers _random;
        private static Sort _sort;
        private static List<int> _result; 
        public Establish Context = () =>
        {
            _random=new StubRandomNumbers();
            _sort=new Sort();
        };

        public Because Of = () => _result=_sort.SortNumbers(_random.GetRandomNumbers(5));

        public It ShouldReturnASortedList = () => _result.ShouldEqual(new List<int>(){1,2,5,7,9});
    }
}
