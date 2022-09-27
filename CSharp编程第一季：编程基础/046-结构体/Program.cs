namespace _046_结构体
{
    class Program
    {
        //struct StudentInfo
        //{
        //    public int age;
        //    public string name;
        //    public int grade;
        //    public int id;
        //}
        struct Position
        {
            public double x;
            public double y;
            public double z;
            public void PrintPosition()
            {
                System.Console.WriteLine(x + "," + y + "," + z);
            }
        }
        //static void PrintPosition(Position p)
        //{
        //    System.Console.WriteLine(p.x + "," + p.y + "," + p.z);
        //}
        struct Name
        {
            public string FirstName;
            public string LastName;
            public string FullName()
            {
                return LastName + FirstName;
            }
        }
        static void Main(string[] args)
        {
            //StudentInfo student1;
            //student1.age = 10;
            //student1.name = "小明";
            //student1.grade = 2;
            //student1.id = 20220001;
            //System.Console.WriteLine(student1.name);

            //StudentInfo[] students = new StudentInfo[10];
            //students[0].age = 30;
            //System.Console.WriteLine(students[0].age);

            Position p1;
            p1.x = 23.3;
            p1.y = 3.4;
            p1.z = 1;

            //PrintPosition(p1);
            //结构体函数
            p1.PrintPosition();

            Name name;
            name.FirstName = "三";
            name.LastName = "张";
            //System.Console.WriteLine("My name is: " + name.LastName + name.FirstName + ".");
            System.Console.WriteLine("My name is: " + name.FullName() + ".");

            System.Console.ReadKey();
        }
    }
}
