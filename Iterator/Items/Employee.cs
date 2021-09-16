namespace Iterator.Items
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Employee: IContainer<Employee>
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public List<Employee> Subordinates { get; set; }

        public Employee(string role, string puesto, params Employee[] subordinates)
        {
            this.Name = role;
            this.Role = puesto;
            this.Subordinates = subordinates.OfType<Employee>().ToList();
        }

        public IIterator<Employee> CreateIterator()
        {
            return new TreeEmployeeIterator(this);
        }

        public Employee GetThis()
        {
            return this;
        }

        public void AddSubordinate(Employee subordinate)
        {
            if (subordinate == null)
            {
                Subordinates = new List<Employee>();
            }

            Subordinates.Add(subordinate);
        }

        public override string ToString()
        {
            return "Employee{" + "name=" + Name + ", role=" + Role + '}';
        }

        private class TreeEmployeeIterator : IIterator<Employee>
        {
            private List<Employee> list = new List<Employee>();
            private int index = 0;

            private Employee employee;

            public TreeEmployeeIterator(Employee employee)
            {
                this.employee = employee;
                AddRecursive(this.employee);
            }

            public void AddRecursive(Employee employee)
            {
                list.Add(employee);
                if (employee.Subordinates != null)
                {
                    foreach (Employee subordinate in employee.Subordinates)
                    {
                        AddRecursive(subordinate);
                    }
                }
            }

            public bool HasNext()
            {
                if (list.Count == 0)
                {
                    return false;
                }

                return index < list.Count;
            }

            public Employee Next()
            {
                if (!HasNext())
                {
                    throw new SystemException("There are no more elements.");
                }

                return list[index++];
            }
        }
    }
}
