using System;

namespace _008_虚方法
{
    class Enemy
    {
        public virtual void Move()
        {
            Console.WriteLine("敌人正在移动");
        }
        public void AI()
        {
            Console.WriteLine("敌人的AI");
        }
    }
}
