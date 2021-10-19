using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Figures;
using ConsoleApp4.Controls;
using ConsoleApp4.Container;
using ConsoleApp4.Exceptions;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle c1 = new Circle(-1); // FigureException
                Circle c2 = new Circle(9);
                Rectangle r1 = new Rectangle(12, 5);
                Rectangle r2 = new Rectangle(15, 9);

                UI ui = new UI(c2, r1, r2); 
                Console.WriteLine(ui[4]); // UIOutOfRangeException

                int a = 123;
                ui[1] = a; // UIException
            }
            catch(FigureException e)
            {
                Console.WriteLine($"[{e.ErrorClass}], error value: {e.ErrorValue}: {e.Message}\n");
            }
            catch (UIOutOfRangeException e)
            {
                Console.WriteLine($"[{e.ErrorClass}], error index: {e.ErrorIndex}: {e.Message}\n");
            }
            catch (UIException e)
            {
                Console.WriteLine($"[{e.ErrorClass}]: {e.Message}\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"[{e.InnerException}]: {e.Message}\n");
            }
            finally
            {
                Console.WriteLine("This line is always appears in the end.");
            }

            Console.ReadKey();
        }
    }
}
