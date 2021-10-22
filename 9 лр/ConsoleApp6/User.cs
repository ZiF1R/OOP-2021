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
        public Position position;

        public struct Position
        {
            public int X { get; }
            public int Y { get; }

            public Position(int x = 0, int y = 0)
            {
                this.X = x;
                this.Y = y;
            }
        }

        public User(string name = "", string lastName = "", int posX = 0, int posY = 0)
        {
            this.Name = name;
            this.LastName = lastName;
            this.position = new Position(posX, posY);
        }
    }
}
