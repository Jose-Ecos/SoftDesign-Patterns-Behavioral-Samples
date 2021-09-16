using Null_object.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Null_object.DAO
{
    public class EmployeeDAOService
    {

        private List<Employee> EMPLOYEE_LIST = new List<Employee>();

        public EmployeeDAOService()
        {
            Employee emp1 = new Employee(1L, "Jose Ecos", new Address("Av. Blanco Galindo Km 2"));
            EMPLOYEE_LIST.Add(emp1);
        }

        public Employee findEmployeeById(Int64 Id)
        {
            foreach (Employee emp in EMPLOYEE_LIST)
            {
                if (emp.Id == Id)
                {
                    return emp;
                }
            }
            return Employee.NULL_EMPOYEE;
        }
    }
}
