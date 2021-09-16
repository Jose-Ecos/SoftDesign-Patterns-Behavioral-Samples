namespace Interpreter.SQL.NonTerminal
{
    using System;
    using Interpreter.SQL.Terminal;

    public class FromExpression : AbstractSQLExpression
    {

        private LiteralExpression Table;

        public FromExpression(LiteralExpression from)
        {
            this.Table = from;
        }

        public object Interpret(Context context)
        {
            string tableName = Table.Interpret(context).ToString();
            if (!context.TableExist(tableName))
            {
                throw new InterpreteException("The table '" + tableName + "' not exist");
            }
            return null;
        }

        public override string ToString()
        {
            return "FROM " + Table.ToString();
        }
    }
}
