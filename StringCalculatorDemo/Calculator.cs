using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorDemo
{
    public class Calculator
    {
        /// <summary>
        /// Calculate sum.dsadas asd
        /// </summary>
        /// <param name="expression">Digits to add as string.</param>
        /// <returns>Sum</returns>
        public int Add(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                return 0;

            int sum = 0;
            if (expression.Contains(","))
            {
                string[] digits = expression.Split(',');
                foreach (string digit in digits)
                {
                    sum += int.Parse(digit);
                }
            }
            else
            {
                sum = int.Parse(expression);
            }
            return sum;
        }
    }
}
