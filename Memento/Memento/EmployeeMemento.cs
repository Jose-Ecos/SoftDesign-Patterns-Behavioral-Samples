using Memento.Entity;

namespace Memento.Memento
{
    public class EmployeeMemento
    {

        public Employee Employee;

        public EmployeeMemento(Employee Employee)
        {
            this.Employee = Employee;
        }

        public Employee getMemento()
        {
            return Employee;
        }
    }
}
