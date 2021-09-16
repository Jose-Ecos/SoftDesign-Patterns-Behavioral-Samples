namespace Interpreter
{    
    using System;
    using System.Collections.Generic;
    using Interpreter.SQL;
    using Interpreter.SQL.NonTerminal;
    using Interpreter.SQL.Terminal;

    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Syntactic Tree
            SelectExpression select = GetById();
            Console.WriteLine(select.ToString());
            Context context = new Context("C:/Files/Employee.xls");
            context.SetDateFormat("MM/dd/yyyy");
            try
            {
                List<Object[]> output = select.Interpret(context);
                foreach (Object[] obj in output)
                {
                    Console.WriteLine(string.Join(" ", obj));
                }
            }
            catch (InterpreteException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                context.Destroy();
            }
        }

        public static SelectExpression GetById()
        {
            SelectExpression select = new SelectExpression(
                    new TargetExpression(
                            new LiteralExpression("FIRST_NAME"),
                            new LiteralExpression("LAST_NAME")
                    ),
                    new FromExpression(
                            new LiteralExpression("EMPLOYEES")),
                    new WhereExpression(
                            new BooleanExpression(
                                    new LiteralExpression("ID"),
                                    new LiteralExpression("="),
                                    new NumericExpression(10)
                            )
                    )
            );
            return select;
        }

        public static SelectExpression FindByDate()
        {
            SelectExpression select = new SelectExpression(
                    new TargetExpression(
                            new LiteralExpression("ID"),
                            new LiteralExpression("BORN_DATE"),
                            new LiteralExpression("DEPARTMENT"),
                            new LiteralExpression("FIRST_NAME"),
                            new LiteralExpression("LAST_NAME")
                    ),
                    new FromExpression(
                            new LiteralExpression("EMPLOYEES")),
                    new WhereExpression(
                            new BooleanExpression(
                                    new LiteralExpression("BORN_DATE"),
                                    new LiteralExpression(">"),
                                    new DateExpression("01/01/1990")
                            )
                    )
            );
            return select;
        }

        public static SelectExpression FindByTwoID()
        {
            SelectExpression select = new SelectExpression(
                    new TargetExpression(

                            new LiteralExpression("FIRST_NAME"),
                            new LiteralExpression("DEPARTMENT"),
                            new LiteralExpression("ID")
                    ),
                    new FromExpression(
                            new LiteralExpression("EMPLOYEES")),
                    new WhereExpression(
                            new OrExpression(
                                    new BooleanExpression(
                                            new LiteralExpression("ID"),
                                            new LiteralExpression("="),
                                            new NumericExpression(5)
                                    ),
                                    new BooleanExpression(
                                            new LiteralExpression("ID"),
                                            new LiteralExpression("="),
                                            new NumericExpression(14)
                                    )
                            )
                    )
            );
            return select;
        }

        public static SelectExpression ComplexQuery()
        {
            SelectExpression select = new SelectExpression(
            new TargetExpression(
                new LiteralExpression("FIRST_NAME"),
                new LiteralExpression("LAST_NAME")
            ),
            new FromExpression(
                new LiteralExpression("EMPLOYEES")),
            new WhereExpression(
                new AndExpression(
                    new BooleanExpression(
                        new LiteralExpression("STATUS"),
                        new LiteralExpression("="),
                        new TextExpression("Active")
                    ),
                    new AndExpression(
                        new BooleanExpression(
                            new LiteralExpression("BORN_DATE"),
                            new LiteralExpression("<="),
                            new DateExpression("01/01/1981")
                        ),
                        new OrExpression(
                            new BooleanExpression(
                                new LiteralExpression("DEPARTMENT"),
                                new LiteralExpression("="),
                                new TextExpression("IT")
                            ),
                            new BooleanExpression(
                                new LiteralExpression("DEPARTMENT"),
                                new LiteralExpression("="),
                                new TextExpression("Accounting")
                            )
                        )
                    )
                )
            )
            );
            return select;
        }
    }
}
