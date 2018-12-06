using System;
using System.Collections.Generic;
using CalculateDerivative.Operations;

namespace CalculateDerivative
{
    public static class Derivative
    {
        public static MathExpression CalculateDerivative(MathExpression exp, string variableName) =>
            exp.Root.Derivative(variableName);
    }
}
