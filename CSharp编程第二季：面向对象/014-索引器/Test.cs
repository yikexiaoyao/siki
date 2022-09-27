namespace _014_索引器
{
    class Test
    {
        private string[] name = new string[10];
        public string this[int index]
        {
            set
            {
                name[index] = value;
            }
            get
            {
                return name[index];
            }
        }
    }
}
