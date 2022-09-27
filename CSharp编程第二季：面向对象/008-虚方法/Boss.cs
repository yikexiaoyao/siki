using System;

namespace _008_虚方法
{
    class Boss : Enemy
    {
        public override void Move()
        {
            //base.Move();
            Console.WriteLine("Boss特有的移动方法");
        }

        public void Skill()
        {
            Console.WriteLine("Boss特有的技能");
        }
        public new void AI()
        {
            Console.WriteLine("Boss自己的AI");
        }
    }
}
