using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Visitor.Domain;
using Visitor.Visitor;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Project project = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Project));
                StreamReader reader = new StreamReader("C:/Files/Project.xml");
                project = (Project)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            //Obtain the total cost of the project  
            CostProjectVisitor costVisitor = new CostProjectVisitor();
            project.accept(costVisitor);
            double cost = (double)costVisitor.GetResult();
            Console.WriteLine("Total cost > " + cost);

            //Get the sale price of the project  
            PriceProjectVisitor priceVisitor = new PriceProjectVisitor();
            project.accept(priceVisitor);
            double price = (double)priceVisitor.GetResult();
            Console.WriteLine("Total price > " + price);
            Console.WriteLine("Total gain > " + (price - cost));

            //Show the total to pay per employee 
            Console.WriteLine("\n:::::::: Pay the workers :::::::");
            PaymentProjectVisitor paymentVisitor = new PaymentProjectVisitor();
            project.accept(paymentVisitor);
            List<EmployeePay> result = (List<EmployeePay>)paymentVisitor.GetResult();
            foreach (EmployeePay pay in result)
            {
                Console.WriteLine(pay.EmployeeName + " > " + pay.TotalPay);
            }
        }
    }
}
