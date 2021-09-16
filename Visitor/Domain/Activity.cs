using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Visitor.Visitor;

namespace Visitor.Domain
{
    [XmlRoot(ElementName = "Activities")]
    public class Activity
    {
        [XmlElement(ElementName = "responsible")]
        public Employee Responsible { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "price")]
        public double Price { get; set; }

        [XmlElement(ElementName = "Activities")]
        public List<Activity> Activities { get; set; }

        public Activity()
        {
        }

        public Activity(string name, Int64 price, Employee responsible)
        {
            this.Name = name;
            this.Price = price;
            this.Responsible = responsible;
        }

        public List<Activity> GetActivities()
        {
            if (this.Activities == null)
            {
                this.Activities = new List<Activity>();
            }
            return Activities;
        }


        public void addActivitie(Activity Activities)
        {
            if (this.Activities == null)
            {
                this.Activities = new List<Activity>();
            }
            this.Activities.Add(Activities);
        }

        public void removeActivitie(Activity Activities)
        {
            if (this.Activities == null)
            {
                this.Activities = new List<Activity>();
            }
            this.Activities.Remove(Activities);
        }

        public void accept(IVisitor visitor)
        {
            visitor.Activity(this);
        }

    }
}
