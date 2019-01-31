﻿using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hassembler
{
    /// <summary>
    /// Main class for the whole compiler. Handles
    /// the lexer, parser, and interpreter.
    /// </summary>
    public class Hassembler
    {
        private EvalVisitor visitor;

        /// <summary>
        /// Parses code.
        /// </summary>
        /// <param name="code">The code to parse.</param>
        public void ParseCode(string code)
        {
            ICharStream charStream = CharStreams.fromstring(code);
            HaskellmmLexer lexer = new HaskellmmLexer(charStream);
            HaskellmmParser parser = new HaskellmmParser(new CommonTokenStream(lexer));
            IParseTree tree = parser.prog();
            //Console.WriteLine(tree.ToStringTree().Replace("\\n", Environment.NewLine));
            visitor = new EvalVisitor();
            visitor.Visit(tree);
        }

        /// <summary>
        /// Returns a list of functions defined in the parsed code.
        /// </summary>
        public List<Function> GetFunctions => visitor.Functions;

        /// <summary>
        /// Calls and interprets a function.
        /// Returns a string that contains the function's return value.
        /// If an error is encountered, returns the error message.
        /// </summary>
        /// <param name="functionName">The name of the function to call.</param>
        /// <param name="parameters">The parameters to give to the function.</param>
        /// <returns></returns>
        public string CallFunction(string functionName, List<object> parameters)
        {
            Function f = visitor.Functions.Find(fnc => fnc.Name == functionName);

            if (f == null)
                return $"Function not found: {functionName}";

            var functionParams = f.Parameters;

            if (parameters.Count != functionParams.Count)
            {
                return $"Function {functionName} does not take {parameters.Count} " +
                    $"parameters; expected {functionParams.Count}";
            }
                
            for (int i = 0; i < functionParams.Count; i++)
            {
                visitor.Env.AddParam(functionParams[i].Name, parameters[i]);
            }

            string paramString = string.Join(' ', parameters);
            if (paramString.Length > 0)
                paramString += " ";

            string returnValue = $"{functionName} {paramString}= {f.StartNode.GetValue()}";
            visitor.Env.CleanupParams();
            return returnValue;
        }
    }
}