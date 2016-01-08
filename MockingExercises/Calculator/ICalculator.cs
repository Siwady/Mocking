using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingExercises.Calculator
{
    public interface ICalculator
    {
        int Result { set; get; }
        int Add(int firstNumber,int secondNumber);
    }
}
