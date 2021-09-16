using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Visitor
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
