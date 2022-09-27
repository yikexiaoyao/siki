using System;

namespace _010_子类的构造
{
    class DrivedClass : BaseClass
    {
        private int attack;

        public DrivedClass() : base()
        {
            Console.WriteLine("DrivedClass");
        }

        public DrivedClass(int attack)
        {
            this.attack = attack;
        }

        public DrivedClass(int hp, int speed, int attack) : base(hp, speed)
        {
            this.attack = attack;
        }
    }
}
