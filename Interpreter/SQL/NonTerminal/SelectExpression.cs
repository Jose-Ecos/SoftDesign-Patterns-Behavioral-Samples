namespace Interpreter.SQL.NonTerminal
{
    using System;
    using System.Collections.Generic;

    public class SelectExpression
    {

        private readonly TargetExpression Target;
        private readonly FromExpression From;
        private readonly WhereExpression Where;

        public SelectExpression(TargetExpression columns, FromExpression table, WhereExpression where)
        {
            this.Target = columns;
            this.From = table;
            this.Where = where;
        }

        public SelectExpression(TargetExpression columns, FromExpression table)
        {
            this.Target = columns;
            this.From = table;
            this.Where = new WhereExpression(null);
        }

        public List<Object[]> Interpret(Context context)
        {
            From.Interpret(context);
            Where.Interpret(context);
            Target.Interpret(context);
            return context.GetResultArray();
        }

        public override string ToString()
        {
            return "SELECT " + Target.ToString() + " " + From.ToString() + " " + Where.ToString();
        }
    }
}
