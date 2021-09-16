using System;
using System.Collections.Generic;
using Visitor.Domain;

namespace Visitor.Visitor
{
    public class PaymentProjectVisitor : IVisitor
    {

        private Dictionary<string, double> employeePayment = new Dictionary<string, double>();

        public void Project(Project project)
        {
            foreach (Activity act in project.Activities)
            {
                act.accept(this);
            }
        }

        public void Activity(Activity activity)
        {
            activity.Responsible.accept(this);
            foreach (Activity act in activity.Activities)
            {
                act.accept(this);
            }
        }

        public void Employee(Employee employee)
        {
            string resp = employee.Name;
            if (employeePayment.ContainsKey(resp))
            {
                employeePayment[resp] = employeePayment[resp] + employee.Price;
            }
            else
            {
                employeePayment.Add(resp, employee.Price);
            }
        }

        public Object GetResult()
        {
            List<EmployeePay> response = new List<EmployeePay>();

            foreach (string key in employeePayment.Keys)
            {
                response.Add(new EmployeePay(key, employeePayment[key]));
            }
            return response;
        }

    }
}
