using System.Xml;

namespace XMLTreeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(".\\Breakfast.xml");
        }    

    }
}
