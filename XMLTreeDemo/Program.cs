using System.Xml;
using System.Xml.Linq;

namespace XMLTreeDemo
{
    internal class Program
    {
        static List<string> xmlnodes = new List<string>();
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(".\\Breakfast.xml");
            XmlElement root = doc.DocumentElement;
            SelectNodesOnAttribute(root);
            TraverseNodes(doc.ChildNodes);
        }

        private static void TraverseNodes(XmlNodeList childNodes)
        {
            foreach (XmlNode node in childNodes)
            {
                List<string> temp = new List<string>();
                temp.Add("Node name: " + node.Name.ToString());
                XmlAttributeCollection xmlAttributes = node.Attributes;
                if (xmlAttributes != null) 
                {
                    foreach (XmlAttribute attr in xmlAttributes)
                    {
                        temp.Add("Attribute: " + attr.Name +": "+ attr.Value);
                    }
                }
                xmlnodes.AddRange(temp);
                TraverseNodes(node.ChildNodes);
            }
        }

        private static void SelectNodesOnAttribute(XmlElement? root)
        {
            XmlNode node = root.SelectSingleNode("//calories[@protein_percentage]");
        }
    }
}
