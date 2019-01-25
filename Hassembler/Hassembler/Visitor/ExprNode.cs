﻿using System;
using System.Collections.Generic;

namespace Hassembler
{
    /// <summary>
    /// Base class for an expression node.
    /// </summary>
    abstract class ExprNode
    {
        public ExprNode(ExprNode parent, IEnv env)
        {
            Parent = parent;
            Env = env ?? throw new ArgumentNullException("env");
        }

        public ExprNode Parent { get; private set; }
        protected IEnv Env { get; private set; }

        public abstract Result GetValue();
    }

    /// <summary>
    /// Base class for an expression node that acts as a
    /// parent to other nodes.
    /// </summary>
    abstract class ParentNode : ExprNode
    {
        public ParentNode(ExprNode parent, IEnv env) : base(parent, env)
        {
        }

        public ExprNode Right { get; set; }
        public ExprNode Left { get; set; }
    }

    class ITENode : ExprNode
    {
        public ITENode(ExprNode parent, IEnv env) : base(parent, env)
        {
        }

        public ExprNode Condition { get; set; }
        public ExprNode ThenExpr { get; set; }
        public ExprNode ElseExpr { get; set; }

        public override Result GetValue() =>
            Condition.GetValue().GetResult<int>() > 0 
            ? ThenExpr.GetValue() : ElseExpr.GetValue();
    }

    /// <summary>
    /// An expression node that contains parentheses.
    /// TODO rename
    /// </summary>
    class ParNode : ExprNode
    {
        public ParNode(ExprNode parent, IEnv env) : base(parent, env)
        {
        }

        public ExprNode Follower { get; set; }

        public override Result GetValue()
        {
            return Follower.GetValue();
        }
    }

    /// <summary>
    /// An expression node that is an integer.
    /// </summary>
    class IntNode : ExprNode
    {
        public IntNode(ExprNode parent, IEnv env, int value) : base(parent, env)
        {
            Value = value;
        }

        public int Value { get; private set; }

        public override Result GetValue() => new Result(Value);
    }

    /// <summary>
    /// An expression node that refers to a function.
    /// </summary>
    class FunctionReferenceNode : ExprNode
    {
        public FunctionReferenceNode(ExprNode parent, IEnv env, string functionName) : base(parent, env)
        {
            FunctionName = functionName;
        }

        /// <summary>
        /// A list of parameter values to be delivered to the function,
        /// </summary>
        private List<ExprNode> parameterNodes = new List<ExprNode>();

        public string FunctionName { get; private set; }

        public void AddParameter(ExprNode paramNode)
        {
            parameterNodes.Add(paramNode);
        }

        public override Result GetValue()
        {
            List<object> parameters = new List<object>();
            parameterNodes.ForEach(p => parameters.Add(p.GetValue().GetResult<int>())); // TODO handle non-int types
            return Env.GetReferenceValue(FunctionName, parameters);
        }
    }

    /// <summary>
    /// An expression node that refers to a parameter of a function.
    /// </summary>
    class ParameterReferenceNode : ExprNode
    {
        public ParameterReferenceNode(ExprNode parent, IEnv env,
            string paramName, Function function) : base(parent, env)
        {
            ParameterName = paramName;
            Function = function;
        }

        public string ParameterName { get; private set; }
        public Function Function { get; private set; }

        public override Result GetValue()
        {
            return new Result(Env.GetParam(ParameterName));
        }
    }

    /// <summary>
    /// An expression node that is a sum or subtract operation.
    /// </summary>
    class SumNode : ParentNode
    {
        public SumNode(ExprNode parent, IEnv env, SumOperation operation) : base(parent, env)
        {
            Operation = operation;
        }

        public SumOperation Operation { get; private set; }

        public override Result GetValue()
        {
            switch (Operation)
            {
                case SumOperation.Sum:
                    return Left.GetValue() + Right.GetValue();
                default:
                case SumOperation.Substract:
                    return Left.GetValue() - Right.GetValue();
            }
        }
    }

    /// <summary>
    /// An expression node that is a multiplication or division operation.
    /// </summary>
    class MultNode : ParentNode
    {
        public MultNode(ExprNode parent, IEnv env, MultOperation operation) : base(parent, env)
        {
            Operation = operation;
        }

        public MultOperation Operation { get; private set; }

        public override Result GetValue()
        {
            switch (Operation)
            {
                case MultOperation.Multiply:
                    return Right.GetValue() * Left.GetValue();
                default:
                case MultOperation.Divide:
                    return Right.GetValue() / Left.GetValue();
            }
        }
    }
}
