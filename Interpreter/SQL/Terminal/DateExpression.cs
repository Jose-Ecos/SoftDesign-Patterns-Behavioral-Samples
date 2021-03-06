namespace Interpreter.SQL.Terminal
{
    using System;

    public class DateExpression : LiteralExpression
    {

        public DateExpression(string literal) : base(literal)
        {
        }

        public override object Interpret(Context context)
        {
            try
            {
                DateTime date = DateTime.ParseExact(Literal, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                return date;
            }
            catch (Exception e)
            {
                throw new InterpreteException("Invalid date format '" + Literal + "', " + e.ToString());
            }
        }

        public override string ToString()
        {
            return "'" + Literal + "'";
        }
    }
}