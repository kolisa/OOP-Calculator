using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator.Classes
{
    public class DivisionOperation : MathOperation
    {
        public DivisionOperation(double firstName, double secondNum)
        {
            _firstName = firstName;
            _secondNum = secondNum;
        }
        public override double Calculate()
        {
            return _firstName / _secondNum;
        }
    }
}
