namespace Iterator
{
    using System;
    using Iterator.Items;

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Juan", "CEO",
                                new Employee("Pedro", "President",
                                        new Employee("Liliana", "VP",
                                                new Employee("Oscar", "Manager",
                                                        new Employee("Mario", "Developer"),
                                                        new Employee("Rodolfo", "Developer")),
                                                new Employee("Sofia", "Manager",
                                                        new Employee("Adrian", "Sr Developer"),
                                                        new Employee("Rebeca", "Developer")
                                                )
                                        )
                                )
                        );


            IIterator<Employee> empIterator = employee.CreateIterator();
            while (empIterator.HasNext())
            {
                Employee emp = empIterator.Next();
                Console.WriteLine("emp > " + emp.ToString());
            }
        }
    }
}
