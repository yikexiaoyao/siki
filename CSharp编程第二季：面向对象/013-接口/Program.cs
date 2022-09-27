using System;

namespace _013_接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //Plane p = new Plane();
            //p.Fly();
            //p.FlyAttack();

            IFly fly;
            fly = new Plane();
            fly.Fly();
            fly.FlyAttack();

            fly = new Bird();
            fly.Fly();
            fly.FlyAttack();

            Console.ReadKey();
        }
    }
}
