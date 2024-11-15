using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace _233543_Assign_03
{
    class Program
    {
        
        static void Main(string[] args)
        {
            mbt_WriteXml();
            mbt_ReadXml();
        }


        static void mbt_WriteXml()
        {

            string filePath = "gps.xml";

            XmlWriterSettings wrt = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t"
            };
        

            using (XmlWriter writer = XmlWriter.Create(filePath, wrt))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("GPS_Log");

                writer.WriteStartElement("Position");
                writer.WriteAttributeString("DateTime", DateTime.Now.ToString());
                writer.WriteElementString("x", "65.8973342");
                writer.WriteElementString("y", "72.3452346");

                writer.WriteStartElement("SatteliteInfo");
                writer.WriteElementString("Speed", "40");
                writer.WriteElementString("NoSatt", "7");
                writer.WriteEndElement();

                writer.WriteEndElement();

                writer.WriteStartElement("Image");
                writer.WriteAttributeString("Resolution", "1024x800");
                writer.WriteElementString("Path", @"\images\1.jpg");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        static void mbt_ReadXml()
        {
            string filePath = "gps.xml";

            try
            {
                using (XmlReader reader = XmlReader.Create(filePath))
                {
                    while (reader.Read())
                    {

                        if (reader.NodeType == XmlNodeType.Element)
                        {
                           
                            Console.WriteLine($"<{reader.Name}>");

                            if (reader.HasAttributes)
                            {
                                
                                while (reader.MoveToNextAttribute())
                                {
                                    Console.WriteLine($"  {reader.Name}=\"{reader.Value}\"");
                                }
                                reader.MoveToElement(); 
                            }
                        }

                        else if (reader.NodeType == XmlNodeType.Text)
                        {
                            
                            Console.WriteLine($"  {reader.Value}");
                        }

                        else if (reader.NodeType == XmlNodeType.EndElement)
                        {
                            
                            Console.WriteLine($"</{reader.Name}>");
                        }
                        

                    }
                       Console.ReadLine();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"XML File Reading Error!: {ex.Message}");
            }
        }
    }
}
