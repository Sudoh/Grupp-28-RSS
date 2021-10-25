using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using modelss;
using DataAccesLayer.Exceptions;
namespace DataAccesLayer
{
    internal class SerializerForXml
    {
        public void Serialize(List<Podcast> personList)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream outFile = new FileStream("Persons.xml", FileMode.Create,
                    FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, personList);
                }
            }
            catch (Exception e)
            {
                throw new SerializerException("Persons.xml", "Could not serialize to the file");
            }
        }

        public List<Podcast> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
                using (FileStream inFile = new FileStream("Persons.xml", FileMode.Open,
                    FileAccess.Read))
                {
                    return (List<Podcast>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception e)
            {
                throw new SerializerException("Persons.xml", "Could not deserialize the file.");
            }
            
        }
    }
}
