using Null_object.DAO;
using Null_object.Domain;
using System;

namespace Null_object
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDAOService service = new EmployeeDAOService();
            Employee emp1 = service.findEmployeeById(1L);
            Console.WriteLine(emp1.Address.FullAddress);

            Employee emp2 = service.findEmployeeById(2L);
            Console.WriteLine(emp2.Address.FullAddress);
        }
    }
}
