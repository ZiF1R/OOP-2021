using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            using (FileStream file = new FileStream("binaryFigure.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(file, figure1);
            }
            using (FileStream file = new FileStream("binaryFigure.dat", FileMode.Open))
            {
                GeometricFigure figureDes = (GeometricFigure)binaryFormatter.Deserialize(file);
                Console.WriteLine("> Deserialized[binary] figure height: {0}", figureDes.Height);
            }


            //b.SOAP
            GeometricFigure figure3 = new GeometricFigure(32, 23);

            SoapFormatter soapFormatter = new SoapFormatter();
            using (FileStream file = new FileStream("soapFigure.dat", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(file, figure3);
            }
            using (FileStream file = new FileStream("soapFigure.dat", FileMode.Open))
            {
                GeometricFigure figureDes = (GeometricFigure)soapFormatter.Deserialize(file);
                Console.WriteLine("> Deserialized[SOAP] figure height: {0}", figureDes.Height);
            }


            //b.JSON
            //GeometricFigure figure4 = new GeometricFigure() { Height = 12, Width = 4 };

            //string jsonSer = JsonSerializer.Serialize(figure4);
            //Console.WriteLine("> Serialized[JSON] figure:\n{0}", jsonSer);
            //GeometricFigure jsonDes = JsonSerializer.Deserialize<GeometricFigure>(jsonSer);
            //Console.WriteLine("> Deserialized[JSON] figure:\n{0}", jsonDes);

            async void func()
            {
                using (FileStream fs = new FileStream("jsonFigure.json", FileMode.OpenOrCreate))
                {
                    GeometricFigure figure = new GeometricFigure() { Height = 12, Width = 4 };
                    await JsonSerializer.SerializeAsync(fs, figure);
                }
                using (FileStream fs = new FileStream("jsonFigure.json", FileMode.Open))
                {
                    GeometricFigure restoredFigure = await JsonSerializer.DeserializeAsync<GeometricFigure>(fs);
                    Console.WriteLine($"> Deserialized[JSON] figure:\n" +
                        $"\tWidth: {restoredFigure.Width}  Height: {restoredFigure.Height}");
                }
            }

            //d.XML формат.5
            GeometricFigure figure2 = new GeometricFigure(3, 7);

            XmlSerializer xmlFormatter = new XmlSerializer(typeof(GeometricFigure));
            using (FileStream file = new FileStream("xmlFigure.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(file, figure2);
            }
            using (FileStream file = new FileStream("xmlFigure.xml", FileMode.Open))
            {
                GeometricFigure figureDes = (GeometricFigure)xmlFormatter.Deserialize(file);
                Console.WriteLine("> Deserialized[XML] figure height: {0}", figureDes.Height);
            }

            Console.ReadKey();
        }
    }
}
