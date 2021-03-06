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


using System;

namespace CalculateDerivative.Operations
{
    public sealed class Log : Node
    {
        protected override int ArgumentNumber => 1;

        public double Base { get;}
        public Log(Node[] children,double _base):base(children)
        {
            Base = _base;
        }

        public override MathExpression Derivative(string variable)
        {
            var derivatives = Derivatives(variable);
            return new MathExpression(new Multiply(new Node[]
            {
                new Divide(new Node[]
                {
                    new Constant(1),
                    new Multiply(new Node[]
                    {
                        Children[0],
                        new Log(new Node[] {new Constant(Base)}, Math.E)
                    })
                }),
                derivatives[0]
            }));
        }
    }
}
