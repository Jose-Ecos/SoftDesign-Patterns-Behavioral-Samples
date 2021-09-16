namespace Interpreter.SQL.Terminal
{
    using System;

    public class TextExpression : LiteralExpression
    {

        public TextExpression(string Literal) : base(Literal)
        {
        }

        public override Object Interpret(Context Context)
        {
            return Literal;
        }

        public override string ToString()
        {
            return "'" + Literal + "'";
        }
    }
}
