namespace Interpreter.SQL.Terminal
{
    using System;

    public class NumericExpression : LiteralExpression
    {
        private readonly Int64 Number;

        public NumericExpression(Int64 Number) : base(null)
        {
            this.Number = Number;
        }

        public override Object Interpret(Context context)
        {
            return Number;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
