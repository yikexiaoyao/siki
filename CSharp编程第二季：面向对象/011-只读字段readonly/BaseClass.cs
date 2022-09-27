namespace _011_只读字段readonly
{
    class BaseClass
    {
        public readonly int hp = 100;

        public BaseClass()
        {
        }

        public BaseClass(int hp)
        {
            this.hp = hp;
        }
    }
}
