using System;
using Visitor.Domain;

namespace Visitor.Visitor
{
    public interface IVisitor
    {
        void Project(Project project);
        void Activity(Activity activity);
        void Employee(Employee employee);
        Object GetResult();
    }
}