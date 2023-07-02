using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Calculator.Classes
{
    public abstract class MathOperation
    {
        protected double _firstName;
        protected double _secondNum;
       
        public abstract double Calculate();
    }

    
}
