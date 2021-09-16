namespace Interpreter.SQL.Terminal
{       
    public class LiteralExpression
    {
        protected string Literal;

        public LiteralExpression(string literal)
        {
            this.Literal = literal;
        }

        public virtual object Interpret(Context context)
        {
            return Literal;
        }

        public override string ToString()
        {
            return Literal;
        }
    }
}
