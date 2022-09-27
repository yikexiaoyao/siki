using System;

namespace _009_抽象类
{
    //抽象类
    abstract class Enemy
    {
        private int hp;
        private int speed;

        public void Move()
        {
            Console.WriteLine("Move");
        }

        //抽象方法
        public abstract void Attack();
    }
}
