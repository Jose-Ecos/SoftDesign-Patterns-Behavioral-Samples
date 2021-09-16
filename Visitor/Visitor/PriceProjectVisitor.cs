using System;
using Visitor.Domain;

namespace Visitor.Visitor
{
    public class PriceProjectVisitor : IVisitor
    {

        private double totalPrice;

        public void Project(Project project)
        {
            foreach (Activity act in project.Activities)
            {
                act.accept(this);
            }
        }

        public void Activity(Activity activity)
        {
            totalPrice += activity.Price;
            foreach (Activity act in activity.Activities)
            {
                act.accept(this);
            }
        }

        public void Employee(Employee employee)
        {
            // Not Interesting for this Visitor  
        }

        public Object GetResult()
        {
            return totalPrice;
        }
    }
}
