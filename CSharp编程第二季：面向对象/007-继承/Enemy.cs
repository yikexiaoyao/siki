using System;

namespace _007_继承
{
    class Enemy
    {
        protected int hp;
        protected int speed;

        public void AI()
        {
            Console.WriteLine("AI");
        }

        public void Move()
        {
            Console.WriteLine("Move");
        }
    }
}
