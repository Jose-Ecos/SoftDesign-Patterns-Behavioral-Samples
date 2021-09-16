using System.Xml.Serialization;
using Visitor.Visitor;

namespace Visitor.Domain
{
    [XmlRoot(ElementName = "responsible")]
    public class Employee
    {

        public Employee()
        {
        }

        public Employee(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "price")]
        public double Price { get; set; }

        public void accept(IVisitor visitor)
        {
            visitor.Employee(this);
        }
    }
}
