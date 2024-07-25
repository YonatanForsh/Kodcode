using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Test4
{
    internal class Test4Manager
    {   
        public static  XmlDocument xmlDoc = new XmlDocument();
        public static string pathString = Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\Queries.xml";
        public static void Main1(string[] args)
         {
            if (File.Exists(pathString))
            {
                 xmlDoc.Load(pathString);
            }
            else
            {
                XmlNode Queries = xmlDoc.CreateElement("Queries");
                xmlDoc.AppendChild(Queries);
                 xmlDoc.Save(pathString);
            }
           
        }
        public static void AddDate(List<string> args)
        {
            XmlElement Query = xmlDoc.CreateElement("query");
            XmlElement Day = xmlDoc.CreateElement("day");
            XmlElement DayMonth = xmlDoc.CreateElement("DayMonth");
            XmlElement Month = xmlDoc.CreateElement("Month");
            XmlElement Year = xmlDoc.CreateElement("Year");
            XmlElement Resolt = xmlDoc.CreateElement("resolt");

            Day.InnerText = args[0];
            DayMonth.InnerText = args[1];
            Month.InnerText = args[2];
            Year.InnerText = args[3];
            Resolt.InnerText = "ב" + Day.InnerText + DayMonth + Month + Year + "לבריאת העולם";

            Query.AppendChild(Day);
            Query.AppendChild(DayMonth);
            Query.AppendChild(Month);
            Query.AppendChild(Year);
            Query.AppendChild(Resolt);

            xmlDoc.AppendChild(Query);

            xmlDoc.Save(pathString);
        }
    }
}

