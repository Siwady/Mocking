using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockingExercises.Calculator;

namespace Mocking.specs.Calculator_UnitTest.Spy
{
    class CalculatorSpy:ICalculator
    {
        public bool HasBeenCalled = false;
        public int Result { get; set; }

        public int Add(int firstNumber, int secondNumber)
        {
            HasBeenCalled = true;
            return firstNumber + secondNumber;
        }
    }
}
