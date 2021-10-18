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
            Circle circle2 = new Circle(11, ConsoleColor.Yellow);
            Rectangle rect = new Rectangle(5, 2, ConsoleColor.Cyan);
            Button btn1 = new Button(true, "btn1");
            Button btn2 = new Button(false, "btn2");

            circle1.center.getCoordinates();

            UI ui = new UI(circle1, btn1, circle2);
            Console.WriteLine("\n> Get element at index:\n{0}\n", ui[1]);
            ui.Add(rect);
            ui.Add(btn2);
            ui.Remove(0);

            Console.WriteLine("\n> All figures:\n");
            ui.Show();

            Console.WriteLine("\n> Get total figures square: {0}", UIController.GetTotalFiguresSquare(ui));
            Console.WriteLine("\n> Show all buttons in ui:\n");
            UIController.ShowAllButtons(ui);
            Console.WriteLine("\n> Get length of ui: {0}", UIController.GetLength(ui));

            Console.ReadKey();
        }
    }
}
