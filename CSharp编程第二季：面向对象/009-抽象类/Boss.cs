using System;

namespace _009_抽象类
{
    class Boss : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Boss攻击");
        }
    }
}
