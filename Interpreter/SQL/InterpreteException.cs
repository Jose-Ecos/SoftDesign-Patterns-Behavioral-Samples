namespace Interpreter.SQL
{
    using System;

    public class InterpreteException : Exception
    {
        public InterpreteException(String message) : base(message)
        {
        }
    }
}
