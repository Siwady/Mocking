using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;
using MockingExercises.Calculator;

namespace Mocking.specs.Calculator_UnitTest.Spy
{
    class WhenGettingTheSumOfTwoNumbers
    {
        private static ICalculator _calculator;
        private static int _result;
        public Establish Context = () => _calculator = new CalculatorSpy();

        public Because Of = () => _result=_calculator.Add(1, 5);

        public It ShouldHadEnterToTheAddFunction = () => ((CalculatorSpy) _calculator).HasBeenCalled.ShouldEqual(true);
        public It ShouldReturnTheSum = () => _result.ShouldEqual(6);
    }
}
