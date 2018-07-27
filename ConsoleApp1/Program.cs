using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //XElement authors = new XElement("Authors");
            //// Add child nodes
            //XAttribute name = new XAttribute("Author", "Mahesh Chand");
            //XElement book = new XElement("Book", "GDI+ Programming");
            //XElement cost = new XElement("Cost", "$49.95");
            //XElement publisher = new XElement("Publisher", "Addison-Wesley");
            //XElement author = new XElement("Author");
            //author.Add(name);
            //author.Add(book);
            //author.Add(cost);
            //author.Add(publisher);
            //authors.Add(author);

            //name = new XAttribute("Name", "Mike Gold");
            //book = new XElement("Book", "Programmer's Guide to C#");
            //cost = new XElement("Cost", "$44.95");
            //publisher = new XElement("Publisher", "Microgold Publishing");
            //author = new XElement("Author");
            //author.Add(name);
            //author.Add(book);
            //author.Add(cost);
            //author.Add(publisher);
            //authors.Add(author);

            //name = new XAttribute("Name", "Scott Lysle");
            //book = new XElement("Book", "Custom Controls");
            //cost = new XElement("Cost", "$39.95");
            //publisher = new XElement("Publisher", "C# Corner");
            //author = new XElement("Author");
            //author.Add(name);
            //author.Add(book);
            //author.Add(cost);
            //author.Add(publisher);
            //authors.Add(author);

            //authors.Save(@"Authors.xml");

            string sPolicyName = "#EDD";

            XElement allData = XElement.Load(@"C:\dbpolicy\dbpolicy.xml");
            if (allData != null)
            {
                if (sPolicyName.StartsWith("#"))
                    sPolicyName = sPolicyName.Substring(1);
                var connectionString = allData.Descendants("policy").Where(li=>li.Attribute("name").Value== sPolicyName).Select(ji=>ji.Element("connections")).Elements("connection").SingleOrDefault().Value;
                Console.WriteLine(connectionString);
            }
            else
            {
                string.Format("Unable to find the local instance of dbpolicy.xml at {0}. Attempting to lookup dbpolicy.xml in the location specified in web.config", (object)DbPolicyAccess.s_sConfigPath);
            }

            Console.ReadLine();
        }
    }
}
