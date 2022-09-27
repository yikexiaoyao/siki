namespace _007_继承
{
    class Boss : Enemy
    {
        private int attack;

        public Boss(int hp, int speed, int attack)
        {
            this.hp = hp;
            this.speed = speed;
            this.attack = attack;
        }

        public void Skill()
        {
            System.Console.WriteLine("Boss Skill");
        }

        public void Print()
        {
            System.Console.WriteLine("HP:" + hp);
            System.Console.WriteLine("Speed:" + speed);
            System.Console.WriteLine("Attack:" + attack);
        }
    }
}
