using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Figures;
using ConsoleApp4.Controls;
using ConsoleApp4.Container;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(13, ConsoleColor.Green);
            Circle circle2 = new Circle(11, ConsoleColor.DarkMagenta);
            Rectangle rect = new Rectangle(5, 2, ConsoleColor.Cyan);
            Button btn1 = new Button(true, "btn1");
            Button btn2 = new Button(false, "btn2");

            //Console.WriteLine(ui[0]);

            //ui.ShowAllButtons();
            //Console.WriteLine(ui.GetLength());
            //ui.GetTotalFiguresSquare();

            UI ui = new UI(circle1, btn1, circle2);

            Console.WriteLine(UIController.GetTotalFiguresSquare(ui));

            //ui.Show();
            //ui.Remove(1);
            //Console.WriteLine();
            //ui.Show();

            Console.ReadKey();
        }
    }
}
