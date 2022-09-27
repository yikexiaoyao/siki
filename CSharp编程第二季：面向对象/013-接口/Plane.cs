using System;

namespace _013_接口
{
    class Plane : IFly
    {
        public void Fly()
        {
            Console.WriteLine("飞机在空中飞");
        }

        public void FlyAttack()
        {
            Console.WriteLine("在空中攻击");
        }
    }
}
