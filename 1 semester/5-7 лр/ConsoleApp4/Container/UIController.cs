using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Controls;

namespace ConsoleApp4.Container
{
    public static class UIController
    {
        public static void ShowAllButtons(UI ui)
        {
            for (int i = 0; i < ui.array.Length; i++)
                if (ui.array[i] is Button) Console.WriteLine(ui.array[i]);
        }

        public static double GetTotalFiguresSquare(UI ui)
        {
            double result = 0;
            for (int i = 0; i < ui.array.Length; i++)
                if (ui.array[i] is GeometricFigure)
                {
                    GeometricFigure tmp = ui.array[i] as GeometricFigure;
                    result += tmp.square;
                }

            return result;
        }

        public static int GetLength(UI ui)
        {
            return ui.array.Length;
        }
    }
}
