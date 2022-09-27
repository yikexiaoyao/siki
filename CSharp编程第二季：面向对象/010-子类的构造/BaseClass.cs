using System;

namespace _010_子类的构造
{
    class BaseClass
    {
        private int hp;
        private int speed;

        public BaseClass(int hp, int speed)
        {
            this.hp = hp;
            this.speed = speed;
        }

        public BaseClass()
        {
            Console.WriteLine("BaseClass");
        }
    }
}
