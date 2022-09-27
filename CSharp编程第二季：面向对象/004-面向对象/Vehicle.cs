using System;

namespace _004_面向对象
{
    class Vehicle
    {
        public string brans;
        public int speed;
        public int maxSpeed;
        public float weight;

        public void Run()
        {
            Console.WriteLine("启动。。。。。。");
        }
        public void Stop()
        {
            Console.WriteLine("刹车。。。。。。");
        }
    }
}
