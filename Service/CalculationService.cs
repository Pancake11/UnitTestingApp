using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingApp.Service
{
    public class CalculationService
    {
        public int TheSumOfTwoNumbers(int num1, int num2) {
            return num1 + num2;
        }

        public int SubstractTwoNumbers(int num1, int num2) { 
            return num1 - num2;
        }
            
    }
}
