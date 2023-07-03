using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator.Classes
{
    public class MultiplicationOperation : MathOperation
    {
        public MultiplicationOperation(double firstName, double secondNum)
        {
            _firstName = firstName;
            _secondNum = secondNum;
        }
        public override double Calculate()
        {
            return (_firstName * _secondNum);
        }
    }
}
