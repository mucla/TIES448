# Hassembler project
Compiler for Haskell-like language implemented for the University of Jyväskylä course TIES448 Kääntäjätekniikka (Compiler technology)

Authors
============
Milla Koivuniemi

Rami Pasanen

Jose Saarimaa

Roles
============
Rami: C# expert, Version control, Visitor class design

Jose: ANTLR4/grammar, Target language 

Milla: Testing, Haskell guru


Most of coding was done as group work.

Tool requirements 
=============
- .NET core (v. 2.1 or newer)
- Visual Studio 2017 / Visual Studio code

To compile
============
In project directory, run command:
> dotnet build

Description
===========
Source language: Simplified Haskell

Host language: C#

Target language: WebAssembly

Properties (as of 5.2.2019):
- Interpreter (No compiler yet)
- Arithmetic operations (+,-,*,/)
- Line comments (denoted by --)
- Parenthesized expressions
- Types: 
  * positive integers
  * booleans (True, False)
- Functions/binding
  * with and without parameters
- Condition statements (if then else)
- Recursion
- Simple static type checking

Example of source language syntax:

f = 1+2*3

g = f + 1

h a = if a < 10 then h (a+1) else a 


Tests
===========

Unit tests for the interpreter are located in the folder HassemblerTests. 

Tests for compiler are located in the folder Hassembler/tests.

A table of tests (test_plan.pdf) is located in Documents.

Known deficiencies
===========

The interpreter/compiler has the following deficiencies. Tests for these deficiencies exist. 

- Due to ANTLR's capability to flexibly recover from syntax errors, some expressions (with addition or subtraction) that should result in a syntax error and an exception, will be parsed and interpreted. For example, f = 1++2 results in f == 1 and f = -2-2 results in f == -4
- whitespace around line breaks cause parsing errors
