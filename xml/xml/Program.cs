using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace xml
{
    class Program
    {
        private static void Xmldemo()
        {
            XmlDocument xmld = new XmlDocument();
            xmld.Load(@"D:\keerthi\c#\xml\xml\XMLFile1.xml");
            XmlNode currentnode = xmld.DocumentElement.FirstChild;
            Console.WriteLine(currentnode.OuterXml);
            XmlNode nextnode = currentnode.NextSibling;
            Console.WriteLine(nextnode.OuterXml);
            XmlNode node3 = nextnode.NextSibling;
            Console.WriteLine(node3.OuterXml);
        }

        static void Main(string[] args)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;


            FileStream fs = new FileStream(@"D:\keerthi\c#\xml\xml\XMLFile1.xml", FileMode.Open,FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("book");
            for(i=0;i<=xmlnode.Count-1;i++)
            {
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + " " +
                    xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + " " +
                    xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                Console.WriteLine(str);
            }
        }
    }
}
