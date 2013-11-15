using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceParser
{
    public static class NiceCalculator
    {
        public static int Evaluate(string expression)
        {
            var firstOpeningBracketPosition = expression.IndexOf('e');
            var lastClosingBracketPosition = expression.LastIndexOf('f');
            if (firstOpeningBracketPosition >= 0 && lastClosingBracketPosition >= 0)
            {
                var previousExpression = expression.Substring(0, firstOpeningBracketPosition);
                var subsequentExpression = expression.Substring(lastClosingBracketPosition + 1);
                var innerExpression = expression.Substring(firstOpeningBracketPosition + 1, lastClosingBracketPosition - firstOpeningBracketPosition-1);
                return Evaluate(previousExpression+Evaluate(innerExpression)+subsequentExpression);
            }
            else
            {
                return EvaluateExpressionWithoutBrackets(expression);
            }
        }

        private static int EvaluateExpressionWithoutBrackets(string expression)
        {
            var parts = expression.Split('a', 'b', 'c', 'd');
            int value;
            if (int.TryParse(parts[0], out value))
            {
                var position = value.ToString().Length;
                var operation = expression[position];
                foreach (var nextValue in parts.Skip(1).Select(x => int.Parse(x)))
                {
                    if (operation == 'a')
                    {
                        value += nextValue;
                    }
                    if (operation == 'b')
                    {
                        value -= nextValue;
                    }
                    if (operation == 'c')
                    {
                        value *= nextValue;
                    }
                    if (operation == 'd')
                    {
                        value /= nextValue;
                    }
                    position += 1 + nextValue.ToString().Length;
                    if (expression.Length > position)
                    {
                        operation = expression[position];
                    }
                }
            }
            else
            {
                throw new Exception("unable to parse initial value");
            }
            return value;
        }
    }
}
