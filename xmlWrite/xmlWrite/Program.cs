using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace xmlWrite
{
    class Program
    {
        private static void CreateXmlwithLinq()
        {
            XDocument doc = new XDocument(new XElement("Items",
                new XElement("Item",
                new XElement("ItemNAme", "Cake"),
                new XElement("Price", 250)),
                new XElement("Item",
                new XElement("ItemName", "Pastry"),
                new XElement("Price", "150"))));
            doc.Save(Directory.GetCurrentDirectory() + "//XmlItem.xml");
        }
        private static void ReadXMLwithLinq()
        {
            StringBuilder result = new StringBuilder();
            XDocument xdoc = XDocument.Load(@"");
            var bks = from bk1 in xdoc.Descendants("book")
                      select new
                      {
                          Children = bk1.Descendants("id"),
                        child1 = bk1.Descendants("title"),
                        child2 = bk1.Descendants("price")
                    };

                foreach(var bk in bks)
            {
                        result.Append(bk.Children);
                        result.Append(bk.child1);
                    result.Append(bk.child2);
            }
                    Console.WriteLine(result);
        }
       

        private static void CreateXmldoc()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            XmlElement element1 = doc.CreateElement(string.Empty, "products", string.Empty);
            doc.AppendChild(element1);
            XmlElement element2 = doc.CreateElement(string.Empty, "Product", string.Empty);
            XmlElement element3 = doc.CreateElement(string.Empty, "ptitle", string.Empty);
            XmlText text1 = doc.CreateTextNode("laptop");
            element1.AppendChild(element2);
            element2.AppendChild(element3);
            element3.AppendChild(text1);
            XmlElement element4 = doc.CreateElement(string.Empty, "price", string.Empty);
            XmlText text2 = doc.CreateTextNode("45000");
            element4.AppendChild(text2);
            element2.AppendChild(element4);
            doc.Save(Directory.GetCurrentDirectory() + "//product.xml");
        }
      
       /*tatic void Main(string[] args)
        {

        }*/
    }
}
