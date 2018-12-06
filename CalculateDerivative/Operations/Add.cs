﻿//
//
//  Generated by StarUML(tm) C# Add-In
//
//  @ Project : Untitled
//  @ File Name : Operation.cs
//  @ Date : 2017. 06. 21.
//  @ Author : 
//
//


namespace CalculateDerivative.Operations
{
    public sealed class Add : Node
    {
        protected override int ArgumentNumber => 2;
        public Add(Node[] children):base(children)
        {
        }

        public override MathExpression Derivative(string variable)
        {
            var derivatives = Derivatives(variable);
            return new MathExpression(
                new Add(new[] {derivatives[0], derivatives[1]}));
        }
    }
}
