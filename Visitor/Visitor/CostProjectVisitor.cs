using System;
using Visitor.Domain;

namespace Visitor.Visitor
{
    public class CostProjectVisitor : IVisitor
    {

        private double TotalCost;

        public void Project(Project project)
        {
            foreach (Activity act in project.GetActivities())
            {
                act.accept(this);
            }
        }

        public void Activity(Activity activity)
        {
            activity.Responsible.accept(this);
            foreach (Activity act in activity.GetActivities())
            {
                act.accept(this);
            }
        }

        public void Employee(Employee employee)
        {
            TotalCost += employee.Price;
        }

        public Object GetResult()
        {
            return TotalCost;
        }
    }
}
