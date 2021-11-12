using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Linq;
using System.Linq;
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

            //d.XML формат
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

            //2. Создайте коллекцию (массив) объектов и выполните сериализацию / десериализацию.
            GeometricFigure[] figures = new GeometricFigure[]
            {
                new GeometricFigure(3, 7),
                new GeometricFigure(8, 4),
                new GeometricFigure(12, 5),
                new GeometricFigure(9, 1),
                new GeometricFigure(8, 16)
            };

            XmlSerializer xmlFormatter1 = new XmlSerializer(typeof(GeometricFigure[]));
            using (FileStream file = new FileStream("xmlFigures.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter1.Serialize(file, figures);
            }
            using (FileStream file = new FileStream("xmlFigures.xml", FileMode.Open))
            {
                GeometricFigure[] figuresDes = (GeometricFigure[])xmlFormatter1.Deserialize(file);

                Console.WriteLine("\n> Deserialized[XML] figures:");
                foreach (GeometricFigure figure in figuresDes)
                    Console.Write(figure);
            }

            //3.Используя XPath напишите два селектора для вашего XML документа.
            XPathDocument docNav = new XPathDocument("./xmlFigures.xml");
            XPathNavigator nav = docNav.CreateNavigator();
            string expr1 = "/ArrayOfGeometricFigure/GeometricFigure/Width[../Height>5]";
            string expr2 = "/ArrayOfGeometricFigure/GeometricFigure[./Height>5]/Height";
            string expr3 = "/ArrayOfGeometricFigure/GeometricFigure[(./Height + ./Width)>10]/Height";
            string expr4 = "/ArrayOfGeometricFigure/GeometricFigure[(./Height + ./Width)>10]/Width";
            XPathNodeIterator iterator1 = nav.Select(expr2);
            XPathNodeIterator iterator2 = nav.Select(expr1);
            XPathNodeIterator iterator3 = nav.Select(expr3);
            XPathNodeIterator iterator4 = nav.Select(expr4);

            Console.WriteLine("\n> Figures in which height > 5:");
            while (iterator1.MoveNext() && iterator2.MoveNext())
            {
                Console.WriteLine("({0}:{1})", iterator1.Current, iterator2.Current);
            };

            Console.WriteLine("\n> Figures in which sum of height and width > 10:");
            while (iterator3.MoveNext() && iterator4.MoveNext())
            {
                Console.WriteLine("({0}:{1})", iterator3.Current, iterator4.Current);
            };

            //4. Используя Linq to XML (или Linq to JSON) создайте новый xml (json) -
            //документ и напишите несколько запросов.
            XDocument students = new XDocument(
                new XElement("Students",
                    new XElement("Student",
                        new XElement("Name", "Dobriyan Alex"),
                        new XElement("Course", "2",
                            new XAttribute("group", "10"),
                            new XAttribute("subgroup", "1")),
                        new XElement("AverageMark", "8,9")),
                    new XElement("Student",
                        new XElement("Name", "Linevich Cheslav"),
                        new XElement("Course", "2",
                            new XAttribute("group", "10"),
                            new XAttribute("subgroup", "1")),
                        new XElement("AverageMark", "7,6")),
                    new XElement("Student",
                        new XElement("Name", "Michael Voznenko"),
                        new XElement("Course", "2",
                            new XAttribute("group", "10"),
                            new XAttribute("subgroup", "2")),
                        new XElement("AverageMark", "7"))
                    )
                );

            students.Save("Students.xml");
            var st =
                from student in students.Elements().Elements("Student").ToArray()
                where Convert.ToDouble(student.Element("AverageMark").Value) > 8
                select student;

            Console.WriteLine("\n> Students with average mark > 8:");
            foreach (XElement student in st)
                Console.WriteLine($"\nStudent: {student.Element("Name").Value}\n" +
                    $"Course: {student.Element("Course").Value}\n" +
                    $"Group: {student.Element("Course").Attribute("group").Value}-" +
                    $"{student.Element("Course").Attribute("subgroup").Value}\n" +
                    $"Average mark: {student.Element("AverageMark").Value}");


            var st1 =
                from student in students.Elements().Elements("Student").ToArray()
                where Convert.ToInt32(student.Element("Course").Attribute("subgroup").Value) == 2
                select student;

            Console.WriteLine("\n> Students from second subgroup:");
            foreach (XElement student in st1)
                Console.WriteLine($"\nStudent: {student.Element("Name").Value}\n" +
                    $"Course: {student.Element("Course").Value}\n" +
                    $"Group: {student.Element("Course").Attribute("group").Value}-" +
                    $"{student.Element("Course").Attribute("subgroup").Value}\n" +
                    $"Average mark: {student.Element("AverageMark").Value}");


            Console.ReadKey();
        }
    }
}
