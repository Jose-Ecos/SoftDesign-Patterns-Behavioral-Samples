using System.Collections.Generic;
using System.Xml.Serialization;
using Visitor.Visitor;

namespace Visitor.Domain
{
    [XmlRoot(ElementName = "Project")]
    public class Project
    {
        [XmlElement(ElementName = "Activities")]
        public List<Activity> Activities { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }


        public void accept(IVisitor visitor)
        {
            visitor.Project(this);
        }

        public List<Activity> GetActivities()
        {
            if (this.Activities == null)
            {
                this.Activities = new List<Activity>();
            }
            return Activities;
        }

    }
}
