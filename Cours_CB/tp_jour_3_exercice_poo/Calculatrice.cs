using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_jour_3_exercice_poo
{
    public class Calculatrice
    {
        public int Add(int numberOne, int numberTwo)
        {
            return (numberOne + numberTwo);
        }

        public int Substract(int numberOne, int numberTwo)
        {
            return (numberOne - numberTwo);
        }

        public int Multiply(int numberOne, int numberTwo)
        {
            return (numberOne * numberTwo);
        }

        public int Divide(int numberOne, int numberTwo)
        {
            return (numberOne / numberTwo);
        }
    }
}
