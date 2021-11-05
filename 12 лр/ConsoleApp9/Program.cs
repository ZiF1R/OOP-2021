using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Выполните сериализацию / десериализацию объекта используя
            //a.бинарный
            GeometricFigure figure1 = new GeometricFigure(12, 3);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream file = new FileStream("figure1.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(file, figure1);
            }
            using (FileStream file = new FileStream("figure1.dat", FileMode.Open))
            {
                GeometricFigure figureDes = (GeometricFigure)binaryFormatter.Deserialize(file);
                Console.WriteLine("> Deserialized[binary] figure height: {0}", figureDes.Height);
            }

            
            //d.XML формат.
            GeometricFigure figure2 = new GeometricFigure(32, 23);

            XmlSerializer xmlFormatter = new XmlSerializer(typeof(GeometricFigure));
            using (FileStream file = new FileStream("figure2.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(file, figure2);
            }
            using (FileStream file = new FileStream("figure2.xml", FileMode.Open))
            {
                GeometricFigure figureDes = (GeometricFigure)xmlFormatter.Deserialize(file);
                Console.WriteLine("> Deserialized[XML] figure height: {0}", figureDes.Height);
            }

            Console.ReadKey();
        }
    }
}
