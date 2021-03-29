using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator
{
    public class CalculatorModel
    {
        public CalculatorModel()
        {
            
        }

        public object Calculate(int operand1, int operand2, char operation)
        {
            int oper1 = operand1;
            int oper2 = operand2;
            char oper = operation;
            int op = new int();
            
            switch (oper)
            {
                case '+':
                    op = Plus(oper1, oper2);
                    break;

                case '-':
                    op = Minus(oper1, oper2);
                    break;

                case '*':
                    op = Multiply(oper1, oper2);
                    break;

                case '/':
                    op = Divide(oper1, oper2);
                    break;
            }
            return op;
        }

        #region

        private int Plus(int operand1, int operand2)
        {
            int oper1 = operand1;
            int oper2 = operand2;
            int sum = oper1 + oper2;
            return sum;
        }

        private int Minus(int operand1, int operand2)
        {
            int oper1 = operand1;
            int oper2 = operand2;
            int difference = oper1 - oper2;
            return difference;
        }

        private int Multiply(int operand1, int operand2)
        {
            int oper1 = operand1;
            int oper2 = operand2;
            int mult = oper1 * oper2;
            return mult;
        }

        private int Divide(int operand1, int operand2)
        {
            int oper1 = operand1;
            int oper2 = operand2;
            int div = new int();
            if (oper2 != 0)
            { 
                div = oper1 / oper2;
                
            }
            else
            {
                MessageBox.Show("На нуль делить нельзя!");
            }
            return div;
        }
        #endregion
    }
}
