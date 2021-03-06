﻿using System;
using System.Collections.Generic;
using System.IO;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace Hassembler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Haskell-- (Haskell-minus-minus) interpreter");

            string program;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Input program file path: >");
                string path = Console.ReadLine();

                if (!File.Exists(path))
                {
                    Console.WriteLine("Specified file does not exist!");
                    continue;
                }

                try
                {
                    program = File.ReadAllText(path);
                    break;
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Reading file failed! Returned message: " + ex.Message);
                }
            }

            Console.WriteLine("Parsing...");

            Hassembler hassembler = new Hassembler();
            hassembler.ParseCode(program);

            Console.WriteLine();
            Console.WriteLine("Found functions: ");
            hassembler.GetFunctions.ForEach(f => Console.WriteLine(f.Name));
            
            while (true)
            {
                Console.WriteLine();
                Console.Write("Input function name to evaluate it: > ");
                string name = Console.ReadLine();
                Console.WriteLine();

                string[] parts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int givenParamCount = parts.Length - 1;

                if (givenParamCount < 0)
                {
                    Console.WriteLine("No function name given!");
                    continue;
                }

                List<object> parameters = new List<object>();
                bool paramParseFailed = false;

                for (int i = 1; i < parts.Length; i++)
                {
                    if (int.TryParse(parts[i], out int paramValue))
                    {
                        parameters.Add(paramValue);
                    }
                    else if (parts[i] == "True")
                    {
                        parameters.Add(true);
                    }
                    else if (parts[i] == "False")
                    {
                        parameters.Add(false);
                    }
                    else
                    {
                        Console.WriteLine($"Failed to parse parameter #{(i - 1)} \"{parts[i]}\"!");
                        paramParseFailed = true;
                        break;
                    }
                }

                if (paramParseFailed)
                    continue;

                Console.WriteLine(hassembler.CallFunction(parts[0], parameters));
            }
        }
    }
}
