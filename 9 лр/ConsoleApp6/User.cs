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
        public double CurrentCompression { get; }
        public (int x, int y) position;

        public User(string name = "", string lastName = "", int posX = 0, int posY = 0, double compression = 1)
        {
            this.Name = name;
            this.LastName = lastName;
            this.position = (posX, posY);
            this.CurrentCompression = compression;
        }
    }
}
