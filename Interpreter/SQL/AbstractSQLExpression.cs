namespace Interpreter.SQL
{
    public interface AbstractSQLExpression
    {
        object Interpret(Context context);
    }
}
