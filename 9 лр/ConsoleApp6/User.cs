using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //  Создать класс Пользователь с событиями Переместить(можно
    //  задать смещение) и Сжать(коэффициент сжатия). В main создать
    //  некоторое количество объектов разного типа.Часть объектов
    //  подписать на одно событие, часть на два (часть можете не
    //  подписывать). Проверить состояния объектов после наступления событий.

    public class User
    {
        public string Name { get; }
        public string LastName { get; }
        public double CurrentCompression { get; set; }
        public (int x, int y) position;

        public User(string name = "", string lastName = "", int posX = 0, int posY = 0, double compression = 1)
        {
            this.Name = name;
            this.LastName = lastName;
            this.position = (posX, posY);
            this.CurrentCompression = compression;
        }


        // events

        public delegate void MoveHandler(int posX = 0, int posY = 0);
        public delegate void CompressHandler(int coefficient = 1);
        public event MoveHandler Move;
        public event CompressHandler Compress;

        // methods

        public void GetCurrentCompression()
        {
            Console.WriteLine($"Current compression: {this.CurrentCompression}");
        }

        public void GetCurrentPosition()
        {
            Console.WriteLine($"Current position: {this.position}");
        }
    }
}
